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
        private static string[] tabs = Enumerable.Range(0, maxLevel).Select(n => new string(' ', n * 4)).ToArray();
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
            GenerateNewClass(rootElement, docType, 2, "");
            return true;
        }

        private void GenerateNewClass(XElement xElement, Type propType, int tabLevel, string delimiter)
        {
            WriteLine(0, $"new {propType.Name}");
            WriteLine(tabLevel, "{");
            if (xElement.HasElements)
            {

                var xElements = xElement.Elements().GroupBy(g => g.Name.LocalName).ToList();
                foreach (var elem in xElements)
                {
                    foreach (var attribute in elem.Attributes())
                    {
                        WriteLine(tabLevel + 1, attribute.ToString().Replace("=", " = ")+" (Attributes are fucked)"); // repeated!!!! why?
                    }

                    string name = elem.First().Name.LocalName;
                    PropertyInfo propInfo = propType.GetProperty(name);
                    Write(tabLevel + 1, $"{name} = ");
                    string localDelimiter = (elem == xElements.Last()) ? "" : ",";
                    if (propInfo.PropertyType.IsArray)
                    {
                        GenerateArray(elem.ToArray(), propInfo.PropertyType, tabLevel + 1, localDelimiter);
                    }
                    else if(false) // something automagically make class instead of assignment
                    {
                        // HulaHulaAchbarMakeClass()
                    }
                    else
                    {
                        // should not generate simple assignment if HasAttributes HulaHulaAchbar
                        GeneratePropertyValue(elem.First(), propInfo.PropertyType, tabLevel, localDelimiter);
                    }
                }
            }
            else
            {
                string value = GetValue(xElement, propType);
                WriteLine(tabLevel + 1, $"Value = {value}");
            }
            WriteLine(tabLevel,$"}}{delimiter}");
        }

        private string GetValue(XElement xElement, Type propType)
        {
            string value = xElement.Value;
            if (numericBaseTypes.Contains(propType.BaseType))
                return value;
            return "\"" + value + "\"";
        }

        private void GenerateArray(XElement[] xElements, Type propType, int tabLevel, string delimiter)
        {
            WriteLine(0, $"new {propType.Name}");
            WriteLine(tabLevel, "{");
            foreach (var item in xElements)
            {
                Write(tabLevel+1, "");
                string localDelimiter = (item == xElements.Last()) ? "" : ",";
                GenerateNewClass(item, propType.GetElementType(), tabLevel + 1, localDelimiter);
            }
            WriteLine(tabLevel, $"}}{delimiter}");

        }

        private void GeneratePropertyValue(XElement xElement, Type propertyType, int tabLevel, string delimiter)
        {
            if(!xElement.HasElements)
            {
                string value = GetValue(xElement, propertyType);
                WriteLine(0, $"{value}{delimiter}");
            }
            else
            {
                GenerateNewClass(xElement, propertyType, tabLevel + 1, delimiter);
            }
        }

        private void GenerateNamespaceDeclaration(int tabLevel)
        {
            var namespaceAttributes = rootElement.Attributes().Where(a => a.Name.NamespaceName.Any()).ToList();

            WriteLine(tabLevel, "new XmlSerializerNamespaces(new[]");
            WriteLine(tabLevel, "{");
            foreach (var nsatt in namespaceAttributes)
            {
                WriteLine(tabLevel+1, $"new XmlQualifiedName(\"{nsatt.Name.LocalName}\",\"{nsatt.Value}\"),");
            }
            WriteLine(tabLevel, "}");
        }

        private void WriteLine(int tablevel, string s)
        {
            Write(tablevel, s + Environment.NewLine);
        }

        private void Write(int tabLevel, string s)
        {
            Console.Write($"{tabs[tabLevel]}{s}");
        }



    }
}