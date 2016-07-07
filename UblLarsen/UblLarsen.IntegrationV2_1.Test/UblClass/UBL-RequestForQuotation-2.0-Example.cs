using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLRequestForQuotation20Example
    {
        public static RequestForQuotationType Create()
        {
            return new RequestForQuotationType
            {
                UBLVersionID = "2.0",
                CustomizationID = "urn:oasis:names:specification:ubl:xpath:RequestForQuotation-2.0:sbs-1.0-draft",
                ProfileID = "bpid:urn:oasis:names:draft:bpss:ubl-2-sbs-request-for-quotation-draft",
                ID = "G867B",
                CopyIndicator = false,
                UUID = "8D076867-AE6D-439F-8281-5AAFC7F4E3B1",
                IssueDate = XmlConvert.ToDateTime("2005-06-19", XmlDateTimeSerializationMode.RoundtripKind),
                IssueTime = "11:32:26.0Z",
                Note = new TextType[]
                {
                    new TextType
                    {
                        Value = "sample"
                    }
                },
                CatalogueDocumentReference = new DocumentReferenceType
                {
                    ID = "2005-9A",
                    IssueDate = XmlConvert.ToDateTime("2005-11-03", XmlDateTimeSerializationMode.RoundtripKind)
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
                DeliveryTerms = new DeliveryTermsType[]
                {
                    new DeliveryTermsType
                    {
                        SpecialTerms = new TextType[]
                        {
                            new TextType
                            {
                                Value = "1% deduction for late delivery as per contract"
                            }
                        }
                    }
                },
                DestinationCountry = new CountryType
                {
                    IdentificationCode = "GB",
                    Name = "Great Britain"
                },
                Contract = new ContractType[]
                {
                    new ContractType
                    {
                        ContractDocumentReference = new DocumentReferenceType[]
                        {
                            new DocumentReferenceType
                            {
                                ID = "GHJ76849",
                                IssueDate = XmlConvert.ToDateTime("2002-08-13", XmlDateTimeSerializationMode.RoundtripKind)
                            }
                        }
                    }
                },
                RequestForQuotationLine = new RequestForQuotationLineType[]
                {
                    new RequestForQuotationLineType
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
