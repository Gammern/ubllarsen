// ------------------------------------------------------------------------------
//  This is a sample that show the following:
//   - How to save an UBL Larsen invoice instance to xml
//   - Xml file xsd validation
//
// Sample data taken from
// http://docs.oasis-open.org/ubl/os-UBL-2.0-update/xml/UBL-Invoice-2.0-Example.xml
// ------------------------------------------------------------------------------

using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Udt;

namespace InvoiceSaveSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string xmlFilename = @"InvoiceSaveSample.xml";
            UblLarsen.Ubl2.InvoiceType invoice = PopulateInvoiceWithSampleData();

            XmlWriterSettings setting = new XmlWriterSettings();
            setting.Indent = true;
            setting.IndentChars = "\t";
            setting.NewLineOnAttributes = false;

            using (XmlWriter writer = XmlWriter.Create(xmlFilename, setting))
            {
                new XmlSerializer(invoice.GetType()).Serialize(writer, invoice);
            }

            // Make sure namespace declarations are on a separate line. Easy reading
            var utf16AttributedWithUtf8 = File.ReadAllText(xmlFilename);
            utf16AttributedWithUtf8 = utf16AttributedWithUtf8.Replace("xmlns", Environment.NewLine + "\t\txmlns");
            File.WriteAllText(xmlFilename, utf16AttributedWithUtf8, Encoding.UTF8);

            Console.WriteLine("Invoice written to:\n{0}", new FileInfo(xmlFilename).FullName);
            Console.WriteLine("Compare it with:\n{0}", "http://docs.oasis-open.org/ubl/os-UBL-2.0-update/xml/UBL-Invoice-2.0-Example.xml");
            // Don't match 100%. Unused namespace prefix declarations are missing.
            // Only the ones declared in "UblLarsen.Ubl2\NonGenerated\maindoc\UBL-BaseDocument-2.1.partial.cs" are present.
            // See the unittest for more save samples
        }

        private static UblLarsen.Ubl2.InvoiceType PopulateInvoiceWithSampleData()
        {
            // simplify creation of AmountType
            Func<decimal, AmountType> newAmountType = v => new AmountType { Value = v, currencyID = "GBP" };

            UblLarsen.Ubl2.InvoiceType res = new UblLarsen.Ubl2.InvoiceType
            {
                UBLVersionID = "2.0",
                CustomizationID = "urn:oasis:names:specification:ubl:xpath:Invoice-2.0:sbs-1.0-draft",
                ProfileID = "bpid:urn:oasis:names:draft:bpss:ubl-2-sbs-invoice-notification-draft",
                ID = "A00095678",
                CopyIndicator = false,
                UUID = "849FBBCE-E081-40B4-906C-94C5FF9D1AC3",
                IssueDate = new DateTime(2005, 6, 21),
                InvoiceTypeCode = "SalesInvoice",
                Note = new[] { (TextType)"sample" },
                TaxPointDate = new DateTime(2005, 6, 21),
                OrderReference = new OrderReferenceType
                {
                    ID = "AEG012345",
                    SalesOrderID = "CON0095678",
                    UUID = "6E09886B-DC6E-439F-82D1-7CCAC7F4E3B1",
                    IssueDate = new DateTime(2005, 6, 20)
                },
                AccountingSupplierParty = new SupplierPartyType
                {
                    CustomerAssignedAccountID = "CO001",
                    Party = new PartyType
                    {
                        PartyName = new [] { new PartyNameType { Name = "Consortial" } },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Busy Street",
                            BuildingName = "Thereabouts",
                            BuildingNumber = "56A",
                            CityName = "Farthing",
                            PostalZone = "AA99 1BB",
                            CountrySubentity = "Heremouthshire",
                            AddressLine = new [] { new AddressLineType { Line = "The Roundabout" } },
                            Country = new CountryType { IdentificationCode = "GB" }
                        },
                        PartyTaxScheme = new[] // implicitly typed array initialization
                        {
                            new PartyTaxSchemeType
                            {
                                RegistrationName = "Farthing Purchasing Consortia",
                                CompanyID = "175 269 2355",
                                ExemptionReason = new TextType[] { "N/A" },
                                TaxScheme = new TaxSchemeType
                                {
                                    ID = "VAT",
                                    TaxTypeCode = "VAT"
                                }
                            }
                        },
                        Contact = new ContactType
                        {
                            Name = "Mrs Bouquet",
                            Telephone = "0158 1233714",
                            Telefax = "0158 1233856",
                            ElectronicMail = "bouquet@fpconsortial.co.uk",
                        }
                    }
                },
                AccountingCustomerParty = new CustomerPartyType
                {
                    CustomerAssignedAccountID = "XFB01",
                    SupplierAssignedAccountID = "GT00978567",
                    Party = new PartyType
                    {
                        PartyName = new[] { new PartyNameType { Name = "IYT Corporation" } },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Avon Way",
                            BuildingName = "Thereabouts",
                            BuildingNumber = "56A",
                            CityName = "Bridgtow",
                            PostalZone = "ZZ99 1ZZ",
                            CountrySubentity = "Avon",
                            AddressLine = new [] { new AddressLineType { Line = "3rd Floor, Room 5" } },
                            Country = new CountryType { IdentificationCode = "GB" }
                        },
                        PartyTaxScheme = new[]
                        {
                            new PartyTaxSchemeType
                            {
                                RegistrationName = "Bridgtow District Council",
                                CompanyID = "12356478",
                                ExemptionReason = new [] { (TextType)"Local Authority" },
                                TaxScheme = new TaxSchemeType { ID = "UK VAT", TaxTypeCode="VAT" }
                            }
                        },
                        Contact = new ContactType
                        {
                            Name = "Mr Fred Churchill",
                            Telephone = "0127 2653214",
                            Telefax = "0127 2653215",
                            ElectronicMail = "fred@iytcorporation.gov.uk"
                        }
                    }
                },
                Delivery = new[]
                {
                    new DeliveryType
                    {
                        ActualDeliveryDate = new DateTime(2005,6,20),
                        ActualDeliveryTime = "11:30:00.0Z",
                        DeliveryAddress = new AddressType
                        {
                            StreetName = "Avon Way",
                            BuildingName = "Thereabouts",
                            BuildingNumber = "56A",
                            CityName = "Bridgtow",
                            PostalZone = "ZZ99 1ZZ",
                            CountrySubentity = "Avon",
                            AddressLine = new [] { new AddressLineType { Line = "3rd Floor, Room 5" } },
                            Country = new CountryType { IdentificationCode = "GB"}
                        }
                    }
                },
                PaymentMeans = new[]
                {
                    new PaymentMeansType
                    {
                        PaymentMeansCode = "20",
                        PaymentDueDate = new DateTime(2005,7,21),
                        PayeeFinancialAccount = new FinancialAccountType
                        {
                            ID = "12345678",
                            Name = "Farthing Purchasing Consortia",
                            AccountTypeCode = "Current",
                            CurrencyCode = "GBP",
                            FinancialInstitutionBranch = new BranchType
                            {
                                ID = "10-26-58",
                                Name = "Open Bank Ltd, Bridgstow Branch ",
                                FinancialInstitution = new FinancialInstitutionType
                                {
                                    ID = "10-26-58",
                                    Name = "Open Bank Ltd",
                                    Address = new AddressType
                                    {
                                        StreetName = "City Road",
                                        BuildingName = "Banking House",
                                        BuildingNumber = "12",
                                        CityName = "London",
                                        PostalZone = "AQ1 6TH",
                                        CountrySubentity = "London",
                                        AddressLine = new [] { new AddressLineType { Line = "5th Floor" } },
                                        Country = new CountryType { IdentificationCode = "GB" }
                                    }
                                },
                                Address = new AddressType
                                {
                                    StreetName = "Busy Street",
                                    BuildingName = "The Mall",
                                    BuildingNumber = "152",
                                    CityName = "Farthing",
                                    PostalZone = "AA99 1BB",
                                    CountrySubentity = "Heremouthshire",
                                    AddressLine = new [] { new AddressLineType { Line = "West Wing" } },
                                    Country = new CountryType {  IdentificationCode = "GB" }
                                }
                            },
                            Country = new CountryType { IdentificationCode = "GB" }
                        }
                    }
                },
                PaymentTerms = new[]
                {
                    new PaymentTermsType
                    {
                        Note = new TextType[] { "Payable within 1 calendar month from the invoice date" },
                    }
                },
                AllowanceCharge = new[]
                {
                    new AllowanceChargeType
                    {
                        ChargeIndicator = false,
                        AllowanceChargeReasonCode = "17",
                        MultiplierFactorNumeric = 0.10M,
                        Amount = newAmountType(10.00M)
                    }
                },
                TaxTotal = new[]
                {
                    new TaxTotalType
                    {
                        TaxAmount = newAmountType(17.50M),
                        TaxEvidenceIndicator = true,
                        TaxSubtotal = new []
                        {
                            new TaxSubtotalType
                            {
                                TaxableAmount = newAmountType(100.00M),
                                TaxAmount = newAmountType(17.50M),
                                TaxCategory = new TaxCategoryType
                                {
                                    ID = "A",
                                    TaxScheme = new TaxSchemeType { ID = "UK VAT", TaxTypeCode = "VAT"}
                                }
                            }
                        }
                    }
                },
                LegalMonetaryTotal = new MonetaryTotalType
                {
                    LineExtensionAmount = newAmountType(100.00M),
                    TaxExclusiveAmount = newAmountType(90.00M),
                    AllowanceTotalAmount = newAmountType(10.00M),
                    PayableAmount = newAmountType(107.50M)
                },
                InvoiceLine = new[]
                {
                    new InvoiceLineType
                    {
                        ID = "A",
                        InvoicedQuantity = new QuantityType{ unitCode="KG", Value=100 },
                        LineExtensionAmount = newAmountType(100.00M),
                        OrderLineReference = new OrderLineReferenceType[]
                        {
                            new OrderLineReferenceType
                            {
                                LineID = "1",
                                SalesOrderLineID = "A",
                                LineStatusCode = "NoStatus",
                                OrderReference = new OrderReferenceType
                                {
                                    ID = "AEG012345",
                                    SalesOrderID = "CON0095678",
                                    UUID = "6E09886B-DC6E-439F-82D1-7CCAC7F4E3B1",
                                    IssueDate = new DateTime(2005,6,20)
                                }
                            }
                        },
                        TaxTotal = new []
                        {
                            new TaxTotalType
                            {
                                TaxAmount = newAmountType(17.50M),
                                TaxEvidenceIndicator = true,
                                TaxSubtotal = new TaxSubtotalType[]
                                {
                                    new TaxSubtotalType
                                    {
                                        TaxableAmount = newAmountType(100.00M),
                                        TaxAmount = newAmountType(17.50M),
                                        TaxCategory = new TaxCategoryType
                                        {
                                            ID = "A",
                                            Percent = 17.5M,
                                            TaxScheme = new TaxSchemeType { ID = "UK VAT", TaxTypeCode = "VAT"}
                                        }
                                    }
                                }
                            }
                        },
                        Item = new ItemType
                        {
                            Description = new TextType[] { "Acme beeswax" },
                            Name = "beeswax",
                            BuyersItemIdentification = new ItemIdentificationType { ID = "6578489" },
                            SellersItemIdentification = new ItemIdentificationType { ID = "17589683" },
                            ItemInstance = new []
                            {
                                new ItemInstanceType
                                {
                                    LotIdentification = new LotIdentificationType { LotNumberID = "546378239", ExpiryDate = new DateTime(2010,1,1) }
                                }
                            }
                        },
                        Price = new PriceType
                        {
                            PriceAmount = newAmountType(1.00M),
                            BaseQuantity = new QuantityType{ unitCode="KG", Value = 1 }
                        }
                    }
                }
            };

            return res;
        }

    }

}
