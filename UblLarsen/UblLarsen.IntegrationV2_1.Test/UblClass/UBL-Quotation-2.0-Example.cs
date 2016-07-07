using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLQuotation20Example
    {
        public static QuotationType Create()
        {
            return new QuotationType
            {
                UBLVersionID = "2.0",
                CustomizationID = "urn:oasis:names:specification:ubl:schema:xsd:Quotation-2-draft",
                ProfileID = "bpid:urn:oasis:names:draft:bpss:ubl-2-sbs-request-for-quotation-draft",
                ID = "QIY7655",
                CopyIndicator = false,
                UUID = "4D07786B-DA6D-439F-82D1-6FFFC7F4E3B1",
                IssueDate = XmlConvert.ToDateTime("2005-06-20", XmlDateTimeSerializationMode.RoundtripKind),
                Note = new TextType[]
                {
                    new TextType
                    {
                        Value = "sample"
                    }
                },
                ValidityPeriod = new PeriodType
                {
                    StartDate = XmlConvert.ToDateTime("2005-06-20", XmlDateTimeSerializationMode.RoundtripKind),
                    EndDate = XmlConvert.ToDateTime("2005-07-20", XmlDateTimeSerializationMode.RoundtripKind)
                },
                RequestForQuotationDocumentReference = new DocumentReferenceType
                {
                    ID = "G867B",
                    UUID = "8D076867-AE6D-439F-8281-5AAFC7F4E3B1",
                    IssueDate = XmlConvert.ToDateTime("2005-06-19", XmlDateTimeSerializationMode.RoundtripKind)
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
                },
                OriginatorCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        PartyName = new PartyNameType[]
                        {
                            new PartyNameType
                            {
                                Name = "The Terminus"
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
                            Name = "S Massiah",
                            Telephone = "0127 98876545",
                            Telefax = "0127 98876546",
                            ElectronicMail = "smassiah@the-email.co.uk"
                        }
                    }
                },
                Delivery = new DeliveryType[]
                {
                    new DeliveryType
                    {
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
                        },
                        RequestedDeliveryPeriod = new PeriodType
                        {
                            StartDate = XmlConvert.ToDateTime("2005-06-29", XmlDateTimeSerializationMode.RoundtripKind),
                            StartTime = "09:30:47.0Z",
                            EndDate = XmlConvert.ToDateTime("2005-06-29", XmlDateTimeSerializationMode.RoundtripKind),
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
                            Value = "1% deduction for late delivery as per contract"
                        }
                    }
                },
                PaymentMeans = new PaymentMeansType
                {
                    PaymentMeansCode = "20",
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
                },
                TransactionConditions = new TransactionConditionsType
                {
                    Description = new TextType[]
                    {
                        new TextType
                        {
                            Value = "order response required; payment is by BACS or by cheque"
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
                DestinationCountry = new CountryType
                {
                    IdentificationCode = "GB",
                    Name = "Great Britain"
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
                        TaxEvidenceIndicator = false,
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
                QuotedMonetaryTotal = new MonetaryTotalType
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
                    PayableAmount = new AmountType
                    {
                        currencyID = "GBP",
                        Value = 107.50M
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
                                Value = "sample"
                            }
                        },
                        LineItem = new LineItemType
                        {
                            ID = "1",
                            Quantity = new QuantityType
                            {
                                unitCode = "KGM",
                                Value = 100M
                            },
                            LineExtensionAmount = new AmountType
                            {
                                currencyID = "GBP",
                                Value = 100.00M
                            },
                            TotalTaxAmount = new AmountType
                            {
                                currencyID = "GBP",
                                Value = 17.50M
                            },
                            Price = new PriceType
                            {
                                PriceAmount = new AmountType
                                {
                                    currencyID = "GBP",
                                    Value = 100.00M
                                },
                                BaseQuantity = new QuantityType
                                {
                                    unitCode = "KGM",
                                    Value = 1M
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
