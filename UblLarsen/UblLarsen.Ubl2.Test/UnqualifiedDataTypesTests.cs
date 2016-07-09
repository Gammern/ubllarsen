using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UblLarsen.Ubl2.Udt;
using System.Xml;

namespace UblLarsen.Ubl2.Test
{
    [TestClass]
    public class UnqualifiedDataTypesTests
    {
        [TestMethod]
        public void IdentifierTypeNonNullShouldCreateInstance()
        {
            string[] testVals = new[] { "someid", "1" };

            foreach (var val in testVals)
            {
                IdentifierType identifier = val;
                Assert.IsNotNull(identifier);
                Assert.AreEqual(identifier.Value, val);
            }
        }

        [TestMethod]
        public void EmptyIdentifierTypeShouldBeNullOnBlank()
        {
            string[] testVals = new[] { "", string.Empty, null };

            foreach (var val in testVals)
            {
                IdentifierType identifier = val;
                Assert.IsNull(identifier);
            }
        }

        [TestMethod]
        public void IdentifierAssignmentShouldRecreateInstance()
        {
            IdentifierType identifier = new IdentifierType
            {
                Value = "bla",
                schemeID = "id",
            };

            identifier.Value = "newbla";
            Assert.AreEqual(identifier.Value, "newbla");
            Assert.AreEqual(identifier.schemeID, "id");

            identifier = "newbla2";
            Assert.AreEqual(identifier.Value, "newbla2");
            Assert.AreEqual(identifier.schemeID, default(string));
        }

        [TestMethod]
        public void QuantityTypeNonNullShouldCreateInstance()
        {
            decimal[] testVals = { -1, decimal.MaxValue, decimal.MinusOne, decimal.One, decimal.Zero };

            foreach (var val in testVals)
            {
                QuantityType q = val;
                Assert.IsNotNull(q, $"Failed to instantiate QuantityType with value={val}");
                Assert.AreEqual(q.Value, val);
            }
        }

        [TestMethod]
        public void NumericTypeNonNullShouldCreateInstance()
        {
            decimal[] testVals = { -1, decimal.MaxValue, decimal.MinusOne, decimal.One, decimal.Zero };

            foreach (var val in testVals)
            {
                NumericType q = val;
                Assert.IsNotNull(q, $"Failed to instantiate NumericType with value={val}");
                Assert.AreEqual(q.Value, val);
            }
        }

        [TestMethod]
        public void RateTypeNonNullShouldCreateInstance()
        {
            decimal[] testVals = { -1, decimal.MaxValue, decimal.MinusOne, decimal.One, decimal.Zero };

            foreach (var val in testVals)
            {
                RateType q = val;
                Assert.IsNotNull(q, $"Failed to instantiate RateType with value={val}");
                Assert.AreEqual(q.Value, val);
            }
        }

        [TestMethod]
        public void PercentTypeNonNullShouldCreateInstance()
        {
            decimal[] testVals = { -1, decimal.MaxValue, decimal.MinusOne, decimal.One, decimal.Zero };

            foreach (var val in testVals)
            {
                PercentType q = val;
                Assert.IsNotNull(q, $"Failed to instantiate PercentType with value={val}");
                Assert.AreEqual(q.Value, val);
            }
        }

        [TestMethod]
        public void ValueTypeNonNullShouldCreateInstance()
        {
            decimal[] testVals = { -1, decimal.MaxValue, decimal.MinusOne, decimal.One, decimal.Zero };

            foreach (var val in testVals)
            {
                Udt.ValueType q = val;
                Assert.IsNotNull(q, $"Failed to instantiate ValueType with value={val}");
                Assert.AreEqual(q.Value, val);
            }
        }

        [TestMethod]
        public void DateTypeNonNullStringShouldCreateInstance()
        {
            string[] testVals = { "1999-03-27", "2017-12-12" };

            foreach (var val in testVals)
            {
                DateType dt = val;
                Assert.IsNotNull(dt, $"Failed to instantiate DateType with value={val}");
                Assert.AreEqual(dt.Value, DateTime.Parse(val));
            }
        }

        [TestMethod]
        public void DateTypeNonNullDateTimeShouldCreateInstance()
        {
            DateTime[] testVals = { DateTime.Parse("1999-03-27"), DateTime.MinValue, DateTime.MaxValue, DateTime.Now };

            foreach (var val in testVals)
            {
                DateType dt = val;
                Assert.IsNotNull(dt, $"Failed to instantiate DateType with value={val}");
                Assert.AreEqual(dt.Value, val);
            }
        }

        [TestMethod]
        public void TimeTypeNonNullShouldCreateInstance()
        {
            string[] testVals = { "14:20:00.0Z", "12:00:00", "00:00:00", "00:00:00Z" }; // "12:00" fail!

            foreach (var val in testVals)
            {
                DateType dt = val;
                Assert.IsNotNull(dt, $"Failed to instantiate TimeType with value={val}");
                Assert.AreEqual(dt.Value, XmlConvert.ToDateTime(val, XmlDateTimeSerializationMode.RoundtripKind));
            }
        }

        [TestMethod]
        public void IndicatorTypeNonNullShouldCreateInstance()
        {
            bool[] vals = { true, false };
            foreach (var val in vals)
            {
                IndicatorType b = val;
                Assert.IsNotNull(b, $"Failed to instantiate IndicatorType with value={val}");
                Assert.AreEqual(b.Value, val);
            }
        }
    }
}