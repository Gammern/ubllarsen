using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLCreditNote21Example
    {
        public static CreditNoteType Create()
        {
            return new CreditNoteType
            {
                UBLVersionID = "2.1",
                ID = "TOSL108",
                IssueDate = XmlConvert.ToDateTime("2009-12-15", XmlDateTimeSerializationMode.RoundtripKind),
                Note = new TextType[]
                {
                    new TextType
                    {
                        languageID = "en",
                        Value = "Ordered in our booth at the convention."
                    }
                },
                DocumentCurrencyCode = new CodeType
                {
                    listID = "ISO 4217 Alpha",
                    listAgencyID = "6",
                    Value = "EUR"
                },
                AccountingCost = "Project cost code 123",
                InvoicePeriod = new PeriodType[]
                {
                    new PeriodType
                    {
                        StartDate = XmlConvert.ToDateTime("2009-11-01", XmlDateTimeSerializationMode.RoundtripKind),
                        EndDate = XmlConvert.ToDateTime("2009-11-30", XmlDateTimeSerializationMode.RoundtripKind)
                    }
                },
                OrderReference = new OrderReferenceType
                {
                    ID = "123"
                },
                ContractDocumentReference = new DocumentReferenceType[]
                {
                    new DocumentReferenceType
                    {
                        ID = "Contract321",
                        DocumentType = "Framework agreement"
                    }
                },
                AdditionalDocumentReference = new DocumentReferenceType[]
                {
                    new DocumentReferenceType
                    {
                        ID = "Doc1",
                        DocumentType = "Timesheet",
                        Attachment = new AttachmentType
                        {
                            ExternalReference = new ExternalReferenceType
                            {
                                URI = "http://www.suppliersite.eu/sheet001.html"
                            }
                        }
                    },
                    new DocumentReferenceType
                    {
                        ID = "Doc2",
                        DocumentType = "Drawing",
                        Attachment = new AttachmentType
                        {
                            EmbeddedDocumentBinaryObject = new BinaryObjectType
                            {
                                mimeCode = "application/pdf",
                                Value = System.Text.Encoding.UTF8.GetBytes("UjBsR09EbGhjZ0dTQUxNQUFBUUNBRU1tQ1p0dU1GUXhEUzhi")
                            }
                        }
                    }
                },
                AccountingSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = new IdentifierType
                        {
                            schemeID = "GLN",
                            schemeAgencyID = "9",
                            Value = "1234567890123"
                        },
                        PartyIdentification = new PartyIdentificationType[]
                        {
                            new PartyIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeID = "ZZZ",
                                    Value = "Supp123"
                                }
                            }
                        },
                        PartyName = new PartyNameType[]
                        {
                            new PartyNameType
                            {
                                Name = "Salescompany ltd."
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            ID = new IdentifierType
                            {
                                schemeID = "GLN",
                                schemeAgencyID = "9",
                                Value = "1231412341324"
                            },
                            Postbox = "5467",
                            StreetName = "Main street",
                            AdditionalStreetName = "Suite 123",
                            BuildingNumber = "1",
                            Department = "Revenue department",
                            CityName = "Big city",
                            PostalZone = "54321",
                            CountrySubentityCode = "RegionA",
                            Country = new CountryType
                            {
                                IdentificationCode = new CodeType
                                {
                                    listID = "ISO3166-1",
                                    listAgencyID = "6",
                                    Value = "DK"
                                }
                            }
                        },
                        PartyTaxScheme = new PartyTaxSchemeType[]
                        {
                            new PartyTaxSchemeType
                            {
                                CompanyID = new IdentifierType
                                {
                                    schemeID = "DKVAT",
                                    schemeAgencyID = "ZZZ",
                                    Value = "DK12345"
                                },
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
                            new PartyLegalEntityType
                            {
                                RegistrationName = "The Sellercompany Incorporated",
                                CompanyID = new IdentifierType
                                {
                                    schemeID = "CVR",
                                    schemeAgencyID = "ZZZ",
                                    Value = "5402697509"
                                },
                                RegistrationAddress = new AddressType
                                {
                                    CityName = "Big city",
                                    CountrySubentity = "RegionA",
                                    Country = new CountryType
                                    {
                                        IdentificationCode = "DK"
                                    }
                                }
                            }
                        },
                        Contact = new ContactType
                        {
                            Telephone = "4621230",
                            Telefax = "4621231",
                            ElectronicMail = "antonio@salescompany.dk"
                        },
                        Person = new PersonType[]
                        {
                            new PersonType
                            {
                                FirstName = "Antonio",
                                FamilyName = "M",
                                MiddleName = "Salemacher",
                                JobTitle = "Sales manager"
                            }
                        }
                    }
                },
                AccountingCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = new IdentifierType
                        {
                            schemeID = "GLN",
                            schemeAgencyID = "9",
                            Value = "1234567987654"
                        },
                        PartyIdentification = new PartyIdentificationType[]
                        {
                            new PartyIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeID = "ZZZ",
                                    Value = "345KS5324"
                                }
                            }
                        },
                        PartyName = new PartyNameType[]
                        {
                            new PartyNameType
                            {
                                Name = "Buyercompany ltd"
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            ID = new IdentifierType
                            {
                                schemeID = "GLN",
                                schemeAgencyID = "9",
                                Value = "1238764941386"
                            },
                            Postbox = "123",
                            StreetName = "Anystreet",
                            AdditionalStreetName = "Back door",
                            BuildingNumber = "8",
                            Department = "Accounting department",
                            CityName = "Anytown",
                            PostalZone = "101",
                            CountrySubentity = "RegionB",
                            Country = new CountryType
                            {
                                IdentificationCode = new CodeType
                                {
                                    listID = "ISO3166-1",
                                    listAgencyID = "6",
                                    Value = "BE"
                                }
                            }
                        },
                        PartyTaxScheme = new PartyTaxSchemeType[]
                        {
                            new PartyTaxSchemeType
                            {
                                CompanyID = new IdentifierType
                                {
                                    schemeID = "BEVAT",
                                    schemeAgencyID = "ZZZ",
                                    Value = "BE54321"
                                },
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
                            new PartyLegalEntityType
                            {
                                RegistrationName = "The buyercompany inc.",
                                CompanyID = new IdentifierType
                                {
                                    schemeAgencyID = "ZZZ",
                                    schemeID = "ZZZ",
                                    Value = "5645342123"
                                },
                                RegistrationAddress = new AddressType
                                {
                                    CityName = "Mainplace",
                                    CountrySubentity = "RegionB",
                                    Country = new CountryType
                                    {
                                        IdentificationCode = "BE"
                                    }
                                }
                            }
                        },
                        Contact = new ContactType
                        {
                            Telephone = "5121230",
                            Telefax = "5121231",
                            ElectronicMail = "john@buyercompany.eu"
                        },
                        Person = new PersonType[]
                        {
                            new PersonType
                            {
                                FirstName = "John",
                                FamilyName = "X",
                                MiddleName = "Doe",
                                JobTitle = "Purchasing manager"
                            }
                        }
                    }
                },
                PayeeParty = new PartyType
                {
                    PartyIdentification = new PartyIdentificationType[]
                    {
                        new PartyIdentificationType
                        {
                            ID = new IdentifierType
                            {
                                schemeID = "GLN",
                                schemeAgencyID = "9",
                                Value = "098740918237"
                            }
                        }
                    },
                    PartyName = new PartyNameType[]
                    {
                        new PartyNameType
                        {
                            Name = "Ebeneser Scrooge Inc."
                        }
                    },
                    PartyLegalEntity = new PartyLegalEntityType[]
                    {
                        new PartyLegalEntityType
                        {
                            CompanyID = new IdentifierType
                            {
                                schemeID = "UK:CH",
                                schemeAgencyID = "ZZZ",
                                Value = "6411982340"
                            }
                        }
                    }
                },
                AllowanceCharge = new AllowanceChargeType[]
                {
                    new AllowanceChargeType
                    {
                        ChargeIndicator = true,
                        AllowanceChargeReason = new TextType[]
                        {
                            new TextType
                            {
                                Value = "Packing cost"
                            }
                        },
                        Amount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = 100M
                        }
                    },
                    new AllowanceChargeType
                    {
                        ChargeIndicator = false,
                        AllowanceChargeReason = new TextType[]
                        {
                            new TextType
                            {
                                Value = "Promotion discount"
                            }
                        },
                        Amount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = 100M
                        }
                    }
                },
                TaxTotal = new TaxTotalType[]
                {
                    new TaxTotalType
                    {
                        TaxAmount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = 292.20M
                        },
                        TaxSubtotal = new TaxSubtotalType[]
                        {
                            new TaxSubtotalType
                            {
                                TaxableAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = 1460.5M
                                },
                                TaxAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = 292.1M
                                },
                                TaxCategory = new TaxCategoryType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeID = "UN/ECE 5305",
                                        schemeAgencyID = "6",
                                        Value = "S"
                                    },
                                    Percent = 20M,
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
                            new TaxSubtotalType
                            {
                                TaxableAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = 1M
                                },
                                TaxAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = 0.1M
                                },
                                TaxCategory = new TaxCategoryType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeID = "UN/ECE 5305",
                                        schemeAgencyID = "6",
                                        Value = "AA"
                                    },
                                    Percent = 10M,
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
                            new TaxSubtotalType
                            {
                                TaxableAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = -25M
                                },
                                TaxAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = 0M
                                },
                                TaxCategory = new TaxCategoryType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeID = "UN/ECE 5305",
                                        schemeAgencyID = "6",
                                        Value = "E"
                                    },
                                    Percent = 0M,
                                    TaxExemptionReasonCode = new CodeType
                                    {
                                        listID = "CWA 15577",
                                        listAgencyID = "ZZZ",
                                        Value = "AAM"
                                    },
                                    TaxExemptionReason = new TextType[]
                                    {
                                        new TextType
                                        {
                                            Value = "Exempt New Means of Transport"
                                        }
                                    },
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
                            }
                        }
                    }
                },
                LegalMonetaryTotal = new MonetaryTotalType
                {
                    LineExtensionAmount = new AmountType
                    {
                        currencyID = "EUR",
                        Value = 1436.5M
                    },
                    TaxExclusiveAmount = new AmountType
                    {
                        currencyID = "EUR",
                        Value = 1436.5M
                    },
                    TaxInclusiveAmount = new AmountType
                    {
                        currencyID = "EUR",
                        Value = 1729M
                    },
                    AllowanceTotalAmount = new AmountType
                    {
                        currencyID = "EUR",
                        Value = 100M
                    },
                    ChargeTotalAmount = new AmountType
                    {
                        currencyID = "EUR",
                        Value = 100M
                    },
                    PrepaidAmount = new AmountType
                    {
                        currencyID = "EUR",
                        Value = 1000M
                    },
                    PayableRoundingAmount = new AmountType
                    {
                        currencyID = "EUR",
                        Value = 0.30M
                    },
                    PayableAmount = new AmountType
                    {
                        currencyID = "EUR",
                        Value = 729M
                    }
                },
                CreditNoteLine = new CreditNoteLineType[]
                {
                    new CreditNoteLineType
                    {
                        ID = "1",
                        Note = new TextType[]
                        {
                            new TextType
                            {
                                Value = "Scratch on box"
                            }
                        },
                        CreditedQuantity = new QuantityType
                        {
                            unitCode = "C62",
                            Value = 1M
                        },
                        LineExtensionAmount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = 1273M
                        },
                        AccountingCost = "BookingCode001",
                        TaxTotal = new TaxTotalType[]
                        {
                            new TaxTotalType
                            {
                                TaxAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = 254.6M
                                }
                            }
                        },
                        Item = new ItemType
                        {
                            Description = new TextType[]
                            {
                                new TextType
                                {
                                    languageID = "EN",
                                    Value = @"Processor: Intel Core 2 Duo SU9400 LV (1.4GHz). RAM:
				3MB. Screen 1440x900"
                                }
                            },
                            Name = "Labtop computer",
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "JB007"
                            },
                            StandardItemIdentification = new ItemIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeID = "GTIN",
                                    schemeAgencyID = "9",
                                    Value = "1234567890124"
                                }
                            },
                            CommodityClassification = new CommodityClassificationType[]
                            {
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listAgencyID = "113",
                                        listID = "UNSPSC",
                                        Value = "12344321"
                                    }
                                },
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listAgencyID = "2",
                                        listID = "CPV",
                                        Value = "65434568"
                                    }
                                }
                            },
                            ClassifiedTaxCategory = new TaxCategoryType[]
                            {
                                new TaxCategoryType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeID = "UN/ECE 5305",
                                        schemeAgencyID = "6",
                                        Value = "S"
                                    },
                                    Percent = 20M,
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
                            AdditionalItemProperty = new ItemPropertyType[]
                            {
                                new ItemPropertyType
                                {
                                    Name = "Color",
                                    Value = "black"
                                }
                            }
                        },
                        Price = new PriceType
                        {
                            PriceAmount = new AmountType
                            {
                                currencyID = "EUR",
                                Value = 1273M
                            },
                            BaseQuantity = new QuantityType
                            {
                                unitCode = "C62",
                                Value = 1M
                            },
                            AllowanceCharge = new AllowanceChargeType[]
                            {
                                new AllowanceChargeType
                                {
                                    ChargeIndicator = false,
                                    AllowanceChargeReason = new TextType[]
                                    {
                                        new TextType
                                        {
                                            Value = "Contract"
                                        }
                                    },
                                    MultiplierFactorNumeric = 0.15M,
                                    Amount = new AmountType
                                    {
                                        currencyID = "EUR",
                                        Value = 225M
                                    },
                                    BaseAmount = new AmountType
                                    {
                                        currencyID = "EUR",
                                        Value = 1500M
                                    }
                                }
                            }
                        }
                    },
                    new CreditNoteLineType
                    {
                        ID = "2",
                        Note = new TextType[]
                        {
                            new TextType
                            {
                                Value = "Cover is slightly damaged."
                            }
                        },
                        CreditedQuantity = new QuantityType
                        {
                            unitCode = "C62",
                            Value = -1M
                        },
                        LineExtensionAmount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = -3.96M
                        },
                        TaxTotal = new TaxTotalType[]
                        {
                            new TaxTotalType
                            {
                                TaxAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = -0.396M
                                }
                            }
                        },
                        Item = new ItemType
                        {
                            Name = "Returned \"Advanced computing\" book",
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "JB008"
                            },
                            StandardItemIdentification = new ItemIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeID = "GTIN",
                                    schemeAgencyID = "9",
                                    Value = "1234567890125"
                                }
                            },
                            CommodityClassification = new CommodityClassificationType[]
                            {
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listAgencyID = "113",
                                        listID = "UNSPSC",
                                        Value = "32344324"
                                    }
                                },
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listAgencyID = "2",
                                        listID = "CPV",
                                        Value = "65434567"
                                    }
                                }
                            },
                            ClassifiedTaxCategory = new TaxCategoryType[]
                            {
                                new TaxCategoryType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeID = "UN/ECE 5305",
                                        schemeAgencyID = "6",
                                        Value = "AA"
                                    },
                                    Percent = 10M,
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
                            }
                        },
                        Price = new PriceType
                        {
                            PriceAmount = new AmountType
                            {
                                currencyID = "EUR",
                                Value = 3.96M
                            },
                            BaseQuantity = new QuantityType
                            {
                                unitCode = "C62",
                                Value = 1M
                            }
                        }
                    },
                    new CreditNoteLineType
                    {
                        ID = "3",
                        CreditedQuantity = new QuantityType
                        {
                            unitCode = "C62",
                            Value = 2M
                        },
                        LineExtensionAmount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = 4.96M
                        },
                        TaxTotal = new TaxTotalType[]
                        {
                            new TaxTotalType
                            {
                                TaxAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = 0.496M
                                }
                            }
                        },
                        Item = new ItemType
                        {
                            Name = "\"Computing for dummies\" book",
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "JB009"
                            },
                            StandardItemIdentification = new ItemIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeID = "GTIN",
                                    schemeAgencyID = "9",
                                    Value = "1234567890126"
                                }
                            },
                            CommodityClassification = new CommodityClassificationType[]
                            {
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listAgencyID = "113",
                                        listID = "UNSPSC",
                                        Value = "32344324"
                                    }
                                },
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listAgencyID = "2",
                                        listID = "CPV",
                                        Value = "65434566"
                                    }
                                }
                            },
                            ClassifiedTaxCategory = new TaxCategoryType[]
                            {
                                new TaxCategoryType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeID = "UN/ECE 5305",
                                        schemeAgencyID = "6",
                                        Value = "AA"
                                    },
                                    Percent = 10M,
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
                            }
                        },
                        Price = new PriceType
                        {
                            PriceAmount = new AmountType
                            {
                                currencyID = "EUR",
                                Value = 2.48M
                            },
                            BaseQuantity = new QuantityType
                            {
                                unitCode = "C62",
                                Value = 1M
                            },
                            AllowanceCharge = new AllowanceChargeType[]
                            {
                                new AllowanceChargeType
                                {
                                    ChargeIndicator = false,
                                    AllowanceChargeReason = new TextType[]
                                    {
                                        new TextType
                                        {
                                            Value = "Contract"
                                        }
                                    },
                                    MultiplierFactorNumeric = 0.1M,
                                    Amount = new AmountType
                                    {
                                        currencyID = "EUR",
                                        Value = 0.275M
                                    },
                                    BaseAmount = new AmountType
                                    {
                                        currencyID = "EUR",
                                        Value = 2.75M
                                    }
                                }
                            }
                        }
                    },
                    new CreditNoteLineType
                    {
                        ID = "4",
                        CreditedQuantity = new QuantityType
                        {
                            unitCode = "C62",
                            Value = -1M
                        },
                        LineExtensionAmount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = -25M
                        },
                        TaxTotal = new TaxTotalType[]
                        {
                            new TaxTotalType
                            {
                                TaxAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = 0M
                                }
                            }
                        },
                        Item = new ItemType
                        {
                            Name = "Returned IBM 5150 desktop",
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "JB010"
                            },
                            StandardItemIdentification = new ItemIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeID = "GTIN",
                                    schemeAgencyID = "9",
                                    Value = "1234567890127"
                                }
                            },
                            CommodityClassification = new CommodityClassificationType[]
                            {
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listAgencyID = "113",
                                        listID = "UNSPSC",
                                        Value = "12344322"
                                    }
                                },
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listAgencyID = "2",
                                        listID = "CPV",
                                        Value = "65434565"
                                    }
                                }
                            },
                            ClassifiedTaxCategory = new TaxCategoryType[]
                            {
                                new TaxCategoryType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeID = "UN/ECE 5305",
                                        schemeAgencyID = "6",
                                        Value = "E"
                                    },
                                    Percent = 0M,
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
                            }
                        },
                        Price = new PriceType
                        {
                            PriceAmount = new AmountType
                            {
                                currencyID = "EUR",
                                Value = 25M
                            },
                            BaseQuantity = new QuantityType
                            {
                                unitCode = "C62",
                                Value = 1M
                            }
                        }
                    },
                    new CreditNoteLineType
                    {
                        ID = "5",
                        CreditedQuantity = new QuantityType
                        {
                            unitCode = "C62",
                            Value = 250M
                        },
                        LineExtensionAmount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = 187.5M
                        },
                        AccountingCost = "BookingCode002",
                        TaxTotal = new TaxTotalType[]
                        {
                            new TaxTotalType
                            {
                                TaxAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = 37.5M
                                }
                            }
                        },
                        Item = new ItemType
                        {
                            Name = "Network cable",
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "JB011"
                            },
                            StandardItemIdentification = new ItemIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeID = "GTIN",
                                    schemeAgencyID = "9",
                                    Value = "1234567890128"
                                }
                            },
                            CommodityClassification = new CommodityClassificationType[]
                            {
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listAgencyID = "113",
                                        listID = "UNSPSC",
                                        Value = "12344325"
                                    }
                                },
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listAgencyID = "2",
                                        listID = "CPV",
                                        Value = "65434564"
                                    }
                                }
                            },
                            ClassifiedTaxCategory = new TaxCategoryType[]
                            {
                                new TaxCategoryType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeID = "UN/ECE 5305",
                                        schemeAgencyID = "6",
                                        Value = "S"
                                    },
                                    Percent = 20M,
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
                            AdditionalItemProperty = new ItemPropertyType[]
                            {
                                new ItemPropertyType
                                {
                                    Name = "Type",
                                    Value = "Cat5"
                                }
                            }
                        },
                        Price = new PriceType
                        {
                            PriceAmount = new AmountType
                            {
                                currencyID = "EUR",
                                Value = 0.75M
                            },
                            BaseQuantity = new QuantityType
                            {
                                unitCode = "C62",
                                Value = 1M
                            }
                        }
                    }
                }
            }
;
        }
    }
}
