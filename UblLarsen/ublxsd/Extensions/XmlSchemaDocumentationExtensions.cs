using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace ublxsd.Extensions
{
    /// <summary>
    /// </summary>
    public static class XmlSchemaDocumentationExtensions
    {
        public static string[] GetDocumentation(this XmlSchemaDocumentation @this)
        {
            char[] trimChars = new[] { ' ', '\t', '\n', '\r' };
            List<string> res = null;
            if (@this !=null && @this.Markup.Any())
            {
                var node = @this.Markup.First();
                if (node.NodeType == XmlNodeType.Text)
                {
                    // return pure text
                    res = @this.Markup.OfType<XmlText>()
                        .Select(s => s.Value.Trim(trimChars))
                        .ToList();
                }
                else if (node.NodeType == XmlNodeType.Element)
                {
                    // xml to text
                    string xml = string.Empty;
                    if (node.Name == "ccts:Component")
                    {
                        xml = node.OuterXml;
                    }
                    else if (node.Name.StartsWith("ccts:"))
                    {
                        xml = $"<ccts:Component xmlns:ccts=\"urn:un:unece:uncefact:documentation:2\">{node.ParentNode.InnerXml}</ccts:Component>";
                    }
                    var comp = XElement.Parse(xml);
                    res = comp.Elements().Select(e => $"{e.Name.LocalName}: {e.Value.Trim(trimChars)}").ToList(); // embedded '\n' might slip through
                }
                if (res != null)
                {
                    for (int i = 1; i < res.Count; i++)
                    {
                        res[i] = $"<para>{res[i]}</para>";
                    }
                    res.Insert(0, "<summary>");
                    res.Add("</summary>");
                    return res.ToArray();
                }
            }
            return new string[0];
        }
    }
}
