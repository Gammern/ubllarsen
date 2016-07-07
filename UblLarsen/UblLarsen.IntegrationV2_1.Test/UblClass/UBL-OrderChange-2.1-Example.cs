// Generated by UblXml2CSharp
using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLOrderChange21Example
    {
        public static OrderChangeType Create()
        {
            return new OrderChangeType
            {
                UBLVersionID = "2.1",
                CustomizationID = "urn:www.cenbii.eu:transaction:biicoretrdmXYZ:ver1.0",
                ProfileID = new IdentifierType
                {
                    schemeAgencyID = "BII",
                    schemeID = "Profile",
                    Value = "urn:www.cenbii.eu:profile:BIIXYZ:ver1.0"
                },
                ID = "7",
                IssueDate = XmlConvert.ToDateTime("2010-01-21", XmlDateTimeSerializationMode.RoundtripKind),
                IssueTime = "12:30:00",
                SequenceNumberID = "1",
                Note = new TextType[]
                {
                    new TextType
                    {
                        Value = "Information text for the whole order change"
                    }
                },
                OrderReference = new OrderReferenceType
                {
                    ID = "34"
                },
                BuyerCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = new IdentifierType
                        {
                            schemeAgencyID = "9",
                            schemeID = "GLN",
                            Value = "7300072311115"
                        },
                        PartyIdentification = new PartyIdentificationType[]
                        {
                            new PartyIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeAgencyID = "9",
                                    schemeID = "GLN",
                                    Value = "7300070011115"
                                }
                            },
                            new PartyIdentificationType
                            {
                                ID = "PartyID123"
                            }
                        },
                        PartyName = new PartyNameType[]
                        {
                            new PartyNameType
                            {
                                Name = "Johnssons byggvaror"
                            }
                        }
                    }
                },
                SellerSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = new IdentifierType
                        {
                            schemeAgencyID = "9",
                            schemeID = "GLN",
                            Value = "7302347231111"
                        },
                        PartyIdentification = new PartyIdentificationType[]
                        {
                            new PartyIdentificationType
                            {
                                ID = "SellerPartyID123"
                            }
                        },
                        PartyName = new PartyNameType[]
                        {
                            new PartyNameType
                            {
                                Name = "Moderna Produkter AB"
                            }
                        }
                    }
                },
                OrderLine = new OrderLineType[]
                {
                    new OrderLineType
                    {
                        Note = new TextType[]
                        {
                            new TextType
                            {
                                Value = "Freetext note on line 1"
                            }
                        },
                        LineItem = new LineItemType
                        {
                            ID = "1",
                            LineStatusCode = new CodeType
                            {
                                listAgencyID = "UBL",
                                listName = "Line Status",
                                Value = "Revised"
                            },
                            Quantity = new QuantityType
                            {
                                unitCode = "LTR",
                                Value = 240M
                            },
                            LineExtensionAmount = new AmountType
                            {
                                currencyID = "SEK",
                                Value = 12000M
                            },
                            TotalTaxAmount = new AmountType
                            {
                                currencyID = "SEK",
                                Value = 20M
                            },
                            PartialDeliveryIndicator = false,
                            AccountingCostCode = "ProjectID123",
                            Delivery = new DeliveryType[]
                            {
                                new DeliveryType
                                {
                                    RequestedDeliveryPeriod = new PeriodType
                                    {
                                        StartDate = XmlConvert.ToDateTime("2010-02-10", XmlDateTimeSerializationMode.RoundtripKind),
                                        EndDate = XmlConvert.ToDateTime("2010-02-25", XmlDateTimeSerializationMode.RoundtripKind)
                                    }
                                }
                            },
                            OriginatorParty = new PartyType
                            {
                                PartyIdentification = new PartyIdentificationType[]
                                {
                                    new PartyIdentificationType
                                    {
                                        ID = new IdentifierType
                                        {
                                            schemeAgencyID = "ZZZ",
                                            schemeID = "ZZZ",
                                            Value = "EmployeeXXX"
                                        }
                                    }
                                },
                                PartyName = new PartyNameType[]
                                {
                                    new PartyNameType
                                    {
                                        Name = "Josef K."
                                    }
                                }
                            },
                            Price = new PriceType
                            {
                                PriceAmount = new AmountType
                                {
                                    currencyID = "SEK",
                                    Value = 50M
                                },
                                BaseQuantity = new QuantityType
                                {
                                    unitCode = "LTR",
                                    Value = 1M
                                }
                            },
                            Item = new ItemType
                            {
                                Description = new TextType[]
                                {
                                    new TextType
                                    {
                                        Value = "Red paint"
                                    }
                                },
                                Name = "Falu Rödfärg",
                                SellersItemIdentification = new ItemIdentificationType
                                {
                                    ID = "SItemNo001"
                                },
                                StandardItemIdentification = new ItemIdentificationType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeAgencyID = "6",
                                        schemeID = "GTIN",
                                        Value = "1234567890123"
                                    }
                                },
                                AdditionalItemProperty = new ItemPropertyType[]
                                {
                                    new ItemPropertyType
                                    {
                                        Name = "Paint type",
                                        Value = "Acrylic"
                                    },
                                    new ItemPropertyType
                                    {
                                        Name = "Solvant",
                                        Value = "Water"
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
