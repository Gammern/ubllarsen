using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using UblLarsen.Ubl2;

namespace UblXml2CSharp
{
    class Program
    {
        static Dictionary<XName, Type> ublDocumentTypesDictionary;

        static void Main(string[] args)
        {
            string cSharpOutputDir = @"..\..\..\UblLarsen.IntegrationV2_1.Test\UblClass";
            string ublXmlInputDir = @"..\..\..\UBL-2.1\xml";
            List<XmlToCs> docsToConvert = new List<XmlToCs>();

            ublDocumentTypesDictionary = typeof(UblBaseDocumentType).Assembly.GetTypes()
                .Where(t => t.BaseType == typeof(UblBaseDocumentType))
                .ToDictionary(k => GetQualifiedName(k), v => v);

            DirectoryInfo xmlSamplesDir = new DirectoryInfo(ublXmlInputDir);
            foreach (var xmlFileInfo in xmlSamplesDir.GetFiles("*.xml"))
            {
                XDocument doc = XDocument.Load(xmlFileInfo.FullName);
                if (ublDocumentTypesDictionary.ContainsKey(doc.Root.Name))
                {
                    var docType = ublDocumentTypesDictionary[doc.Root.Name];
                    var xmlToCs = new XmlToCs(doc.Root, docType, xmlFileInfo.Name);
                    docsToConvert.Add(xmlToCs);
                }
                else
                {
                    Console.WriteLine($"Warning: Skip {xmlFileInfo.Name} of type {doc.Root.Name}");
                }
            }
            // debug sample
            //var d = docsToConvert.Where(n => n.IdentifierName == "UBLOrderResponse21Example").Single();
            //d.GenerateClass();
            //d.SaveToDir(cSharpOutputDir);
            //return;
            using (var writer = File.CreateText("tests.txt")) // paste content into cs file later
            {
                foreach (var xmlToCs in docsToConvert)
                {
                    xmlToCs.GenerateSourceCode();
                    Console.WriteLine($"{xmlToCs.IdentifierName} \t{xmlToCs.CSharpFilename}");
                    xmlToCs.SaveToDir(cSharpOutputDir);
                    GenerateTestMethod(writer, xmlToCs);
                }
            }

        }

        /// <summary>
        /// 0-Instance, 1-xmlfile
        /// </summary>
        private static string testMethodTemplate = @"        [TestMethod]
        public void {0}Test()
        {{
            bool areEqual = TestDocument(""{1}"", UblClass.{0}.Create);";

        private static void GenerateTestMethod(TextWriter writer, XmlToCs xmlToCs)
        {
            writer.WriteLine(testMethodTemplate, xmlToCs.IdentifierName, xmlToCs.XmlFilename);
            if(xmlToCs.HasExtensionsOrSignature)
            {
                writer.WriteLine("            Assert.Inconclusive(\"Signatures/extensions not implemented!\");");
            }
            else
            {
                writer.WriteLine("            Assert.IsTrue(areEqual, \"Written {0} differs from the one read\");", xmlToCs.DocType.Name );
            }
            writer.WriteLine("        }\n");
        }

        private static XName GetQualifiedName(Type key)
        {
            string s = key.Name;
            var att = key.CustomAttributes.Where(a => a.AttributeType == typeof(XmlTypeAttribute)).Single();
            string ns = att.NamedArguments.Where(n => n.MemberName == "Namespace").Single().TypedValue.Value as string;
            string name = att.ConstructorArguments.FirstOrDefault().Value as string ??
                att.NamedArguments.Where(n => n.MemberName == "TypeName").FirstOrDefault().TypedValue.Value as string ??
                key.Name;
            return XName.Get(name, ns);
        }

    }
}
