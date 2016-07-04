using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace UblXml2CSharp
{
    internal class XmlToCs
    {
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
            int tabLevel = 2;
            string tabs = new string(' ', tabLevel * 4);
            Console.WriteLine($"{tabs}new {docType.Name}");
            Console.WriteLine($"{tabs}{{");
            var NamespaceAttributes = rootElement.Attributes().Where(a => a.Name.NamespaceName.Any()).ToList();
            GenerateNamespaceDeclaration(NamespaceAttributes, tabLevel + 1);
            var elements = rootElement.Elements().GroupBy(g => g.Name).ToList();
            foreach (var element in elements)
            {
                var propInfo = docType.GetProperty(element.First().Name.LocalName);
                //propInfo = GetPropInfoForMember(element.First(), propInfo);
                GenerateProperty(element.ToArray(), propInfo, tabLevel + 1);
            }
            Console.WriteLine($"{tabs}}}");
            return true;
        }

        private void GenerateProperty(XElement[] propertyGroping, PropertyInfo propertyInfo, int tabLevel)
        {
            string tabs = new string(' ', tabLevel * 4);
            if (propertyInfo.PropertyType.IsArray)
            {
                Console.WriteLine($"{tabs}{propertyInfo.Name} = new {propertyInfo.PropertyType.Name}");
                Console.WriteLine($"{tabs}{{");
                foreach (var property in propertyGroping)
                {
                    GenerateProperty(property, propertyInfo, tabLevel + 1);
                }
                Console.WriteLine($"{tabs}}}");
            }
            else
            {
                GenerateProperty(propertyGroping.First(), propertyInfo, tabLevel);
            }
        }

        private void GenerateProperty(XElement property, PropertyInfo propertyInfo, int tabLevel)
        {
            string tabs = new string(' ', tabLevel * 4);
            if (!property.HasElements)
            {
                if (property.HasAttributes)
                {
                    string delimiter = ",";
                    if (propertyInfo.PropertyType.IsArray)
                    {
                        Console.WriteLine($"{tabs}new {propertyInfo.PropertyType.GetElementType().Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{tabs}{propertyInfo.Name} = new {propertyInfo.PropertyType.Name}");
                    }
                    Console.WriteLine($"{tabs}{{");
                    foreach (var attribute in property.Attributes())
                    {
                        Console.WriteLine($"{tabs}    {attribute.ToString().Replace("=", " = ")},");
                    }
                    Console.WriteLine($"{tabs}    Value = \"{property.Value}\"");
                    Console.WriteLine($"{tabs}}}{delimiter}");
                }
                else
                {
                    Console.WriteLine($"{tabs}{property.Name.LocalName} = \"{property.Value}\",");
                }
            }
            else
            {
                Console.WriteLine($"{tabs}{propertyInfo.Name} = new {propertyInfo.PropertyType.Name}");
                Console.WriteLine($"{tabs}{{");
                var elements = property.Elements().GroupBy(g => g.Name).ToList();
                foreach (var element in elements)
                {
                    PropertyInfo propInfo = GetPropInfoForMember(element.First(), propertyInfo);
                    GenerateProperty(element.ToArray(), propInfo, tabLevel + 1);
                }
                Console.WriteLine($"{tabs}}}");
            }
        }

        private PropertyInfo GetPropInfoForMember(XElement xElement, PropertyInfo propertyInfo)
        {
            Type t;
            if (propertyInfo.PropertyType.IsArray)
            {
                t = propertyInfo.PropertyType.GetElementType(); // itemstype
            }
            else
            {
                t = propertyInfo.PropertyType;
            }
            var propInfo = t.GetProperty(xElement.Name.LocalName);
            return propInfo;
        }

        private void GenerateNamespaceDeclaration(List<XAttribute> namespaceAttributes, int tabLevel)
        {
            string tabs = new string(' ', tabLevel * 4);

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