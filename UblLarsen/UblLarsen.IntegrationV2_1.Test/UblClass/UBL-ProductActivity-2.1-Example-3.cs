using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLProductActivity21Example3
    {
        public static ProductActivityType Create()
        {
            return new ProductActivityType
            {
                UBLVersionID = "2.1",
                ID = "ID0113",
                CopyIndicator = false,
                IssueDate = XmlConvert.ToDateTime("2010-04-08", XmlDateTimeSerializationMode.RoundtripKind),
                Note = new TextType[]
                {
                    new TextType
                    {
                        Value = "Report about sales of goods in Beta Shop's shops located in Bologna."
                    }
                },
                ActivityPeriod = new PeriodType
                {
                    StartDate = XmlConvert.ToDateTime("2010-04-07", XmlDateTimeSerializationMode.RoundtripKind)
                },
                SenderParty = new PartyType
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
                },
                ReceiverParty = new PartyType
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
                        Floor = "5",
                        Room = "29",
                        StreetName = "Via Dell'Arcoveggio",
                        BuildingNumber = "403",
                        Department = "Marketing Office",
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
                },
                SupplyChainActivityDataLine = new ActivityDataLineType[]
                {
                    new ActivityDataLineType
                    {
                        ID = "1",
                        SupplyChainActivityTypeCode = "SALES",
                        ActivityOriginLocation = new LocationType
                        {
                            Description = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "Shop in the city center"
                                }
                            },
                            Address = new AddressType
                            {
                                StreetName = "Via Rizzoli",
                                BuildingNumber = "208",
                                CityName = "Bologna",
                                PostalZone = "40121",
                                Country = new CountryType
                                {
                                    IdentificationCode = "IT",
                                    Name = "Italy"
                                }
                            }
                        },
                        SalesItem = new SalesItemType[]
                        {
                            new SalesItemType
                            {
                                Quantity = new QuantityType
                                {
                                    unitCode = "NAR",
                                    Value = 8M
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
                            new SalesItemType
                            {
                                Quantity = new QuantityType
                                {
                                    unitCode = "NAR",
                                    Value = 3M
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
                            }
                        }
                    }
                }
            }
;
        }
    }
}
