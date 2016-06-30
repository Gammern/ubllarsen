using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Udt;
using UblLarsen.Tools;

namespace UblLarsen.Test
{


    /// <summary>
    ///This is a test class for InvoiceTypeTest and is intended
    ///to contain all InvoiceTypeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UblDocCreateAndSaveTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        [TestMethod]
        public void SaveImplicitCreatedNorwegianInvoice()
        {
            Func<decimal, AmountType> newAmountType = v => new AmountType { Value = v, currencyID = "NOK" };
            var taxVAT = new TaxSchemeType { ID = "VAT" };
            // Create an invoice using global defaults set above
            InvoiceType doc = new InvoiceType
            {
                CustomizationID = "urn:www.cenbii.eu:transaction:biicoretrdm010:ver1.0",
                ProfileID = "urn:www.cenbii.eu:profile:bii05:ver1.0",
                ID = "123456",
                IssueDate = new DateTime(2009, 11, 12),
                DocumentCurrencyCode = "NOK",
                OrderReference = new OrderReferenceType { ID = "Prosjekt 13" },
                ContractDocumentReference = new DocumentReferenceType[] { new DocumentReferenceType { ID = "K987654321" } },
                AccountingSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        PartyName = new PartyNameType[] { new PartyNameType { Name = "Leverandør" } },
                        PostalAddress = new AddressType
                        {
                            Postbox = "Postboks 123",
                            StreetName = "Oslogate",
                            BuildingNumber = "1",
                            CityName = "Oslo",
                            PostalZone = "0612",
                            Country = new CountryType { IdentificationCode = "NO" },
                        },
                        PartyTaxScheme = new PartyTaxSchemeType[]
                        {
                            new PartyTaxSchemeType 
                            {
                                CompanyID = "NO999999999MVA",
                                TaxScheme = new TaxSchemeType 
                                { 
                                    ID = new IdentifierType 
                                    { 
                                        schemeID = "UN/ECE 5153",
                                        schemeAgencyID = "6",
                                        Value = "VAT"
                                    } 
                                }
                            }
                        },
                        PartyLegalEntity = new PartyLegalEntityType[] 
                        {
                            new PartyLegalEntityType { CompanyID = "999999999" }
                        },
                        Contact = new ContactType { ID = "O Hansen" },

                    }
                },
                AccountingCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        PartyIdentification = new [] { new PartyIdentificationType { ID = "456789" } },
                        PartyName = new [] { new PartyNameType { Name = "Kjøper" } },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Testveien",
                            BuildingNumber = "1",
                            CityName = "Frogner",
                            PostalZone = "2012",
                            Country = new CountryType { IdentificationCode = "NO" }
                        },
                        PartyLegalEntity = new PartyLegalEntityType[]
                        {
                            new PartyLegalEntityType { CompanyID = "NO888888888MVA" }
                        },
                        Contact = new ContactType { ID = "Arne Bjarne Baluba" }
                    }
                },
                Delivery = new DeliveryType[]
                {
                    new DeliveryType 
                    {
                        ActualDeliveryDate =  new DateTime(2009,11,25),
                        DeliveryLocation = new LocationType
                        {
                            Address = new AddressType 
                            {
                                StreetName = "Testgata",
                                BuildingNumber = "1",
                                CityName = "Oslo",
                                PostalZone = "0112",
                                Country = new CountryType { IdentificationCode = "NO"}
                            }
                        }
                    }
                },
                PaymentMeans = new PaymentMeansType[]
                {
                    new PaymentMeansType
                    {
                        PaymentMeansCode = "31",
                        PaymentDueDate = new DateTime(2009, 11, 27),
                        PaymentID = new Ubl2.Udt.IdentifierType[] { "1234561" },
                        PayeeFinancialAccount = new FinancialAccountType
                        {
                            ID = "NO9386011117947",
                            FinancialInstitutionBranch = new BranchType
                            {
                                ID = new IdentifierType { schemeID="BIC", Value="DNBANOKK"},
                            }
                        }
                    }
                },
                TaxTotal = new TaxTotalType[]
                {
                    new TaxTotalType 
                    {
                        TaxAmount = newAmountType(962.0M),
                        TaxSubtotal = new TaxSubtotalType[]
                        {
                            new TaxSubtotalType 
                            {
                                TaxableAmount = newAmountType(3400.0M),
                                TaxAmount = newAmountType(850.0M),
                                TaxCategory = new TaxCategoryType 
                                { 
                                    ID = "S" ,
                                    Percent = 25.0M,
                                    TaxScheme = taxVAT
                                }
                            },
                            new TaxSubtotalType
                            {
                                TaxableAmount = newAmountType(800.0M),
                                TaxAmount = newAmountType(112.0M),
                                TaxCategory = new TaxCategoryType
                                {
                                    ID = "AA",
                                    Percent = 8.0M,
                                    TaxScheme = taxVAT
                                }
                            }
                        }
                    }
                },
                LegalMonetaryTotal = new MonetaryTotalType
                {
                    LineExtensionAmount = newAmountType(4200.0M),
                    TaxExclusiveAmount = newAmountType(4200.0M),
                    TaxInclusiveAmount = newAmountType(5162.0M),
                    PayableAmount = newAmountType(5162.0M)
                },
                InvoiceLine = new InvoiceLineType[] 
                { 
                    new InvoiceLineType
                    {
                        ID = "1",
                        InvoicedQuantity = new  Ubl2.Udt.QuantityType { unitCode="NMP", Value=2 },
                        LineExtensionAmount = newAmountType(400.0M),
                        AccountingCost = "200500600",
                        OrderLineReference = new OrderLineReferenceType[]
                        {
                            new OrderLineReferenceType { LineID = "5" }
                        },
                        TaxTotal = new TaxTotalType[]
                        {
                            new TaxTotalType { TaxAmount = newAmountType(100.0M) }
                        },
                        Item = new ItemType
                        {
                            Name = "Testprodukt 1",
                            SellersItemIdentification = new ItemIdentificationType { ID = "12345670" },
                            ClassifiedTaxCategory = new TaxCategoryType[] 
                            {
                                new TaxCategoryType 
                                { 
                                    ID = "S" ,
                                    Percent = 25.0M,
                                    TaxScheme = taxVAT
                                }
                            }
                        },
                        Price = new PriceType { PriceAmount = newAmountType(200.0M) } 
                    },
                    new InvoiceLineType
                    {
                        ID = "2" ,
                        InvoicedQuantity = new QuantityType { unitCode="NAR", Value=20 },
                        LineExtensionAmount = newAmountType(3000.0M) ,
                        AccountingCost = "200900600",
                        OrderLineReference = new OrderLineReferenceType[]
                        {
                            new OrderLineReferenceType { LineID = "7" }
                        },
                        TaxTotal = new TaxTotalType[]
                        {
                            new TaxTotalType { TaxAmount = newAmountType(750.0M) }
                        },
                        Item = new ItemType
                        {
                            Name = "Testprodukt 2",
                            SellersItemIdentification = new ItemIdentificationType { ID = "24683432" },
                            ClassifiedTaxCategory = new TaxCategoryType[] 
                            {
                                new TaxCategoryType 
                                { 
                                    ID = "S",
                                    Percent = 25.0M,
                                    TaxScheme = taxVAT
                                }
                            }
                        },
                        Price = new PriceType { PriceAmount = newAmountType(150.0M) }
                    },
                    new InvoiceLineType
                    {
                        ID = "3",
                        InvoicedQuantity = new QuantityType { unitCode="KGM", Value=8 },
                        LineExtensionAmount = newAmountType(800.0M),
                        AccountingCost = "200600700",
                        OrderLineReference = new OrderLineReferenceType[]
                        {
                            new OrderLineReferenceType { LineID = "8" }
                        },
                        TaxTotal = new TaxTotalType[]
                        {
                            new TaxTotalType { TaxAmount = newAmountType(112.0M) }
                        },
                        Item = new ItemType
                        {
                            Name = "Matprodukt 1",
                            SellersItemIdentification = new ItemIdentificationType { ID = "23456785" },
                            ClassifiedTaxCategory = new TaxCategoryType[] 
                            {
                                new TaxCategoryType 
                                { 
                                    ID = "AA",
                                    Percent = 8.0M,
                                    TaxScheme = taxVAT
                                }
                            }
                        },
                        Price = new PriceType { PriceAmount = newAmountType(100.0M) } 
                    }
                }
            };

            string filename = "SampleImplicitInvoice.xml";
            UblDoc<InvoiceType>.Save(filename, doc);

            // Use schema validation
            string xmlSchemaFilename = @"..\..\..\UBL-2.1\xsd\maindoc\UBL-Invoice-2.1.xsd";
            string preloadToAvoidExceptionFilename = @"..\..\..\UBL-2.1\xsd\common\UBL-xmldsig-core-schema-2.1.xsd";
            XmlSchemaSet invoiceSchemaSet = new XmlSchemaSet();
            // invoiceSchemaSet.Add(null, preloadToAvoidExceptionFilename); // bombs out!
            using (XmlTextReader tr = new XmlTextReader(preloadToAvoidExceptionFilename))
            {
                invoiceSchemaSet.Add(XmlSchema.Read(tr, null));
            }
            invoiceSchemaSet.Add(null, xmlSchemaFilename);
            invoiceSchemaSet.Compile();

            XDocument xDoc = XDocument.Load(filename);
            // throw if invalid
            System.Xml.Schema.Extensions.Validate(xDoc, invoiceSchemaSet, null);
        }

        /// <summary>
        /// Sample data taken from:
        /// http://www.anskaffelser.no/filearchive/implementation-guide-ehf-invoice-and-creditnote-v1.4.pdf
        /// </summary>
        [TestMethod]
        public void SaveImplicitCreatedNorwegianCreditNote()
        {
            Func<decimal, AmountType> newAmountType = v => new AmountType { Value = v, currencyID = "NOK" };

            // Set global defaults for Ubl documents that get created
            var customizationID = "urn:www.cenbii.eu:transaction:BiiCoreTrdm001:ver1.0:extentionId";
            var profileID = "urn:www.cenbii.eu:profile:bii05:ver1.0";

            // Set thread local default for all amounts types decending from AmountType
            //Ubl2.Udt.AmountType.TlsDefaultCurrencyID = "NOK";

            // Create a serializable CreditNote instance.
            CreditNoteType doc = new CreditNoteType();
            doc.CustomizationID = customizationID;
            doc.ProfileID = profileID;
            doc.ID = "654321";
            doc.UBLVersionID = "2.0";
            doc.DocumentCurrencyCode = "NOK";
            doc.IssueDate = new DateTime(2009, 11, 12, 0, 0, 0, DateTimeKind.Utc);

            // <cac:BillingReference> 
            //   <cac:InvoiceDocumentReference> 
            //     <cbc:ID>123456</cbc:ID> 
            //   </cac:InvoiceDocumentReference> 
            // </cac:BillingReference>
            // Becomes:
            doc.BillingReference = new BillingReferenceType[] 
            {  
                new BillingReferenceType{ InvoiceDocumentReference = new DocumentReferenceType { ID = "123456" } }
            };

            doc.AccountingSupplierParty = new SupplierPartyType
            {
                Party = new PartyType
                {
                    PartyName = new [] { new PartyNameType { Name = "Leverandør" } },
                    PostalAddress = new AddressType
                    {
                        Postbox = "Postboks 123",
                        StreetName = "Oslogate",
                        BuildingNumber = "1",
                        CityName = "Oslo",
                        PostalZone = "0612",
                        Country = new CountryType { IdentificationCode = "NO" }
                    },
                    PartyLegalEntity = new PartyLegalEntityType[] { new PartyLegalEntityType { CompanyID = "NO999999999MVA" } },
                    Contact = new ContactType { ID = "O Hansen" },
                }
            };

            // Populating class instance the old way but are still using implicit operator assingnment functions
            doc.AccountingCustomerParty = new CustomerPartyType();
            PartyType p = new PartyType();
            doc.AccountingCustomerParty.Party = p;
            p.PartyIdentification = new [] { new PartyIdentificationType { ID = "456789" } };
            p.PartyName = new PartyNameType[1];
            p.PartyName[0] = new PartyNameType { Name = "Kjøper" };
            p.PostalAddress = new AddressType();
            p.PostalAddress.StreetName = "Testveien";
            p.PostalAddress.BuildingNumber = "1";
            p.PostalAddress.CityName = "Frogner";
            p.PostalAddress.PostalZone = "2012";
            p.PostalAddress.Country = new CountryType();
            p.PostalAddress.Country.IdentificationCode = "NO"; // implicit operator called behind the scenes here
            //p.PostalAddress.Country.IdentificationCode = new CodeType { Value = "NO" };
            p.PartyLegalEntity = new PartyLegalEntityType[] { new PartyLegalEntityType() };
            p.PartyLegalEntity[0].CompanyID = "NO888888888MVA";
            p.Contact = new ContactType { ID = "3150bdn" };

            TaxTotalType tax = new TaxTotalType();
            doc.TaxTotal = new TaxTotalType[1] { tax };
            tax.TaxAmount = newAmountType(112.0M);
            tax.TaxSubtotal = new TaxSubtotalType[1] { new TaxSubtotalType() };
            tax.TaxSubtotal[0].TaxableAmount = newAmountType(800.0M);
            tax.TaxSubtotal[0].TaxAmount = newAmountType(112.0M);
            tax.TaxSubtotal[0].TaxCategory = new TaxCategoryType
            {
                ID = "AA",
                Percent = 14.0M,
                TaxScheme = new TaxSchemeType { ID = "VAT" }
            };

            doc.LegalMonetaryTotal = new MonetaryTotalType();
            doc.LegalMonetaryTotal.LineExtensionAmount = new AmountType { Value = 800.0M, currencyID = "AED" }; // Note difi.no doc use "AED" instead of DocumentCurrency code. QA slip.
            doc.LegalMonetaryTotal.TaxExclusiveAmount = new AmountType { Value = 800.0M, currencyID = "AED" };
            doc.LegalMonetaryTotal.TaxInclusiveAmount = new AmountType { Value = 912.0M, currencyID = "AED" }; 
            doc.LegalMonetaryTotal.PayableAmount = new AmountType { Value = 912.0M, currencyID = "AED" }; 

            doc.CreditNoteLine = new CreditNoteLineType[1];
            doc.CreditNoteLine[0] = new CreditNoteLineType
            {
                ID = "1",
                CreditedQuantity = new QuantityType { Value = 8, unitCode = "KGM" },
                LineExtensionAmount = newAmountType(800.0M),
                TaxTotal = new TaxTotalType[] { new TaxTotalType { TaxAmount = newAmountType(112.0M) } },
                Item = new ItemType
                {
                    Name = "Matprodukt-1",
                    SellersItemIdentification = new ItemIdentificationType { ID = "23456785" },
                    ClassifiedTaxCategory = new TaxCategoryType[] 
                    {
                        new TaxCategoryType
                        {
                            ID = "S",
                            Percent = 14.0M,
                            TaxScheme = new TaxSchemeType { ID = "VAT" }
                        }
                    }
                },
                Price = new PriceType { PriceAmount = newAmountType(100.0M) }
            };
            
            // save the creditnote to xml
            string filename = "ImplicitCreatedNorwegianCreditNote.xml";
            UblDoc<CreditNoteType>.Save(filename, doc);

            // Compare it with a local copy grabbed from difi.no doc
            bool areEqual = UblXmlComparer.IsCopyEqual<CreditNoteType>("NorwegianCreditNoteFromDifiPdfDoc.xml", doc);
            Assert.AreEqual(areEqual, true, "Written UBL doc differs from original");
        }
    }
}
