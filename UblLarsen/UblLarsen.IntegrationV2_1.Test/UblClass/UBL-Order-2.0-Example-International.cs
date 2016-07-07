using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLOrder20ExampleInternational
    {
        public static OrderType Create()
        {
            return new OrderType
            {
                UBLVersionID = "2.0",
                CustomizationID = "urn:oasis:names:specification:ubl:xpath:Order-2.0:samples-2.0-draft",
                ProfileID = "bpid:urn:oasis:names:draft:bpss:ubl-2-sample-international-scenario",
                ID = "AEG012345",
                CopyIndicator = false,
                UUID = "6E09886B-DC6E-439F-82D1-7CCAC7F4E3B1",
                IssueDate = XmlConvert.ToDateTime("2005-06-20", XmlDateTimeSerializationMode.RoundtripKind),
                Note = new TextType[]
                {
                    new TextType
                    {
                        Value = "sample"
                    }
                },
                BuyerCustomerParty = new CustomerPartyType
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
                        Contact = new ContactType
                        {
                            Name = "Mr Fred Churchill",
                            Telephone = "+44 127 2653214",
                            Telefax = "+44 127 2653215",
                            ElectronicMail = "fred@iytcorporation.gov.uk"
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
                            StreetName = "Boston Road",
                            BuildingName = "Suite M-102",
                            BuildingNumber = "630",
                            CityName = "Billerica",
                            PostalZone = "01821",
                            CountrySubentity = "Massachusetts",
                            CountrySubentityCode = "MA",
                            Country = new CountryType
                            {
                                IdentificationCode = "US"
                            }
                        },
                        Contact = new ContactType
                        {
                            Name = "Mrs Bouquet",
                            Telephone = " +1 158 1233714",
                            Telefax = "+ 1 158 1233856",
                            ElectronicMail = "bouquet@fpconsortial.com"
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
                            Telephone = "+ 44 127 98876545",
                            Telefax = "+ 44 127 98876546",
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
                            StartTime = "01:00:00.0Z",
                            EndDate = XmlConvert.ToDateTime("2005-06-30", XmlDateTimeSerializationMode.RoundtripKind),
                            EndTime = "18:00:00.0Z"
                        }
                    }
                },
                DeliveryTerms = new DeliveryTermsType[]
                {
                    new DeliveryTermsType
                    {
                        ID = "FOB Destination",
                        DeliveryLocation = new LocationType
                        {
                            ID = "GBFXT",
                            Description = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "Felixstowe"
                                }
                            }
                        }
                    }
                },
                TransactionConditions = new TransactionConditionsType
                {
                    Description = new TextType[]
                    {
                        new TextType
                        {
                            Value = "Please advise when transport is booked."
                        }
                    }
                },
                AnticipatedMonetaryTotal = new MonetaryTotalType
                {
                    LineExtensionAmount = new AmountType
                    {
                        currencyID = "USD",
                        Value = 1000.00M
                    },
                    PayableAmount = new AmountType
                    {
                        currencyID = "USD",
                        Value = 1000.00M
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
                                Value = "this is an illustrative order line"
                            }
                        },
                        LineItem = new LineItemType
                        {
                            ID = "1",
                            SalesOrderID = "A",
                            LineStatusCode = "NoStatus",
                            Quantity = new QuantityType
                            {
                                unitCode = "KGM",
                                Value = 100M
                            },
                            LineExtensionAmount = new AmountType
                            {
                                currencyID = "USD",
                                Value = 1000.00M
                            },
                            Price = new PriceType
                            {
                                PriceAmount = new AmountType
                                {
                                    currencyID = "USD",
                                    Value = 10.00M
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
                                        Value = "Beeswax"
                                    }
                                },
                                Name = "Acme Beeswax",
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
