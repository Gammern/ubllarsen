using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLInvoice21ExampleTrivial
    {
        public static InvoiceType Create()
        {
            return new InvoiceType
            {
                ID = "123",
                IssueDate = XmlConvert.ToDateTime("2011-09-22", XmlDateTimeSerializationMode.RoundtripKind),
                InvoicePeriod = new PeriodType[]
                {
                    new PeriodType
                    {
                        StartDate = XmlConvert.ToDateTime("2011-08-01", XmlDateTimeSerializationMode.RoundtripKind),
                        EndDate = XmlConvert.ToDateTime("2011-08-31", XmlDateTimeSerializationMode.RoundtripKind)
                    }
                },
                AccountingSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        PartyName = new PartyNameType[]
                        {
                            new PartyNameType
                            {
                                Name = "Custom Cotter Pins"
                            }
                        }
                    }
                },
                AccountingCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        PartyName = new PartyNameType[]
                        {
                            new PartyNameType
                            {
                                Name = "North American Veeblefetzer"
                            }
                        }
                    }
                },
                LegalMonetaryTotal = new MonetaryTotalType
                {
                    PayableAmount = new AmountType
                    {
                        currencyID = "CAD",
                        Value = 100.00M
                    }
                },
                InvoiceLine = new InvoiceLineType[]
                {
                    new InvoiceLineType
                    {
                        ID = "1",
                        LineExtensionAmount = new AmountType
                        {
                            currencyID = "CAD",
                            Value = 100.00M
                        },
                        Item = new ItemType
                        {
                            Description = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "Cotter pin, MIL-SPEC"
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
