using System.Collections.Generic;
using System.Xml.Schema;

namespace ublxsd
{
    internal class UblXmlSchemaOrderComparer : IComparer<XmlSchema>
    {
        // Returns:
        //     A signed integer that indicates the relative values of x and y, as shown in the
        //     following table.Value Meaning 
        //      Less than zero -> x is less than y.
        //      Zero -> x equals y
        //      Greater than zero -> x is greater than y
        //  -1: x comes before y
        //  0: order of x and y don't matter
        //  1 : x comes after y
        public int Compare(XmlSchema x, XmlSchema y)
        {
            if (IncludesContain(x.Includes, y))
            {
                return 1;
            }
            else if (IncludesContain(y.Includes, x))
            {
                return -1;
            }
            else
            {
                return 0; // x.TargetNamespace.Contains("BaseDocument") || y.TargetNamespace.Contains("BaseDocument")
            }
        }

        // recurse includes until we find y
        private bool IncludesContain(XmlSchemaObjectCollection includes, XmlSchema y)
        {
            bool res = false;
            foreach (XmlSchemaExternal include in includes)
            {
                if (include.Schema == y)
                {
                    return true;
                }
                if (include.Schema != null)
                {
                    foreach (XmlSchemaExternal item in include.Schema.Includes)
                    {
                        if (item.Schema != null)
                            res = IncludesContain(item.Schema.Includes, y);
                        if (res) return res;
                    }
                }
            }

            return res;
        }
    }
}