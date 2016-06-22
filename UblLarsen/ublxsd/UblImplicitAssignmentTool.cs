using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;
using ublxsd.Extensions;

namespace ublxsd
{
    /// <summary>
    /// Generate implicit assignment for types that have
    /// - XmlTextAttribute on a member
    /// - Inherit from a type with the above condition
    /// 
    /// Do not generate imlicit assignment for types that have
    /// - xsd use="required" on any member
    /// - inherit from a type with the above condition
    /// - is abstract
    /// </summary>
    public class UblImplicitAssignmentTool
    {
        private class MemberTypeTuple
        {
            public Type BaseMemberType;
            public CodeTypeDeclaration CodeDecl;
        }

        // TODO: This is "secutity by obscurity"! Refactor for readability
        public static void AddImplicitAssignmentOperatorsForXmlTextAttributedDecendants(IEnumerable<CodeTypeDeclaration> codeDecls)
        {
            var classes = codeDecls.Where(c => c.IsClass).ToList();

            // public classes with "any" XmlTextAttribute on a field where all other fields are non-required
            var codeDeclsBase = classes.Where(c =>
                    !c.HasAnyRequiredMembers() &&
                    c.Members.OfType<CodeTypeMember>().Any(m =>
                        (m.GetType() == typeof(CodeMemberField) || m.GetType() == typeof(CodeMemberProperty)) &&
                        ((m.Attributes & MemberAttributes.Public) == MemberAttributes.Public) &&
                        m.HasAnyXmlTextAttribute())
                    ).ToList();

            var accumulatedTupleList = (from cdecl in codeDeclsBase
                                        let xmlMember = cdecl.GetXmlSchemaType() as XmlSchemaComplexType
                                        where xmlMember.BaseXmlSchemaType.Datatype != null
                                        select new MemberTypeTuple { CodeDecl = cdecl, BaseMemberType = (Type)xmlMember.BaseXmlSchemaType.Datatype.ValueType }).ToList();

            IEnumerable<MemberTypeTuple> decendantsAtNextLevel = accumulatedTupleList;

            do
            {
                var baseTypeNameFilter = decendantsAtNextLevel.Select(d => d.CodeDecl.Name).ToArray();
                decendantsAtNextLevel = classes
                    .Where(c =>
                        c.BaseTypes.Count > 0 &&
                        baseTypeNameFilter.Contains(c.BaseTypes[0].BaseType) &&
                        !c.HasAnyRequiredMembers()
                        )
                    .Select(c => new MemberTypeTuple
                    {
                        BaseMemberType = decendantsAtNextLevel.Where(d => d.CodeDecl.Name == c.BaseTypes[0].BaseType).Select(d => d.BaseMemberType).Single(),
                        CodeDecl = c
                    }).ToList();
                accumulatedTupleList.AddRange(decendantsAtNextLevel);
            } while (decendantsAtNextLevel.Count() > 0);

            // Dont generate implicit assignment for abstract types at lowest level. Remove from list.
            foreach (var lowLevelAbstractTuple in accumulatedTupleList.Where(t => t.CodeDecl.GetQualifiedName().Namespace == Constants.CoreComponentTypeSchemaModuleTargetNamespace).ToList())
            {
                accumulatedTupleList.Remove(lowLevelAbstractTuple);
            }

            foreach (var tuple in accumulatedTupleList)
            {
                AddStaticImplicitAssignmentOperators(tuple.CodeDecl, tuple.BaseMemberType, "Value");
            }
        }


        /// <summary>
        /// 0 = string.IsNullOrEmpty(value) || value == default(type)
        /// 1 = ubltype
        /// 2 = clrtype
        /// 3 = property name ("Value")
        /// </summary>
        const string implicitAssignCodeStringFormat =
@"#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator {1}({2} value)
        {{
             return {0} ? null : new {1} {{ {3} = value }};
        }}

        public static implicit operator {2}({1} @this)
        {{
             return @this.{3};
        }}
#endif";

        private static void AddStaticImplicitAssignmentOperators(CodeTypeDeclaration codeDecl, Type parameterType, string propName)
        {
            string nullTest = parameterType == typeof(string) ? "string.IsNullOrEmpty(value)" : $"value == default({parameterType.FullName})";
            string snipCodeString = string.Format(implicitAssignCodeStringFormat, nullTest, codeDecl.Name, parameterType.FullName, propName);
            CodeSnippetTypeMember codeSnippet = new CodeSnippetTypeMember(snipCodeString);
            codeDecl.Members.Add(codeSnippet);
        }
    }
}
