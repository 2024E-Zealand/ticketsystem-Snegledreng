using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            MC testSubject = new();

            Assert.AreEqual(125.0, testSubject.Price());
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            MC testSubject = new();

            Assert.AreEqual("MC", testSubject.Vehicle());
        }
    }
}