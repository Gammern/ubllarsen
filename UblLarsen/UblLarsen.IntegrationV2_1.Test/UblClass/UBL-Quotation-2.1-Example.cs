using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLQuotation21Example
    {
        public static QuotationType Create()
        {
            return new QuotationType
            {
                UBLVersionID = "2.0",
                CustomizationID = "OIOUBL-2.1",
                ProfileID = new IdentifierType
                {
                    schemeAgencyID = "320",
                    schemeID = "urn:oioubl:id:profileid-1.2",
                    Value = "Procurement-QuoSim-1.0"
                },
                ID = "QIY7655",
                CopyIndicator = false,
                UUID = "4D07786B-DA6D-439F-82D1-6FFFC7F4E3B1",
                IssueDate = XmlConvert.ToDateTime("2008-05-01", XmlDateTimeSerializationMode.RoundtripKind),
                IssueTime = "11:32:26.0Z",
                Note = new TextType[]
                {
                    new TextType
                    {
                        languageID = "da-dk",
                        Value = "Bestilling af computere"
                    }
                },
                ValidityPeriod = new PeriodType
                {
                    StartDate = XmlConvert.ToDateTime("2008-05-01", XmlDateTimeSerializationMode.RoundtripKind),
                    EndDate = XmlConvert.ToDateTime("2008-05-06", XmlDateTimeSerializationMode.RoundtripKind)
                },
                RequestForQuotationDocumentReference = new DocumentReferenceType
                {
                    ID = "G867B",
                    UUID = "93T5G3G5-HYA3-7267-BVG3-GS46SW44WG53",
                    IssueDate = XmlConvert.ToDateTime("2008-04-19", XmlDateTimeSerializationMode.RoundtripKind)
                },
                SellerSupplierParty = new SupplierPartyType
                {
                    CustomerAssignedAccountID = "LEV00123",
                    Party = new PartyType
                    {
                        EndpointID = new IdentifierType
                        {
                            schemeID = "DK:CVR",
                            Value = "DK18296799"
                        },
                        PartyIdentification = new PartyIdentificationType[]
                        {
                            new PartyIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeID = "DK:CVR",
                                    Value = "DK18296799"
                                }
                            }
                        },
                        PartyName = new PartyNameType[]
                        {
                            new PartyNameType
                            {
                                Name = "Delcomputer A/S"
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            AddressFormatCode = new CodeType
                            {
                                listAgencyID = "320",
                                listID = "urn:oioubl:codelist:addressformatcode-1.1",
                                Value = "StructuredDK"
                            },
                            StreetName = "Arne Jacobsens Allé",
                            BuildingNumber = "15",
                            CityName = "København S",
                            PostalZone = "2300",
                            Country = new CountryType
                            {
                                IdentificationCode = "DK"
                            }
                        },
                        PartyTaxScheme = new PartyTaxSchemeType[]
                        {
                            new PartyTaxSchemeType
                            {
                                CompanyID = new IdentifierType
                                {
                                    schemeID = "DK:SE",
                                    Value = "DK18296799"
                                },
                                TaxScheme = new TaxSchemeType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeAgencyID = "320",
                                        schemeID = "urn:oioubl:id:taxschemeid-1.1",
                                        Value = "63"
                                    },
                                    Name = "Moms"
                                }
                            }
                        },
                        PartyLegalEntity = new PartyLegalEntityType[]
                        {
                            new PartyLegalEntityType
                            {
                                RegistrationName = "Delcomputer A/S",
                                CompanyID = new IdentifierType
                                {
                                    schemeID = "DK:CVR",
                                    Value = "18296799"
                                }
                            }
                        }
                    }
                },
                OriginatorCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = new IdentifierType
                        {
                            schemeAgencyID = "9",
                            schemeID = "GLN",
                            Value = "5798000416604"
                        },
                        PartyIdentification = new PartyIdentificationType[]
                        {
                            new PartyIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeAgencyID = "9",
                                    schemeID = "GLN",
                                    Value = "5798000416604"
                                }
                            }
                        },
                        PartyName = new PartyNameType[]
                        {
                            new PartyNameType
                            {
                                Name = "Gentofte Kommune"
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            AddressFormatCode = new CodeType
                            {
                                listAgencyID = "320",
                                listID = "urn:oioubl:codelist:addressformatcode-1.1",
                                Value = "StructuredDK"
                            },
                            StreetName = "Bernstorffsvej",
                            BuildingNumber = "161",
                            CityName = "Charlottenlund",
                            PostalZone = "2920",
                            Country = new CountryType
                            {
                                IdentificationCode = "DK"
                            }
                        },
                        PartyTaxScheme = new PartyTaxSchemeType[]
                        {
                            new PartyTaxSchemeType
                            {
                                CompanyID = new IdentifierType
                                {
                                    schemeID = "DK:SE",
                                    Value = "DK12345678"
                                },
                                TaxScheme = new TaxSchemeType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeAgencyID = "320",
                                        schemeID = "urn:oioubl:id:taxschemeid-1.1",
                                        Value = "63"
                                    },
                                    Name = "Moms"
                                }
                            }
                        },
                        PartyLegalEntity = new PartyLegalEntityType[]
                        {
                            new PartyLegalEntityType
                            {
                                RegistrationName = "Gentofte Kommune",
                                CompanyID = new IdentifierType
                                {
                                    schemeID = "DK:CVR",
                                    Value = "DK12345678"
                                }
                            }
                        },
                        Contact = new ContactType
                        {
                            ID = "12345678",
                            Name = "Sille Schyberg"
                        }
                    }
                },
                Delivery = new DeliveryType[]
                {
                    new DeliveryType
                    {
                        DeliveryAddress = new AddressType
                        {
                            AddressFormatCode = new CodeType
                            {
                                listAgencyID = "320",
                                listID = "urn:oioubl:codelist:addressformatcode-1.1",
                                Value = "StructuredDK"
                            },
                            StreetName = "Bernstorffsvej",
                            BuildingNumber = "161",
                            CityName = "Charlottenlund",
                            PostalZone = "2920",
                            AddressLine = new AddressLineType[]
                            {
                                new AddressLineType
                                {
                                    Line = "IT-afdelingen"
                                },
                                new AddressLineType
                                {
                                    Line = "1. sal"
                                }
                            },
                            Country = new CountryType
                            {
                                IdentificationCode = "DK"
                            }
                        },
                        RequestedDeliveryPeriod = new PeriodType
                        {
                            StartDate = XmlConvert.ToDateTime("2008-05-06", XmlDateTimeSerializationMode.RoundtripKind),
                            StartTime = "09:30:47.0Z",
                            EndDate = XmlConvert.ToDateTime("2008-05-10", XmlDateTimeSerializationMode.RoundtripKind),
                            EndTime = "09:30:47.0Z"
                        }
                    }
                },
                DeliveryTerms = new DeliveryTermsType
                {
                    SpecialTerms = new TextType[]
                    {
                        new TextType
                        {
                            Value = "1% reduktion i kontraktsummen pr. dags forsinkelse jf. SKI kontrakt"
                        }
                    }
                },
                QuotedMonetaryTotal = new MonetaryTotalType
                {
                    LineExtensionAmount = new AmountType
                    {
                        currencyID = "DKK",
                        Value = 197750.00M
                    },
                    TaxExclusiveAmount = new AmountType
                    {
                        currencyID = "DKK",
                        Value = 49437.50M
                    },
                    TaxInclusiveAmount = new AmountType
                    {
                        currencyID = "DKK",
                        Value = 247187.50M
                    },
                    PayableAmount = new AmountType
                    {
                        currencyID = "DKK",
                        Value = 247187.50M
                    }
                },
                QuotationLine = new QuotationLineType[]
                {
                    new QuotationLineType
                    {
                        ID = "1",
                        Note = new TextType[]
                        {
                            new TextType
                            {
                                Value = "Computer"
                            }
                        },
                        LineItem = new LineItemType
                        {
                            ID = "DELL1052665",
                            Quantity = new QuantityType
                            {
                                unitCode = "EA",
                                Value = 35M
                            },
                            LineExtensionAmount = new AmountType
                            {
                                currencyID = "DKK",
                                Value = 150500.00M
                            },
                            TotalTaxAmount = new AmountType
                            {
                                currencyID = "DKK",
                                Value = 37625.00M
                            },
                            Price = new PriceType
                            {
                                PriceAmount = new AmountType
                                {
                                    currencyID = "DKK",
                                    Value = 4300.00M
                                },
                                BaseQuantity = new QuantityType
                                {
                                    unitCode = "EA",
                                    Value = 1M
                                }
                            },
                            Item = new ItemType
                            {
                                Description = new TextType[]
                                {
                                    new TextType
                                    {
                                        Value = "Stationær computer"
                                    }
                                },
                                Name = "Dell PrecisionTM  T3400"
                            }
                        }
                    },
                    new QuotationLineType
                    {
                        ID = "2",
                        Note = new TextType[]
                        {
                            new TextType
                            {
                                Value = "Skærm"
                            }
                        },
                        LineItem = new LineItemType
                        {
                            ID = "DELL2363463",
                            Quantity = new QuantityType
                            {
                                unitCode = "EA",
                                Value = 35M
                            },
                            LineExtensionAmount = new AmountType
                            {
                                currencyID = "DKK",
                                Value = 43750.00M
                            },
                            TotalTaxAmount = new AmountType
                            {
                                currencyID = "DKK",
                                Value = 10937.50M
                            },
                            Price = new PriceType
                            {
                                PriceAmount = new AmountType
                                {
                                    currencyID = "DKK",
                                    Value = 1250.00M
                                },
                                BaseQuantity = new QuantityType
                                {
                                    unitCode = "EA",
                                    Value = 1M
                                }
                            },
                            Item = new ItemType
                            {
                                Description = new TextType[]
                                {
                                    new TextType
                                    {
                                        Value = "Fladskærm"
                                    }
                                },
                                Name = "FP/BL 1908WFP"
                            }
                        }
                    },
                    new QuotationLineType
                    {
                        ID = "3",
                        Note = new TextType[]
                        {
                            new TextType
                            {
                                Value = "Mus"
                            }
                        },
                        LineItem = new LineItemType
                        {
                            ID = "DELL2367452",
                            Quantity = new QuantityType
                            {
                                unitCode = "EA",
                                Value = 35M
                            },
                            LineExtensionAmount = new AmountType
                            {
                                currencyID = "DKK",
                                Value = 1750.00M
                            },
                            TotalTaxAmount = new AmountType
                            {
                                currencyID = "DKK",
                                Value = 437.50M
                            },
                            Price = new PriceType
                            {
                                PriceAmount = new AmountType
                                {
                                    currencyID = "DKK",
                                    Value = 50.00M
                                },
                                BaseQuantity = new QuantityType
                                {
                                    unitCode = "EA",
                                    Value = 1M
                                }
                            },
                            Item = new ItemType
                            {
                                Description = new TextType[]
                                {
                                    new TextType
                                    {
                                        Value = "Mus"
                                    }
                                },
                                Name = "Dell Quietkey USB-tastatur, sort - Dansk (QWERTY)"
                            }
                        }
                    },
                    new QuotationLineType
                    {
                        ID = "4",
                        Note = new TextType[]
                        {
                            new TextType
                            {
                                Value = "Tastatur"
                            }
                        },
                        LineItem = new LineItemType
                        {
                            ID = "DELL8436783",
                            Quantity = new QuantityType
                            {
                                unitCode = "EA",
                                Value = 35M
                            },
                            LineExtensionAmount = new AmountType
                            {
                                currencyID = "DKK",
                                Value = 1750.00M
                            },
                            TotalTaxAmount = new AmountType
                            {
                                currencyID = "DKK",
                                Value = 437.50M
                            },
                            Price = new PriceType
                            {
                                PriceAmount = new AmountType
                                {
                                    currencyID = "DKK",
                                    Value = 50.00M
                                },
                                BaseQuantity = new QuantityType
                                {
                                    unitCode = "EA",
                                    Value = 1M
                                }
                            },
                            Item = new ItemType
                            {
                                Description = new TextType[]
                                {
                                    new TextType
                                    {
                                        Value = "Tastatur"
                                    }
                                },
                                Name = "Dell Quietkey USB-tastatur, sort - Dansk (QWERTY)"
                            }
                        }
                    }
                }
            }
;
        }
    }
}
