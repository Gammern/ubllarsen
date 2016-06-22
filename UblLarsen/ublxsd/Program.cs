using System;
using System.Linq;
using System.Xml;
using System.Xml.Schema;
using ublxsd.Extensions;

namespace ublxsd
{
    class Program
    {
        static void Main(string[] args)
        {
            UblXsdSettings ublSettings = new UblXsdSettings
            {
                XsdValidationEvent = SchemaValidationEventHandler,
                UblXsdInputPath = @"..\..\..\UBL-2.1\xsd",  // Content originally from ubl zip download.
                CodeGenOutputPath = @"..\..\..\UblLarsen.Ubl2",
                OptionOptimizeCommonBasicComponents = true, // remove yagni types from schema before code generation. tests wont work when this is set to false
                CSharpDefaultNamespace = "UblLarsen.Ubl2",
                OptionMemberTypeToGenerate = UblXsdSettings.FieldTypesEnum.AutoProperty // or Field, or Property
            };

            XmlSchemaSet schemaSet = new XmlSchemaSet(new NameTable());
            schemaSet.ValidationEventHandler += SchemaValidationEventHandler;
            // Read and add the xsd documents in xsd/maindoc folder
            schemaSet.AddMaindocSchemas(ublSettings);
            schemaSet.Compile();

            if (ublSettings.OptionOptimizeCommonBasicComponents)
            {
                var cbcSchema = schemaSet.Schemas(Constants.CommonBasicComponentsTargetNamespace).Cast<XmlSchema>().Single();
                UblSchemaTypeSimplificationTool.SimplifyCommonBasicComponentsTypes(cbcSchema);
                schemaSet.Reprocess(cbcSchema);
                schemaSet.Compile();
            }

            UblSchemaTypeSimplificationTool.ResolveTypeNameClashesByRenaming(schemaSet);
            schemaSet.Compile();

            var abstractMaindocBaseSchema = UblSchemaInheritanceTools.ModifyMaindocSchemasForInheritance(schemaSet.MaindocSchemas());
            abstractMaindocBaseSchema = schemaSet.Add(abstractMaindocBaseSchema);
            schemaSet.MaindocSchemas().Where(s => s != abstractMaindocBaseSchema).ToList().ForEach(s => schemaSet.Reprocess(s));
            schemaSet.Compile();

            UblCodeGenerator gen = new UblCodeGenerator(ublSettings);
            // namespacelist parameter will drag in all other dependant types. New extensions shold probably be appended here...
            var allCodeDecls = gen.CreateCodeTypeDeclarations(schemaSet, new[] { Constants.BaseDocumentTargetNamespace, Constants.SignatureAggregateComponents});

            UblDocumentationTool.AddDocumentation(allCodeDecls);

            UblImplicitAssignmentTool.AddImplicitAssignmentOperatorsForXmlTextAttributedDecendants(allCodeDecls);

            XsdTimeTool.IgnoreDateTimeSerializeAsString(allCodeDecls.Where(c => c.Name == "TimeType").Single());

            var mainDocCodeDecls = allCodeDecls.Where(c => c.BaseTypes.Count == 1 && c.BaseTypes[0].BaseType == Constants.abstractBaseSchemaComplexTypeName);
            MainDocsAttributeTool.RenameTopLevelXmlType(mainDocCodeDecls);
            MainDocsAttributeTool.AddXmlRootAttributes(mainDocCodeDecls);

            gen.GenerateAndSaveCodeFilesBySchema(allCodeDecls, new UblNamespaceManager(schemaSet, ublSettings));

            UblSchemaStatsTool.ShowStats(allCodeDecls);

            Console.WriteLine("DONE");
            Console.ReadLine();
        }

        private static void SchemaValidationEventHandler(object sender, ValidationEventArgs arg)
        {
            Console.WriteLine($"{arg.Severity.ToString()}: {arg.Message}");
            if (arg.Severity == XmlSeverityType.Error)
            {
                throw arg.Exception;
            }
        }
    }
}
