// Generated by UblXml2CSharp
using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLInventoryReport21Example
    {
        public static InventoryReportType Create()
        {
            var doc = new InventoryReportType
            {
                UBLVersionID = "2.1",
                ID = "CC2679",
                CopyIndicator = false,
                IssueDate = "2010-04-12",
                Note = new TextType[]
                {
                    new TextType
                    {
                        Value = "Report about the quantities on stock."
                    }
                },
                DocumentCurrencyCode = new CodeType
                {
                    listID = "ISO 4217 Alpha",
                    Value = "EUR"
                },
                InventoryPeriod = new PeriodType
                {
                    StartDate = "2010-04-11",
                    StartTime = "14:00:00",
                    EndDate = "2010-04-11"
                },
                RetailerCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        PartyName = new PartyNameType[]
                        {
                            new PartyNameType
                            {
                                Name = "Beta Shop"
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Via Emilia",
                            BuildingNumber = "1",
                            CityName = "Modena",
                            PostalZone = "41121",
                            Country = new CountryType
                            {
                                IdentificationCode = "IT",
                                Name = "Italy"
                            }
                        },
                        Contact = new ContactType
                        {
                            Name = "Mr Delta",
                            Telephone = "0039 059 33000000",
                            Telefax = "0039 059 33000055",
                            ElectronicMail = "delta@betashop.it"
                        }
                    }
                },
                InventoryReportingParty = new PartyType
                {
                    PartyName = new PartyNameType[]
                    {
                        new PartyNameType
                        {
                            Name = "Arancio Forniture spa"
                        }
                    },
                    PostalAddress = new AddressType
                    {
                        StreetName = "Via Dell'Arcoveggio",
                        BuildingNumber = "405",
                        Department = "Sales and Planning Department",
                        CityName = "Bologna",
                        PostalZone = "40129",
                        Country = new CountryType
                        {
                            IdentificationCode = "IT",
                            Name = "Italy"
                        }
                    },
                    Contact = new ContactType
                    {
                        Name = "Mr Bianchi",
                        Telephone = "0039 051 23000008",
                        Telefax = "0039 051 23000025",
                        ElectronicMail = "bianchi@arancioforniture.it"
                    }
                },
                SellerSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        PartyName = new PartyNameType[]
                        {
                            new PartyNameType
                            {
                                Name = "Arancio Forniture spa"
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Via Dell'Arcoveggio",
                            BuildingNumber = "403",
                            CityName = "Bologna",
                            PostalZone = "40129",
                            Country = new CountryType
                            {
                                IdentificationCode = "IT",
                                Name = "Italy"
                            }
                        },
                        Contact = new ContactType
                        {
                            Name = "Mr Rossi",
                            Telephone = "0039 051 23000000",
                            Telefax = "0039 051 23000023",
                            ElectronicMail = "rossi@arancioforniture.it"
                        }
                    }
                },
                InventoryReportLine = new InventoryReportLineType[]
                {
                    new InventoryReportLineType
                    {
                        ID = "1",
                        Quantity = new QuantityType
                        {
                            unitCode = "NAR",
                            Value = 10M
                        },
                        InventoryValueAmount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = 200M
                        },
                        Item = new ItemType
                        {
                            Description = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "shirt"
                                }
                            },
                            BuyersItemIdentification = new ItemIdentificationType
                            {
                                ID = "SH009"
                            },
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "DD88"
                            }
                        }
                    },
                    new InventoryReportLineType
                    {
                        ID = "2",
                        Quantity = new QuantityType
                        {
                            unitCode = "NAR",
                            Value = 15M
                        },
                        InventoryValueAmount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = 750M
                        },
                        Item = new ItemType
                        {
                            Description = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "trousers"
                                }
                            },
                            BuyersItemIdentification = new ItemIdentificationType
                            {
                                ID = "TH009"
                            },
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "DA008"
                            }
                        }
                    },
                    new InventoryReportLineType
                    {
                        ID = "3",
                        Quantity = new QuantityType
                        {
                            unitCode = "NAR",
                            Value = 5M
                        },
                        InventoryValueAmount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = 300M
                        },
                        Item = new ItemType
                        {
                            Description = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "woman's dress"
                                }
                            },
                            BuyersItemIdentification = new ItemIdentificationType
                            {
                                ID = "DH019"
                            },
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "BA058"
                            }
                        }
                    }
                }
            };
            doc.Xmlns = new System.Xml.Serialization.XmlSerializerNamespaces(new[]
            {
                new XmlQualifiedName("cbc","urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"),
                new XmlQualifiedName("cac","urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"),
            });
            return doc;
        }
    }
}
