using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;
using ublxsd.Extensions;

namespace ublxsd
{
    public static class UblDocumentationTool
    {
        private static Dictionary<string, XmlSchemaDocumentation> emptyDocumentationDictionary = new Dictionary<string, XmlSchemaDocumentation>();

        /// <summary>
        /// Add comment to class and its members (properties or fields).
        /// </summary>
        public static void AddDocumentation(IEnumerable<CodeTypeDeclaration> codeDecls)
        {
            Func<CodeTypeDeclaration, IQueryable<CodeTypeMember>> GetPublicFieldPropertyMembers = cdecl => cdecl.Members.OfType<CodeTypeMember>()
                .Where(c => (c.GetType() == typeof(CodeMemberField) || c.GetType() == typeof(CodeMemberProperty)) &&
                (c.Attributes & MemberAttributes.Public) == MemberAttributes.Public).AsQueryable();

            Action<CodeTypeMember, XmlSchemaDocumentation> AddCommentsToCodeType = (ct, xd) =>
            {
                var textLines = xd.GetDocumentation();
                foreach (var line in textLines)
                {
                    ct.Comments.Add(new CodeCommentStatement(line, true));
                }
            };

            foreach (CodeTypeDeclaration codeDecl in codeDecls)
            {
                XmlSchemaComplexType xsdComplexType = (XmlSchemaComplexType)codeDecl.GetXmlSchemaType();

                // Add comment to class
                XmlSchemaDocumentation xsdDocNode = xsdComplexType.Annotation?.Items.OfType<XmlSchemaDocumentation>().FirstOrDefault();
                if (xsdDocNode != null)
                {
                    AddCommentsToCodeType(codeDecl, xsdDocNode);
                }

                // Get all members except XmlTextAttribute members. They do not have any doc and must be excluded
                var classMembers = GetPublicFieldPropertyMembers(codeDecl)
                    .Where(m => !m.HasAnyXmlTextAttribute())
                    .ToList();
                if (classMembers.Count == 0)
                {
                    continue;
                }

                // Build a dictionary of docnodes from xsd attribute and element definitions
                Dictionary<string, XmlSchemaDocumentation> memberDocumentationDictionary = emptyDocumentationDictionary;
                switch (xsdComplexType.ContentType)
                {
                    case XmlSchemaContentType.TextOnly: // simpleContent, DateType
                        XmlSchemaSimpleContentExtension sext = (xsdComplexType.ContentModel as XmlSchemaSimpleContent).Content as XmlSchemaSimpleContentExtension;
                        memberDocumentationDictionary = sext.Attributes.OfType<XmlSchemaAttribute>().ToDictionary(k => k.Name, v => v.Annotation?.Items.OfType<XmlSchemaDocumentation>().First());
                        break;
                    case XmlSchemaContentType.Empty:
                        //continue;
                        break;
                    case XmlSchemaContentType.ElementOnly:
                    case XmlSchemaContentType.Mixed:
                        if (xsdComplexType.ContentTypeParticle is XmlSchemaSequence)
                        {
                            var schemaSequence = xsdComplexType.ContentTypeParticle as XmlSchemaSequence;
                            memberDocumentationDictionary = schemaSequence.Items.OfType<XmlSchemaElement>().ToDictionary(k => k.QualifiedName.Name, v => v.Annotation?.Items.OfType<XmlSchemaDocumentation>().FirstOrDefault());
                        }
                        else if (xsdComplexType.ContentTypeParticle is XmlSchemaChoice)
                        {
                            var schemaChoice = xsdComplexType.ContentTypeParticle as XmlSchemaChoice;
                            memberDocumentationDictionary = schemaChoice.Items.OfType<XmlSchemaElement>().ToDictionary(k => k.QualifiedName.Name, v => v.Annotation?.Items.OfType<XmlSchemaDocumentation>().FirstOrDefault());
                        }
                        break;
                    default:
                        // Do never hit
                        break;
                }

                // Finally add comments to each member
                foreach (var member in classMembers)
                {
                    var memberName = member.GetNameWithoutTrailingDigits();
                    if (memberDocumentationDictionary.ContainsKey(memberName))
                    {
                        AddCommentsToCodeType(member, memberDocumentationDictionary[memberName]);
                    }
                }
            }
        }
    }
}
