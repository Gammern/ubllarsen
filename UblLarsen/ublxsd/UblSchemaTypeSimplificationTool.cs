using System.Linq;
using System.Xml;
using System.Xml.Schema;

namespace ublxsd
{
    internal class UblSchemaTypeSimplificationTool
    {
        /// <summary>
        /// Complextypes in CommonBasicComponents are just pointers to other types. Removes that indirection.
        ///
        /// E.g:
        ///    <xsd:element name="AcceptedIndicator" type="AcceptedIndicatorType"/>
        ///    <xsd:complexType name="AcceptedIndicatorType">
        ///        <xsd:simpleContent>
        ///            <xsd:extension base="udt:IndicatorType"/>
        ///        </xsd:simpleContent>
        ///    </xsd:complexType>
        ///
        /// Becomes:
        ///    <xsd:element name="AcceptedIndicator" type="udt:IndicatorType"/>
        ///    
        /// ubl 2.1: Number of generated C# classes are reduced from 1202 to 329!
        /// </summary>
        public static void SimplifyCommonBasicComponentsTypes(XmlSchema schema)
        {
            // 
            var typeLookup = schema.Items.OfType<XmlSchemaComplexType>()
                .ToDictionary(k => k.QualifiedName, v => (v.ContentModel.Content as XmlSchemaSimpleContentExtension).BaseTypeName);
            var repaceElements = schema.Items.OfType<XmlSchemaElement>()
                .Select(e => new XmlSchemaElement { Name = e.Name, SchemaTypeName = typeLookup[e.SchemaTypeName] }).ToList();
            schema.Items.Clear();
            repaceElements.ForEach(r => schema.Items.Add(r));
        }

        // .NET C# cannot have types with same name in the Codenamespace. If that happens a digit is appended to the typename.
        // Eg. CoreComponents and UnqualifiedDataTypes both have "IdentifierType", one gets named "IdentifierType1" :-(
        // Solution: Prepend types in CoreComponents with "cctscct" and modify references in UnqualifiedComponents
        public static void ResolveTypeNameClashesByRenaming(XmlSchemaSet schemaSet)
        {
            string ccts_cctPrefix = "cctscct";
            XmlSchema coreCompSchema = schemaSet.Schemas(Constants.CoreComponentTypeSchemaModuleTargetNamespace).OfType<XmlSchema>().Single();
            XmlSchema unqualSchema = schemaSet.Schemas(Constants.UnqualifiedDataTypesTargetNamespace).OfType<XmlSchema>().Single();

            foreach (var complexType in coreCompSchema.Items.OfType<XmlSchemaComplexType>())
            {
                complexType.Name = ccts_cctPrefix + complexType.Name;
                complexType.IsAbstract = true; // Make it abstract as well. Ain't gonna use the base, only the one derived from this type.
            }

            foreach (var complexType in unqualSchema.Items.OfType<XmlSchemaComplexType>()
                            .Where(t => t.BaseXmlSchemaType.QualifiedName.Namespace.Equals(Constants.CoreComponentTypeSchemaModuleTargetNamespace)))
            {
                var name = new XmlQualifiedName(ccts_cctPrefix + complexType.BaseXmlSchemaType.QualifiedName.Name, complexType.BaseXmlSchemaType.QualifiedName.Namespace);
                var content = complexType.ContentModel as XmlSchemaSimpleContent;
                if (content.Content is XmlSchemaSimpleContentRestriction)
                {
                    (content.Content as XmlSchemaSimpleContentRestriction).BaseTypeName = name;
                }
                else if (content.Content is XmlSchemaSimpleContentExtension)
                {
                    (content.Content as XmlSchemaSimpleContentExtension).BaseTypeName = name;
                }
            }
            schemaSet.Reprocess(coreCompSchema);
            schemaSet.Reprocess(unqualSchema);
        }
    }
}



