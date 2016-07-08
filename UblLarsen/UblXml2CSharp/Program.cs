using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
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

            //var d = docsToConvert.Where(n => n.IdentifierName == "UBLOrderResponse21Example").Single();
            //d.GenerateClass();
            //d.SaveToDir(cSharpOutputDir);
            //return;

            foreach (var xmlToCs in docsToConvert)
            {
                xmlToCs.GenerateClass();
                Console.WriteLine($"{xmlToCs.IdentifierName} \t{xmlToCs.CSharpFilename}");
                xmlToCs.SaveToDir(cSharpOutputDir);
            }

            // test one for now...

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
