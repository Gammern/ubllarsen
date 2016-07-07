using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLStatement20Example
    {
        public static StatementType Create()
        {
            return new StatementType
            {
                UBLVersionID = "2.0",
                CustomizationID = "urn:oasis:names:specification:ubl:xpath:Statement-2.0:sbs-1.0-draft",
                ProfileID = "bpid:urn:oasis:names:draft:bpss:ubl-2-sbs-statement-notification-draft",
                ID = "JUL2005-07758990",
                CopyIndicator = false,
                UUID = "normalizedString",
                IssueDate = XmlConvert.ToDateTime("2005-08-02", XmlDateTimeSerializationMode.RoundtripKind),
                Note = new TextType[]
                {
                    new TextType
                    {
                        Value = "please present invoice if this credit amount cannot be taken against a forthcoming payment"
                    }
                },
                DocumentCurrencyCode = "GBP",
                TotalDebitAmount = new AmountType
                {
                    currencyID = "GBP",
                    Value = 0.00M
                },
                TotalCreditAmount = new AmountType
                {
                    currencyID = "GBP",
                    Value = 107.50M
                },
                TotalBalanceAmount = new AmountType
                {
                    currencyID = "GBP",
                    Value = -107.50M
                },
                StatementPeriod = new PeriodType
                {
                    StartDate = XmlConvert.ToDateTime("2005-07-01", XmlDateTimeSerializationMode.RoundtripKind),
                    EndDate = XmlConvert.ToDateTime("2005-07-31", XmlDateTimeSerializationMode.RoundtripKind),
                    Description = new TextType[]
                    {
                        new TextType
                        {
                            Value = "July"
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
                                Value = "Payment due immediately"
                            }
                        }
                    }
                },
                StatementLine = new StatementLineType[]
                {
                    new StatementLineType
                    {
                        ID = "normalizedString",
                        Note = new TextType[]
                        {
                            new TextType
                            {
                                Value = "String"
                            }
                        },
                        BalanceBroughtForwardIndicator = false,
                        DebitLineAmount = new AmountType
                        {
                            currencyID = "GBP",
                            Value = 0.00M
                        },
                        CreditLineAmount = new AmountType
                        {
                            currencyID = "GBP",
                            Value = 107.50M
                        },
                        BalanceAmount = new AmountType
                        {
                            currencyID = "GBP",
                            Value = -107.50M
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
                                CreditNoteDocumentReference = new DocumentReferenceType
                                {
                                    ID = "CN758494",
                                    UUID = "349ABBAE-DF9D-40B4-849F-94C5FF9D1AF4",
                                    IssueDate = XmlConvert.ToDateTime("2005-06-25", XmlDateTimeSerializationMode.RoundtripKind)
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
