using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLInvoice20Detached
    {
        public static InvoiceType Create()
        {
            return new InvoiceType
            {
                UBLVersionID = "2.0",
                CustomizationID = "urn:oasis:names:specification:ubl:xpath:Invoice-2.0:sbs-1.0-draft",
                ProfileID = "bpid:urn:oasis:names:draft:bpss:ubl-2-sbs-invoice-notification-draft",
                ID = "A00095678",
                CopyIndicator = false,
                UUID = "849FBBCE-E081-40B4-906C-94C5FF9D1AC3",
                IssueDate = XmlConvert.ToDateTime("2005-06-21", XmlDateTimeSerializationMode.RoundtripKind),
                InvoiceTypeCode = "SalesInvoice",
                Note = new TextType[]
                {
                    new TextType
                    {
                        Value = "sample"
                    }
                },
                TaxPointDate = XmlConvert.ToDateTime("2005-06-21", XmlDateTimeSerializationMode.RoundtripKind),
                OrderReference = new OrderReferenceType
                {
                    ID = "AEG012345",
                    SalesOrderID = "CON0095678",
                    UUID = "6E09886B-DC6E-439F-82D1-7CCAC7F4E3B1",
                    IssueDate = XmlConvert.ToDateTime("2005-06-20", XmlDateTimeSerializationMode.RoundtripKind)
                },
                Signature = new SignatureType[]
                {
                    new SignatureType
                    {
                        ID = "urn:oasis:names:specification:ubl:signature:Invoice",
                        SignatureMethod = "urn:oasis:names:specification:ubl:dsig:detached",
                        SignatoryParty = new PartyType
                        {
                            PartyIdentification = new PartyIdentificationType[]
                            {
                                new PartyIdentificationType
                                {
                                    ID = "MyParty"
                                }
                            }
                        },
                        DigitalSignatureAttachment = new AttachmentType
                        {
                            ExternalReference = new ExternalReferenceType
                            {
                                URI = "UBL-Invoice-2.0-Detached-Signature.xml"
                            }
                        }
                    }
                },
                AccountingSupplierParty = new SupplierPartyType
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
                },
                AccountingCustomerParty = new CustomerPartyType
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
                Delivery = new DeliveryType[]
                {
                    new DeliveryType
                    {
                        ActualDeliveryDate = XmlConvert.ToDateTime("2005-06-20", XmlDateTimeSerializationMode.RoundtripKind),
                        ActualDeliveryTime = "11:30:00.0Z",
                        DeliveryAddress = new AddressType
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
                        }
                    }
                },
                PaymentMeans = new PaymentMeansType[]
                {
                    new PaymentMeansType
                    {
                        PaymentMeansCode = "20",
                        PaymentDueDate = XmlConvert.ToDateTime("2005-07-21", XmlDateTimeSerializationMode.RoundtripKind),
                        PayeeFinancialAccount = new FinancialAccountType
                        {
                            ID = "12345678",
                            Name = "Farthing Purchasing Consortium",
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
                                        CountrySubentity = @"London
",
                                        AddressLine = new AddressLineType[]
                                        {
                                            new AddressLineType
                                            {
                                                Line = "5th Floor"
                                            }
                                        },
                                        Country = new CountryType
                                        {
                                            IdentificationCode = "GB"
                                        }
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
                                    AddressLine = new AddressLineType[]
                                    {
                                        new AddressLineType
                                        {
                                            Line = "West Wing"
                                        }
                                    },
                                    Country = new CountryType
                                    {
                                        IdentificationCode = "GB"
                                    }
                                }
                            },
                            Country = new CountryType
                            {
                                IdentificationCode = "GB"
                            }
                        }
                    }
                },
                PaymentTerms = new PaymentTermsType[]
                {
                    new PaymentTermsType
                    {
                        Note = new TextType[]
                        {
                            new TextType
                            {
                                Value = "Payable within 1 calendar month from the invoice date"
                            }
                        }
                    }
                },
                AllowanceCharge = new AllowanceChargeType[]
                {
                    new AllowanceChargeType
                    {
                        ChargeIndicator = false,
                        AllowanceChargeReasonCode = "17",
                        MultiplierFactorNumeric = 0.10M,
                        Amount = new AmountType
                        {
                            currencyID = "GBP",
                            Value = 10.00M
                        }
                    }
                },
                TaxTotal = new TaxTotalType[]
                {
                    new TaxTotalType
                    {
                        TaxAmount = new AmountType
                        {
                            currencyID = "GBP",
                            Value = 17.50M
                        },
                        TaxEvidenceIndicator = true,
                        TaxSubtotal = new TaxSubtotalType[]
                        {
                            new TaxSubtotalType
                            {
                                TaxableAmount = new AmountType
                                {
                                    currencyID = "GBP",
                                    Value = 100.00M
                                },
                                TaxAmount = new AmountType
                                {
                                    currencyID = "GBP",
                                    Value = 17.50M
                                },
                                TaxCategory = new TaxCategoryType
                                {
                                    ID = "A",
                                    TaxScheme = new TaxSchemeType
                                    {
                                        ID = "UK VAT",
                                        TaxTypeCode = "VAT"
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
                        currencyID = "GBP",
                        Value = 100.00M
                    },
                    TaxExclusiveAmount = new AmountType
                    {
                        currencyID = "GBP",
                        Value = 90.00M
                    },
                    AllowanceTotalAmount = new AmountType
                    {
                        currencyID = "GBP",
                        Value = 10.00M
                    },
                    PayableAmount = new AmountType
                    {
                        currencyID = "GBP",
                        Value = 107.50M
                    }
                },
                InvoiceLine = new InvoiceLineType[]
                {
                    new InvoiceLineType
                    {
                        ID = "A",
                        InvoicedQuantity = new QuantityType
                        {
                            unitCode = "KGM",
                            Value = 100M
                        },
                        LineExtensionAmount = new AmountType
                        {
                            currencyID = "GBP",
                            Value = 100.00M
                        },
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
                                    IssueDate = XmlConvert.ToDateTime("2005-06-20", XmlDateTimeSerializationMode.RoundtripKind)
                                }
                            }
                        },
                        TaxTotal = new TaxTotalType[]
                        {
                            new TaxTotalType
                            {
                                TaxAmount = new AmountType
                                {
                                    currencyID = "GBP",
                                    Value = 17.50M
                                },
                                TaxEvidenceIndicator = true,
                                TaxSubtotal = new TaxSubtotalType[]
                                {
                                    new TaxSubtotalType
                                    {
                                        TaxableAmount = new AmountType
                                        {
                                            currencyID = "GBP",
                                            Value = 100.00M
                                        },
                                        TaxAmount = new AmountType
                                        {
                                            currencyID = "GBP",
                                            Value = 17.50M
                                        },
                                        TaxCategory = new TaxCategoryType
                                        {
                                            ID = "A",
                                            Percent = 17.5M,
                                            TaxScheme = new TaxSchemeType
                                            {
                                                ID = "UK VAT",
                                                TaxTypeCode = "VAT"
                                            }
                                        }
                                    }
                                }
                            }
                        },
                        Item = new ItemType
                        {
                            Description = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "Acme beeswax"
                                }
                            },
                            Name = "beeswax",
                            BuyersItemIdentification = new ItemIdentificationType
                            {
                                ID = "6578489"
                            },
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "17589683"
                            },
                            ItemInstance = new ItemInstanceType[]
                            {
                                new ItemInstanceType
                                {
                                    LotIdentification = new LotIdentificationType
                                    {
                                        LotNumberID = "546378239",
                                        ExpiryDate = XmlConvert.ToDateTime("2010-01-01", XmlDateTimeSerializationMode.RoundtripKind)
                                    }
                                }
                            }
                        },
                        Price = new PriceType
                        {
                            PriceAmount = new AmountType
                            {
                                currencyID = "GBP",
                                Value = 1.00M
                            },
                            BaseQuantity = new QuantityType
                            {
                                unitCode = "KGM",
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
