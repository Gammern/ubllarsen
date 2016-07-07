using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLStockAvailabilityReport21Example
    {
        public static StockAvailabilityReportType Create()
        {
            return new StockAvailabilityReportType
            {
                UBLVersionID = "2.1",
                ID = "SA2009",
                CopyIndicator = false,
                IssueDate = XmlConvert.ToDateTime("2010-04-11", XmlDateTimeSerializationMode.RoundtripKind),
                Note = new TextType[]
                {
                    new TextType
                    {
                        Value = "Report about quantities of each item which are (or will be) available"
                    }
                },
                InventoryPeriod = new PeriodType
                {
                    StartDate = XmlConvert.ToDateTime("2010-04-11", XmlDateTimeSerializationMode.RoundtripKind),
                    StartTime = "08:00:00",
                    EndDate = XmlConvert.ToDateTime("2011-04-11", XmlDateTimeSerializationMode.RoundtripKind)
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
                            Name = "Beta Shop"
                        }
                    },
                    PostalAddress = new AddressType
                    {
                        Floor = "2",
                        Room = "309",
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
                        Name = "Mr Gamma",
                        Telephone = "0039 059 33000022",
                        Telefax = "0039 059 33000057",
                        ElectronicMail = "gamma@betashop.it"
                    }
                },
                StockAvailabilityReportLine = new StockAvailabilityReportLineType[]
                {
                    new StockAvailabilityReportLineType
                    {
                        ID = "1",
                        Quantity = new QuantityType
                        {
                            unitCode = "NAR",
                            Value = 50M
                        },
                        AvailabilityDate = XmlConvert.ToDateTime("2010-04-20", XmlDateTimeSerializationMode.RoundtripKind),
                        AvailabilityStatusCode = new CodeType
                        {
                            listID = "7011",
                            listAgencyName = "UN/ECE",
                            listURI = "http://www.unece.org/trade/untdid/d09b/tred/tred7011.htm",
                            Value = "1"
                        },
                        Item = new ItemType
                        {
                            Description = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "T-shirt"
                                }
                            },
                            BuyersItemIdentification = new ItemIdentificationType
                            {
                                ID = "TT319"
                            },
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "ZZ738"
                            }
                        }
                    },
                    new StockAvailabilityReportLineType
                    {
                        ID = "2",
                        Quantity = new QuantityType
                        {
                            unitCode = "NAR",
                            Value = 80M
                        },
                        AvailabilityDate = XmlConvert.ToDateTime("2010-04-11", XmlDateTimeSerializationMode.RoundtripKind),
                        AvailabilityStatusCode = new CodeType
                        {
                            listID = "7011",
                            listAgencyName = "UN/ECE",
                            listURI = "http://www.unece.org/trade/untdid/d09b/tred/tred7011.htm",
                            Value = "2"
                        },
                        Item = new ItemType
                        {
                            Description = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "jersey"
                                }
                            },
                            BuyersItemIdentification = new ItemIdentificationType
                            {
                                ID = "TJ043"
                            },
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "K0058"
                            }
                        }
                    },
                    new StockAvailabilityReportLineType
                    {
                        ID = "3",
                        Quantity = new QuantityType
                        {
                            unitCode = "NAR",
                            Value = 0M
                        },
                        AvailabilityStatusCode = new CodeType
                        {
                            listID = "7011",
                            listAgencyName = "UN/ECE",
                            listURI = "http://www.unece.org/trade/untdid/d09b/tred/tred7011.htm",
                            Value = "8"
                        },
                        Item = new ItemType
                        {
                            Description = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "skirt"
                                }
                            },
                            BuyersItemIdentification = new ItemIdentificationType
                            {
                                ID = "TS893"
                            },
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "PK009"
                            }
                        }
                    }
                }
            }
;
        }
    }
}
