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

        private static Type[] nonStringUdtTypes = new[] { typeof(decimal), typeof(bool) };
        private static List<Type> nonStringQuotableUblUdtTypes = typeof(UblBaseDocumentType).Assembly.GetTypes()
            .Where(t => t.Namespace == "UblLarsen.Ubl2.Udt" && nonStringUdtTypes.Contains(t.GetProperty("Value").PropertyType))
            .ToList();

        private static List<Type> oneLineAssignableUblUdtTypes = typeof(UblBaseDocumentType).Assembly.GetTypes()
            .Where(t => t.Namespace == "UblLarsen.Ubl2.Udt" && t.GetMethods(BindingFlags.Public | BindingFlags.Static).Where(m => m.Name == "op_Implicit").Any())
            .ToList();

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
                    string name = elem.First().Name.LocalName;
                    if (name == "UBLExtension")
                    {
                        // Don't know how to handle this one yet. ExtensionContent = "new XElement.Parse(something)"?
                        continue;
                    }
                    PropertyInfo propInfo = GetPropertyThatMightBeRenamed(propType, name);
                    Write(tabLevel + 1, $"{name} = ");
                    string localDelimiter = (elem == xElements.Last()) ? "" : ",";
                    if (propInfo.PropertyType.IsArray)
                    {
                        GenerateArray(elem.ToArray(), propInfo.PropertyType, tabLevel + 1, localDelimiter);
                    }
                    else
                    {
                        GeneratePropertyValue(elem.First(), propInfo.PropertyType, tabLevel, localDelimiter);
                    }
                }
            }
            else
            {
                foreach (var attribute in xElement.Attributes())
                {
                    WriteLine(tabLevel + 1, attribute.ToString().Replace("=", " = ") + ",");
                }
                string value = GetValue(xElement, propType);
                WriteLine(tabLevel + 1, $"Value = {value}");
            }
            WriteLine(tabLevel, $"}}{delimiter}");
        }

        private PropertyInfo GetPropertyThatMightBeRenamed(Type propType, string name)
        {
            var propInfo = propType.GetProperty(name);
            if (propInfo == null)
                propInfo = propType.GetProperty(name + "1");
            return propInfo;
        }

        private string GetValue(XElement xElement, Type propType)
        {
            string value = xElement.Value;
            if (nonStringQuotableUblUdtTypes.Contains(propType))
                return value;
            return "\"" + value + "\"";
        }

        private void GenerateArray(XElement[] xElements, Type propType, int tabLevel, string delimiter)
        {
            WriteLine(0, $"new {propType.Name}");
            WriteLine(tabLevel, "{");
            foreach (var item in xElements)
            {
                Write(tabLevel + 1, "");
                string localDelimiter = (item == xElements.Last()) ? "" : ",";
                GenerateNewClass(item, propType.GetElementType(), tabLevel + 1, localDelimiter);
            }
            WriteLine(tabLevel, $"}}{delimiter}");
        }

        private void GeneratePropertyValue(XElement xElement, Type propertyType, int tabLevel, string delimiter)
        {
            if (CanBeGeneratedAsOneLinerAssignment(xElement, propertyType))
            {
                string value = GetValue(xElement, propertyType);
                WriteLine(0, $"{value}{delimiter}");
            }
            else
            {
                GenerateNewClass(xElement, propertyType, tabLevel + 1, delimiter);
            }
        }

        private bool CanBeGeneratedAsOneLinerAssignment(XElement xElement, Type propertyType)
        {
            if (xElement.HasElements || xElement.HasAttributes)
                return false;
            // Only basetypes from UblLarsen.Ubl2.Udt having static implicit assignment functions can be assigned as a one-liner when Attributes and Elements are empty
            var ublType = propertyType.Assembly == typeof(UblBaseDocumentType).Assembly;
            if (ublType)
            {
                if (oneLineAssignableUblUdtTypes.Contains(propertyType))
                    return true;
                return false;
            }
            return true;
        }

        private void GenerateNamespaceDeclaration(int tabLevel)
        {
            var namespaceAttributes = rootElement.Attributes().Where(a => a.Name.NamespaceName.Any()).ToList();

            WriteLine(tabLevel, "new XmlSerializerNamespaces(new[]");
            WriteLine(tabLevel, "{");
            foreach (var nsatt in namespaceAttributes)
            {
                WriteLine(tabLevel + 1, $"new XmlQualifiedName(\"{nsatt.Name.LocalName}\",\"{nsatt.Value}\"),");
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