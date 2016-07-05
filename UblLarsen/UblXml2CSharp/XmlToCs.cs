using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using UblLarsen.Ubl2;

namespace UblXml2CSharp
{
    internal class XmlToCs
    {
        private const int maxLevel = 20;
        private static string[] tabs = Enumerable.Range(1, maxLevel).Select(n => new string(' ', n * 4)).ToArray();
        private static List<Type> numericBaseTypes = typeof(UblBaseDocumentType).Assembly.GetTypes()
            .Where(t => t.Namespace == "UblLarsen.Ubl2.Cctscct")
            .Where(t => t.GetProperty("Value").PropertyType == typeof(decimal)).ToList();

        private Type docType;
        private XElement rootElement;
        private string xmlFilename;
        StringBuilder sb;

        public XmlToCs(XElement root, Type docType, string xmlFilename)
        {
            this.rootElement = root;
            this.docType = docType;
            this.xmlFilename = xmlFilename;
            this.sb = new StringBuilder();
        }

        public string CSharpFilename
        {
            get { return Path.ChangeExtension(xmlFilename, ".cs"); }
        }

        public string IdentifierName
        {
            get { return CodeIdentifier.MakePascal(Path.GetFileNameWithoutExtension(xmlFilename)); }
        }

        public bool GenerateClass()
        {

            GenerateNewClass(rootElement, docType, 2);
            return true;
        }

        private void GenerateNewClass(XElement xElement, Type propType, int tabLevel)
        {
            Console.WriteLine($"new {propType.Name}");
            Console.WriteLine($"{tabs[tabLevel]}{{");
            if (xElement.HasElements)
            {
                var xElements = xElement.Elements().GroupBy(g => g.Name.LocalName).ToList();
                foreach (var elem in xElements)
                {
                    string name = elem.First().Name.LocalName;
                    PropertyInfo propInfo = propType.GetProperty(name);
                    Console.Write($"{tabs[tabLevel + 1]}{name} = ");
                    if (propInfo.PropertyType.IsArray)
                    {
                        GenerateArray(elem.ToArray(), propInfo.PropertyType, tabLevel + 1);
                    }
                    else
                    {
                        GeneratePropertyValue(elem.First(), propInfo.PropertyType, tabLevel);
                    }
                }
            }
            else
            {
                string value = GetValue(xElement, propType);
                Console.WriteLine($"{tabs[tabLevel + 1]}Value = {value}");
            }
            Console.WriteLine($"{tabs[tabLevel]}}},");
        }

        private string GetValue(XElement xElement, Type propType)
        {
            string value = xElement.Value;
            if (numericBaseTypes.Contains(propType.BaseType))
                return value;
            return "\"" + value + "\"";
        }

        private void GenerateArray(XElement[] xElements, Type propType, int tabLevel)
        {
            Console.WriteLine($"new {propType.Name}");
            Console.WriteLine($"{tabs[tabLevel]}{{");
            foreach (var item in xElements)
            {
                Console.Write($"{tabs[tabLevel+1]}");
                GenerateNewClass(item, propType.GetElementType(), tabLevel + 1);
            }
            Console.WriteLine($"{tabs[tabLevel]}}},");

        }

        private void GeneratePropertyValue(XElement xElement, Type propertyType, int tabLevel)
        {
            if(!xElement.HasElements)
            {
                string value = GetValue(xElement, propertyType);
                Console.WriteLine($"{value},");
            }
            else
            {
                GenerateNewClass(xElement, propertyType, tabLevel + 1);
            }
        }

        private void GenerateNamespaceDeclaration(int tabLevel)
        {
            string tabs = new string(' ', tabLevel * 4);
            var namespaceAttributes = rootElement.Attributes().Where(a => a.Name.NamespaceName.Any()).ToList();

            Console.WriteLine($"{tabs}new XmlSerializerNamespaces(new[]");
            Console.WriteLine($"{tabs}{{");
            foreach (var nsatt in namespaceAttributes)
            {
                Console.WriteLine($"{tabs}    new XmlQualifiedName(\"{nsatt.Name.LocalName}\",\"{nsatt.Value}\"),");
            }
            Console.WriteLine($"{tabs}}}");
        }
    }
}