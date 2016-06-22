using System.CodeDom;
using System.Linq;

namespace ublxsd
{
    public static class XsdTimeTool
    {
        public static void IgnoreDateTimeSerializeAsString(CodeTypeDeclaration codeDeclTimeType)
        {
            // Remove "time" member codeattributes and add XmlIgnore
            var valueMember = codeDeclTimeType.Members.Cast<CodeTypeMember>().Where(m => m.Name == "Value").Single();
            valueMember.CustomAttributes.Clear();
            valueMember.CustomAttributes.Add(new CodeAttributeDeclaration("System.Xml.Serialization.XmlIgnore"));

            string commentLine = "New serialized string type is declared in file UBL-UnqualifiedDataTypes-2.1.partial.cs";
            CodeCommentStatement memberCommentStatement = new CodeCommentStatement(commentLine, false);
            valueMember.Comments.Add(memberCommentStatement);

            // Modify class attributes. Make it possible to step into partial class with debugger
            var debuggerStepThroughAttribute = codeDeclTimeType.CustomAttributes.OfType<CodeAttributeDeclaration>()
                .Where(a => a.Name == "System.Diagnostics.DebuggerStepThroughAttribute").SingleOrDefault();
            if (debuggerStepThroughAttribute != null)
            {
                codeDeclTimeType.CustomAttributes.Remove(debuggerStepThroughAttribute);
            }
        }
    }
}
