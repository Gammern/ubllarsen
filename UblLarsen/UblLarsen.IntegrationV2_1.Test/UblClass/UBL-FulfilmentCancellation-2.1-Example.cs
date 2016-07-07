using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLFulfilmentCancellation21Example
    {
        public static FulfilmentCancellationType Create()
        {
            return new FulfilmentCancellationType
            {
                UBLVersionID = "2.1",
                ID = "00384",
                CopyIndicator = false,
                IssueDate = XmlConvert.ToDateTime("2005-06-22", XmlDateTimeSerializationMode.RoundtripKind),
                Note = new TextType[]
                {
                    new TextType
                    {
                        Value = "sample"
                    }
                },
                CancellationNote = new TextType[]
                {
                    new TextType
                    {
                        Value = @"The quality check has detected that the beeswax doesn't become liquid at the
        expected temperature."
                    }
                },
                DespatchDocumentReference = new DocumentReferenceType[]
                {
                    new DocumentReferenceType
                    {
                        ID = "565899",
                        UUID = "88C7280E-8F10-419F-9949-8EFFFA2842B8",
                        IssueDate = XmlConvert.ToDateTime("2005-06-20", XmlDateTimeSerializationMode.RoundtripKind)
                    }
                },
                ReceiptDocumentReference = new DocumentReferenceType[]
                {
                    new DocumentReferenceType
                    {
                        ID = "658398",
                        UUID = "89F82FA6-5331-491D-83BC-7B6CA7FD047C",
                        IssueDate = XmlConvert.ToDateTime("2005-06-21", XmlDateTimeSerializationMode.RoundtripKind)
                    }
                },
                OrderReference = new OrderReferenceType[]
                {
                    new OrderReferenceType
                    {
                        ID = "AEG012345",
                        SalesOrderID = "CON0095678",
                        UUID = "6E09886B-DC6E-439F-82D1-7CCAC7F4E3B1",
                        IssueDate = XmlConvert.ToDateTime("2005-06-20", XmlDateTimeSerializationMode.RoundtripKind)
                    }
                },
                BuyerCustomerParty = new CustomerPartyType
                {
                    CustomerAssignedAccountID = "XFB01",
                    SupplierAssignedAccountID = "GT00978567",
                    Party = new PartyType
                    {
                        PartyName = new PartyNameType[]
                        {
                            new PartyNameType
                            {
                                Name = "IYT Corporation"
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Avon Way",
                            BuildingName = "Thereabouts",
                            BuildingNumber = "56A",
                            CityName = "Bridgtow",
                            PostalZone = "ZZ99 1ZZ",
                            CountrySubentity = "Avon",
                            AddressLine = new AddressLineType[]
                            {
                                new AddressLineType
                                {
                                    Line = "3rd Floor, Room 5"
                                }
                            },
                            Country = new CountryType
                            {
                                IdentificationCode = "GB"
                            }
                        },
                        PartyTaxScheme = new PartyTaxSchemeType[]
                        {
                            new PartyTaxSchemeType
                            {
                                RegistrationName = "Bridgtow District Council",
                                CompanyID = "12356478",
                                ExemptionReason = new TextType[]
                                {
                                    new TextType
                                    {
                                        Value = "Local Authority"
                                    }
                                },
                                TaxScheme = new TaxSchemeType
                                {
                                    ID = "UK VAT",
                                    TaxTypeCode = "VAT"
                                }
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
                SellerSupplierParty = new SupplierPartyType
                {
                    CustomerAssignedAccountID = "CO001",
                    Party = new PartyType
                    {
                        PartyName = new PartyNameType[]
                        {
                            new PartyNameType
                            {
                                Name = "Consortial"
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Busy Street",
                            BuildingName = "Thereabouts",
                            BuildingNumber = "56A",
                            CityName = "Farthing",
                            PostalZone = "AA99 1BB",
                            CountrySubentity = "Heremouthshire",
                            AddressLine = new AddressLineType[]
                            {
                                new AddressLineType
                                {
                                    Line = "The Roundabout"
                                }
                            },
                            Country = new CountryType
                            {
                                IdentificationCode = "GB"
                            }
                        },
                        PartyTaxScheme = new PartyTaxSchemeType[]
                        {
                            new PartyTaxSchemeType
                            {
                                RegistrationName = "Farthing Purchasing Consortium",
                                CompanyID = "175 269 2355",
                                ExemptionReason = new TextType[]
                                {
                                    new TextType
                                    {
                                        Value = "N/A"
                                    }
                                },
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
                            ElectronicMail = "bouquet@fpconsortial.co.uk"
                        }
                    }
                }
            }
;
        }
    }
}
