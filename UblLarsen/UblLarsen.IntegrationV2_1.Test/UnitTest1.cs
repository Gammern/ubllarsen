using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using UblLarsen.Ubl2;

namespace UblLarsen.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUBLInvoice21Example()
        {
            string orgFilename = "UBL-Invoice-2.1-Example.xml";
            string genFilename = Path.ChangeExtension(orgFilename, ".generated.xml");
            InvoiceType doc = UblClass.UBLInvoice21Example.Create();
            Tools.UblDoc<InvoiceType>.Save(genFilename, doc);
            bool areEqual = Tools.UblXmlComparer.IsCopyEqual(orgFilename, doc);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }
    }
}
