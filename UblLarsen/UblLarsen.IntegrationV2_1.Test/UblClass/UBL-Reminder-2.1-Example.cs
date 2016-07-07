using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLReminder21Example
    {
        public static ReminderType Create()
        {
            return new ReminderType
            {
                UBLVersionID = "2.1",
                ID = "12",
                IssueDate = XmlConvert.ToDateTime("2010-04-14", XmlDateTimeSerializationMode.RoundtripKind),
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
                ReminderLine = new ReminderLineType[]
                {
                    new ReminderLineType
                    {
                        ID = "1",
                        BillingReference = new BillingReferenceType[]
                        {
                            new BillingReferenceType
                            {
                                InvoiceDocumentReference = new DocumentReferenceType
                                {
                                    ID = "TOSL108"
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
