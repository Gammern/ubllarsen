using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Schema;
using ublxsd.Extensions;

namespace ublxsd
{
    class UblSchemaStatsTool
    {
        Dictionary<string, string> prefixLookup;

        public static void ShowHiearachy(XmlSchemaSet schemaSet)
        {
            UblSchemaStatsTool tool = new UblSchemaStatsTool();
            using (var file = File.CreateText("../../hierarchy.txt"))
            {
                tool.ShowHierarchy(schemaSet, file);// Console.Out);
            }
        }

        private void ShowHierarchy(XmlSchemaSet schemaSet, TextWriter writer)
        {
            var schema = schemaSet.Schemas(Constants.InvoiceTargetNamespace).Cast<XmlSchema>().Single();
            prefixLookup = schema.Namespaces.ToArray().Where(v => !string.IsNullOrEmpty(v.Name)).ToDictionary(k => k.Namespace, v => v.Name);
            PrintSchemaDetail(schema, writer);
            var prefixes = schemaSet.GetNamespacePrefixes();
            Console.WriteLine();
            foreach (var prefix in prefixes)
            {
                writer.WriteLine($"{prefix.Name,9}: -> \"{prefix.Namespace}\"");
            }
        }

        private void PrintSchemaDetail(XmlSchema schema, TextWriter writer, int level = 0)
        {
            Func<string, string> lastpart = s => (s.Substring(s.Substring(0, s.Length - 2).LastIndexOf(':') + 1));
            string tab = new string(' ', level * 2);
            var newPrefixes = schema.Namespaces.ToArray().Where(v => !string.IsNullOrEmpty(v.Name)).ToDictionary(k => k.Namespace, v => v.Name);
            foreach (var item in newPrefixes)
            {
                prefixLookup[item.Key] = item.Value;
            }
            string prefix = prefixLookup.ContainsKey(schema.TargetNamespace) ? prefixLookup[schema.TargetNamespace] + ":" : "";
            string org = (schema.TargetNamespace.Contains("oasis") ? "oasis" : schema.TargetNamespace.Contains("unece") ? "unece" : "");
            string name = Path.GetFileName(schema.GetFileNameWithSubDirectory()) + " \t" + lastpart(schema.TargetNamespace);

            writer.WriteLine($"{tab}{name} ({org} {prefix})");

            var imports = schema.Includes.Cast<XmlSchemaExternal>().ToList();
            foreach (var import in imports)
            {
                string s = import.GetType().Name.Substring("XmlSchema".Length);
                writer.Write($"{s}");
                PrintSchemaDetail(import.Schema, writer, level + 1);
            }
        }

        public static void ShowStats(IEnumerable<CodeTypeDeclaration> types)
        {
            int totalTypes = types.Count();
            int countClass = types.Where(t => t.IsClass).Count();
            int countEnum = types.Where(t => t.IsEnum).Count();
            int countStruct = types.Where(t => t.IsStruct).Count();

            Console.WriteLine("Stats:");
            Console.WriteLine($"Classes: {countClass}");
            Console.WriteLine($"  Enums: {countEnum}");
            Console.WriteLine($"Structs: {countStruct}");
            Console.WriteLine($"  Total: {totalTypes}");

            // You Ain't Gonna Need It
            var yagnis = types.Where(c => c.IsClass && c.BaseTypes.Count == 1 &&
                    c.Members.Cast<CodeTypeMember>().Where(d => d.GetType() == typeof(CodeMemberField) || d.GetType() == typeof(CodeMemberProperty)).Count() == 0)
                .Count();
            Console.WriteLine($"Yagni classes:\t {yagnis}");
        }

    }
}
