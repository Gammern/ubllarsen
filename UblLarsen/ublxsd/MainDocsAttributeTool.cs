using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using ublxsd.Extensions;

namespace ublxsd
{
    public static class MainDocsAttributeTool
    {
        public static void AddXmlRootAttributes(IEnumerable<CodeTypeDeclaration> mainDocCodeDecls)
        {
            var isNullableArgument = new CodeAttributeArgument { Name = "IsNullable", Value = new CodePrimitiveExpression(false) };

            foreach (var cdeclMaindoc in mainDocCodeDecls)
            {
                var indexOfTrailingType = cdeclMaindoc.Name.LastIndexOf("Type", StringComparison.InvariantCulture);
                if (indexOfTrailingType < 1)
                    continue;

                string elementName = cdeclMaindoc.Name.Substring(0, indexOfTrailingType); // remove tailing "Type"
                var namespaceArgument = cdeclMaindoc.GetNamespaceAttributeArgument();
                CodeAttributeDeclaration xmlRootAtt = new CodeAttributeDeclaration
                {
                    Name = "System.Xml.Serialization.XmlRootAttribute",
                    Arguments =
                    {
                        new CodeAttributeArgument( new  CodePrimitiveExpression(elementName)),
                        namespaceArgument,
                        isNullableArgument
                    }
                };
                cdeclMaindoc.CustomAttributes.Add(xmlRootAtt);
            }
        }

        /// <summary>
        /// Add the correct name, excluding trailing "Type", to XmlTypeAttribute as first argument
        /// </summary>
        /// <param name="bigBlobCodeNamespace"></param>
        public static void RenameTopLevelXmlType(IEnumerable<CodeTypeDeclaration> mainDocCodeDecls)
        {
            foreach (var doc in mainDocCodeDecls)
            {
                var indexOfTrailingType = doc.Name.LastIndexOf("Type", StringComparison.InvariantCulture);
                if (indexOfTrailingType < 1)
                    continue; // Should not happen

                string elementName = doc.Name.Substring(0, indexOfTrailingType); // remove trailing "Type"
                var xmlTypeAtt = doc.CustomAttributes.OfType<CodeAttributeDeclaration>().Where(v => v.Name == "System.Xml.Serialization.XmlTypeAttribute").Single();
                // Add correct name
                xmlTypeAtt.Arguments.Insert(0, new CodeAttributeArgument(new CodePrimitiveExpression(elementName)));
            }
        }
    }
}
