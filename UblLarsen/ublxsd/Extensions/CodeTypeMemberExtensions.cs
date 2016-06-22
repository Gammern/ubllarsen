using System.CodeDom;
using System.Linq;
using System.Xml;
using System.Xml.Schema;

namespace ublxsd.Extensions
{
    public static class CodeTypeMemberExtensions
    {
        public static CodeAttributeArgument GetNamespaceAttributeArgument(this CodeTypeMember @this)
        {
            return @this.CustomAttributes.OfType<CodeAttributeDeclaration>()
                 .Where(d => d.Name == "System.Xml.Serialization.XmlTypeAttribute").Single().Arguments.Cast<CodeAttributeArgument>()
                 .Where(a => a.Name == "Namespace").Single();
        }

        public static XmlQualifiedName GetQualifiedName(this CodeTypeMember @this)
        {
            if (@this.UserData[Constants.QNameLabel] == null)
            {
                string name = GetNameWithoutTrailingDigits(@this);
                string codeDeclTargetNamespace = ((CodePrimitiveExpression)GetNamespaceAttributeArgument(@this).Value).Value as string;
                @this.UserData[Constants.QNameLabel] = new XmlQualifiedName(name, codeDeclTargetNamespace);
            }
            return @this.UserData[Constants.QNameLabel] as XmlQualifiedName;
        }

        public static string GetNameWithoutTrailingDigits(this CodeTypeMember @this)
        {
            string codeDeclName = @this.Name;
            while (char.IsDigit(codeDeclName.Last())) // most likely single trailing "1"
            {
                // Doing guesswork here. Geting lucky!? Will eventually break...
                codeDeclName = codeDeclName.Substring(0, codeDeclName.Length - 1);
            }
            return codeDeclName;
        }

        public static bool HasAnyXmlTextAttribute(this CodeTypeMember @this)
        {
            return @this.CustomAttributes.Cast<CodeAttributeDeclaration>().Any(a => a.Name == "System.Xml.Serialization.XmlTextAttribute");
        }

        public static XmlSchema GetSchema(this CodeTypeMember @this)
        {
            return @this.UserData[Constants.XmlSchemaLabel] as XmlSchema;
        }

        public static XmlSchemaType GetXmlSchemaType(this CodeTypeMember @this)
        {
            return @this.UserData[Constants.XmlSchemaTypeLabel] as XmlSchemaType;
        }

        /// <summary>
        /// http://www.w3schools.com/xml/schema_simple_attributes.asp
        /// Look for attributes with use="required"
        /// </summary>
        public static bool HasAnyRequiredMembers(this CodeTypeMember @this)
        {
            XmlSchemaComplexType xmlComplexType = GetXmlSchemaType(@this) as XmlSchemaComplexType;
            var content = (xmlComplexType.ContentModel as XmlSchemaSimpleContent)?.Content;
            if (content != null)
            {
                var restriction = content as XmlSchemaSimpleContentRestriction;
                var extension = content as XmlSchemaSimpleContentExtension;
                return (restriction?.Attributes ?? extension.Attributes).Cast<XmlSchemaAttribute>().Any(a => a.Use == XmlSchemaUse.Required);
            }
            else
            {
                return xmlComplexType.Attributes.Cast<XmlSchemaAttribute>().Any(a => a.Use == XmlSchemaUse.Required);
            }
        }
    }
}
