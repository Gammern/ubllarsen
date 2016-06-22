using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using ublxsd.Extensions;

namespace ublxsd
{
    class UblCodeGenerator
    {
        private readonly UblXsdSettings UblSettings;

        public UblCodeGenerator(UblXsdSettings ublSettings)
        {
            this.UblSettings = ublSettings;
        }

        public IEnumerable<CodeTypeDeclaration> CreateCodeTypeDeclarations(XmlSchemaSet schemaSet, string[] targetNamespaces)
        {
            XmlSchemas allSchemas = new XmlSchemas();
            foreach (XmlSchema schema in schemaSet.Schemas().Cast<XmlSchema>())
            {
                allSchemas.Add(schema);
            }

            allSchemas.Compile(UblSettings.XsdValidationEvent, true);
            if (!allSchemas.IsCompiled)
            {
                Console.WriteLine("Warning: allSchemas is not compiled!!! .NET BUG?");
            }
            XmlSchemaImporter importer = new XmlSchemaImporter(allSchemas);
            importer.Extensions.Clear(); // Remove System.Data.SqlTypes.TypeXxxx stuff
            CodeNamespace bigBlobCodeNamespace = new CodeNamespace("UblDummyLibrary"); // temporary to hold everything

            CodeGenerationOptions opts = CodeGenerationOptions.GenerateOrder;
            if (UblSettings.OptionMemberTypeToGenerate == UblXsdSettings.FieldTypesEnum.Property)
            {
                opts |= CodeGenerationOptions.GenerateProperties;
            }
            XmlCodeExporter exporter = new XmlCodeExporter(bigBlobCodeNamespace, null, opts);

            foreach (var ns in targetNamespaces)
            {
                XmlSchema schema = allSchemas[ns];
                foreach (XmlSchemaElement element in schema.Elements.Values)
                {
                    XmlTypeMapping mapping = importer.ImportTypeMapping(element.QualifiedName);
                    exporter.ExportTypeMapping(mapping);
                }
            }

            IEnumerable<CodeTypeDeclaration> allCodeDecls = bigBlobCodeNamespace.Types.Cast<CodeTypeDeclaration>().ToList();

            foreach (var codeDecl in allCodeDecls)
            {
                // clear auto generated comment "<remarks/>"
                codeDecl.Comments.Clear();
                foreach (var item in codeDecl.Members.OfType<CodeTypeMember>())
                {
                    item.Comments.Clear();
                }

                // populate userdata with things we often query from xsd files
                XmlQualifiedName qname = codeDecl.GetQualifiedName();
                XmlSchema schema = allSchemas[qname.Namespace];
                codeDecl.UserData[Constants.XmlSchemaLabel] = schema;
                XmlSchemaType xmlSchemaType = (XmlSchemaType)schema.SchemaTypes[qname];
                codeDecl.UserData[Constants.XmlSchemaTypeLabel] = xmlSchemaType;

                if (xmlSchemaType == null)
                {
                    Console.WriteLine($"Warning: {codeDecl.Name} is missing schema information {qname}");
                }
            }

            return allCodeDecls;
        }

        public void GenerateAndSaveCodeFilesBySchema(IEnumerable<CodeTypeDeclaration> allCodeDecls, UblNamespaceManager nsMan)
        {
            var codeDeclsBySchema = (from t in allCodeDecls
                                     group t by t.GetSchema() into g
                                     select g).ToList();

            foreach (var schemaGroup in codeDeclsBySchema) // TODO: Might miss out on empty files. Find some other means to enum files to be generated
            {
                XmlSchema schema = schemaGroup.Key;
                CodeNamespace codeNamespace = nsMan.GetCodeNamespaceForXmltargetNamespace(schema.TargetNamespace);
                codeNamespace.Types.AddRange(schemaGroup.ToArray());

                if (UblSettings.OptionMemberTypeToGenerate == UblXsdSettings.FieldTypesEnum.AutoProperty)
                {
                    ConvertFieldsToAutoProperties(codeNamespace); // Hack: append get/set to the Name of a field. 
                }

                string csCodeFilename = schema.GetCSharpFilename(UblSettings.CodeGenOutputPath);
                SaveToFile(codeNamespace, csCodeFilename);
            }
        }

        private void ConvertFieldsToAutoProperties(CodeNamespace codeNamespace)
        {
            codeNamespace.Types.Cast<CodeTypeDeclaration>()
                .Where(c => c.IsClass)
                .SelectMany(c => c.Members.OfType<CodeMemberField>()) // Only apply to fields
                .ToList()
                .ForEach(c => c.Name += " { get; set; }//"); // Remove double backslash later on
        }

        public void SaveToFile(CodeNamespace ns, string filename)
        {
            CSharpCodeProvider provider = new CSharpCodeProvider();
            CodeGeneratorOptions cOpts = new CodeGeneratorOptions { BracingStyle = "C", BlankLinesBetweenMembers = true };
            StringBuilder sb = new StringBuilder();
            using (StringWriter sw = new StringWriter(sb))
            {
                provider.GenerateCodeFromNamespace(ns, sw, cOpts);
            }

            sb = sb.Replace(" { get; set; }//;", " { get; set; }")
                .Replace("Namespace=\"", "Namespace = \"");

            // Enclose XmlRootAttribute with #if and #endif
            const string rootAttributeFragment = "[System.Xml.Serialization.XmlRootAttribute(";
            if (!filename.Contains(Constants.abstractBaseSchemaName)) // skip the abstract base doc
            {
                var fileContent = sb.ToString();
                if (fileContent.Contains(rootAttributeFragment))
                {
                    var lines = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();
                    var lineNum = lines.FindIndex(s => s.Contains(rootAttributeFragment));
                    lines.Insert(lineNum + 1, "#endif");
                    lines.Insert(lineNum, "#if USE_UBL_XMLROOTATTRIBUTE");
                    sb = new StringBuilder(string.Join(Environment.NewLine, lines));
                }
            }

            using (StreamWriter writer = File.CreateText(filename))
            {
                writer.Write(sb.ToString());
                Console.WriteLine(filename);
            }
        }
    }
}
