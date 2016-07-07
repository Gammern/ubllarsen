using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLRemittanceAdvice20Example
    {
        public static RemittanceAdviceType Create()
        {
            return new RemittanceAdviceType
            {
                UBLVersionID = "2.0",
                CustomizationID = "urn:oasis:names:specification:ubl:xpath:RemittanceAdvice-2.0:sbs-1.0-draft",
                ProfileID = "bpid:urn:oasis:names:draft:bpss:ubl-2-sbs-remittance-advice-notification-draft",
                ID = "6577884",
                CopyIndicator = false,
                UUID = "84E081CE-F9D1-94C5-40F9-94C5FF9D1AC3",
                IssueDate = XmlConvert.ToDateTime("2005-06-22", XmlDateTimeSerializationMode.RoundtripKind),
                Note = new TextType[]
                {
                    new TextType
                    {
                        Value = "dummy as sample"
                    }
                },
                TotalDebitAmount = new AmountType
                {
                    currencyID = "GBP",
                    Value = 107.50M
                },
                TotalCreditAmount = new AmountType
                {
                    currencyID = "GBP",
                    Value = 0.00M
                },
                TotalPaymentAmount = new AmountType
                {
                    currencyID = "GBP",
                    Value = 107.50M
                },
                InvoicePeriod = new PeriodType[]
                {
                    new PeriodType
                    {
                        StartDate = XmlConvert.ToDateTime("2005-06-01", XmlDateTimeSerializationMode.RoundtripKind),
                        EndDate = XmlConvert.ToDateTime("2005-07-01", XmlDateTimeSerializationMode.RoundtripKind)
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
                PayeeParty = new PartyType
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
                },
                PaymentMeans = new PaymentMeansType
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
                },
                RemittanceAdviceLine = new RemittanceAdviceLineType[]
                {
                    new RemittanceAdviceLineType
                    {
                        ID = "1",
                        Note = new TextType[]
                        {
                            new TextType
                            {
                                Value = "please note that local offices will close for recess for the next three weeks - please send their invoices to central offices for that time"
                            }
                        },
                        DebitLineAmount = new AmountType
                        {
                            currencyID = "GBP",
                            Value = 107.50M
                        },
                        CreditLineAmount = new AmountType
                        {
                            currencyID = "GBP",
                            Value = 0.00M
                        },
                        BalanceAmount = new AmountType
                        {
                            currencyID = "GBP",
                            Value = 107.50M
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
                        BillingReference = new BillingReferenceType[]
                        {
                            new BillingReferenceType
                            {
                                InvoiceDocumentReference = new DocumentReferenceType
                                {
                                    ID = "A00095678",
                                    UUID = "849FBBCE-E081-40B4-906C-94C5FF9D1AC3",
                                    IssueDate = XmlConvert.ToDateTime("2005-06-21", XmlDateTimeSerializationMode.RoundtripKind)
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
