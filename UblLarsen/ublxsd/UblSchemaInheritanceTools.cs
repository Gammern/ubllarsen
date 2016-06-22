using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Schema;

namespace ublxsd
{
    public class UblSchemaInheritanceTools
    {
        /// <summary>
        /// Find common elements amongst all maindocSchemas and put them in a new abstractBaseSchema.
        /// Modify maindocsSchemas to inherit from abstractBaseSchema and remove elements that now go
        /// into abstractBaseSchema.
        /// </summary>
        /// <param name="maindocSchemas"></param>
        /// <returns>Base schema</returns>
        public static XmlSchema ModifyMaindocSchemasForInheritance(ICollection<XmlSchema> maindocSchemas)
        {
            int sharedElementCount = GetSharedElementCount(maindocSchemas);
            if (0 == sharedElementCount)
            {
                throw new ApplicationException("Maindoc schemas do not seem to have any shared elements. Inheritance from a baseclass pointless."
                    + "Have you mixed-up xsdfiles in common and maindoc folders?");
            }

            // Construct new abstract base from an arbitrary maindoc schema (use it as template). Just pick the first one and pray
            XmlSchema templateSchema = maindocSchemas.First();
            XmlSchema abstractBaseSchema = CreateAbstractBaseSchemaFromMaindocSchema(templateSchema, sharedElementCount);

            XmlSchemaImport abstactBaseSchemaImport = new XmlSchemaImport { Namespace = abstractBaseSchema.TargetNamespace, Schema = abstractBaseSchema };
            XmlQualifiedName abstactBaseSchemaQNameToInheritFrom = new XmlQualifiedName(Constants.abstractBaseSchemaComplexTypeName, abstractBaseSchema.TargetNamespace);

            foreach (XmlSchema maindocSchema in maindocSchemas)
            {
                maindocSchema.Namespaces.Add("abs", abstractBaseSchema.TargetNamespace);
                maindocSchema.Includes.Add(abstactBaseSchemaImport);

                XmlSchemaComplexType maindocSchemaComplexType = maindocSchema.Items.OfType<XmlSchemaComplexType>().Single(); // Single is safe. Should only be one.
                XmlSchemaSequence nonSharedElementSequence = maindocSchemaComplexType.Particle as XmlSchemaSequence;
                //maindocSchemaComplexType.Particle = null; // do I have to do this? Has no effect

                // remove shared elements (they are now in the base we inherit from)
                for (int i = 0; i < sharedElementCount; i++) nonSharedElementSequence.Items.RemoveAt(0);

                maindocSchemaComplexType.ContentModel = new XmlSchemaComplexContent
                {
                    Content = new XmlSchemaComplexContentExtension
                    {
                        BaseTypeName = abstactBaseSchemaQNameToInheritFrom,
                        Particle = nonSharedElementSequence
                    }
                };
            }

            return abstractBaseSchema;
        }

        /// <summary>
        ///  TODO: Create new XmlSchema instead of DeepCopy
        /// </summary>
        /// <param name="templateSchema">Arbitrary maindoc schema used as a template for our new base class schema</param>
        /// <param name="sharedElementCount">Number of elements that shoud be copied over to the new base class schema complex type</param>
        /// <returns></returns>
        private static XmlSchema CreateAbstractBaseSchemaFromMaindocSchema(XmlSchema templateSchema, int sharedElementCount)
        {
            XmlSchema abstractBaseSchema = DeepCopy(templateSchema);
            var abstractBaseElement = abstractBaseSchema.Items.OfType<XmlSchemaElement>().Single();          // Single. There can only be one
            var abstractBaseComplexType = abstractBaseSchema.Items.OfType<XmlSchemaComplexType>().Single();  // Christopher Lambert again

            // overwrite template props
            abstractBaseSchema.TargetNamespace = abstractBaseSchema.TargetNamespace.Replace(abstractBaseElement.Name, Constants.abstractBaseSchemaName);
            abstractBaseSchema.Namespaces.Add("", abstractBaseSchema.TargetNamespace);
            abstractBaseSchema.SourceUri = templateSchema.SourceUri.Replace(abstractBaseElement.Name, Constants.abstractBaseSchemaName);

            abstractBaseComplexType.IsAbstract = true;
            abstractBaseComplexType.Annotation.Items.Clear();
            XmlSchemaDocumentation doc = new XmlSchemaDocumentation();
            var nodeCreaterDoc = new XmlDocument();
            doc.Markup = new XmlNode[] { nodeCreaterDoc.CreateTextNode("This is a custom generated class that holds all the props/fields common to all UBL maindocs."),
                                         nodeCreaterDoc.CreateTextNode("You won't find a matching xsd file where it originates from.") };
            abstractBaseComplexType.Annotation.Items.Add(doc);
            abstractBaseComplexType.Name = Constants.abstractBaseSchemaComplexTypeName;

            // remove non-shared tailing elements.
            XmlSchemaObjectCollection elementCollection = (abstractBaseComplexType.Particle as XmlSchemaSequence).Items;
            while (sharedElementCount < elementCollection.Count) elementCollection.RemoveAt(sharedElementCount);

            abstractBaseElement.Name = Constants.abstarctBaseSchemaElementName;
            abstractBaseElement.SchemaTypeName = new XmlQualifiedName(Constants.abstractBaseSchemaComplexTypeName, abstractBaseSchema.TargetNamespace);

            // Don't need schemaLocation for loaded schemas. Will generate schemasetcompile warnings if not removed
            foreach (var baseSchemaImports in abstractBaseSchema.Includes.OfType<XmlSchemaImport>()) baseSchemaImports.SchemaLocation = null;

            return abstractBaseSchema;
        }

        /// <summary>
        /// Maintain an ever shinking array of common elements(acc) as we aggLINQerate through each maindoc schema elementlist
        /// Both position and QualifiedName must match: "s.QualifiedName == next[i].QualifiedName"
        /// Start with the maindoc complextype with fewest elements first, hence the OrderBy
        /// Note: will not work once we have added abstactBaseSchema to the schemaset in main()
        /// </summary>
        /// <returns>Number of elements shared by all maindocs</returns>
        private static int GetSharedElementCount(ICollection<XmlSchema> maindocSchemas)
        {
            return maindocSchemas
                .Select(s => s.Items.OfType<XmlSchemaComplexType>().Single())
                .Select(c => (c.ContentTypeParticle as XmlSchemaSequence).Items.Cast<XmlSchemaElement>().ToArray())
                .OrderBy(c => c.Length)
                .Aggregate((acc, next) => acc.AsEnumerable().TakeWhile((s, i) => s.QualifiedName == next[i].QualifiedName).ToArray())
                .Count();
        }

        private static XmlSchema DeepCopy(XmlSchema sourceSchema)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                sourceSchema.Write(stream);
                stream.Position = 0;
                return XmlSchema.Read(stream, null);
            }
        }

    }
}
