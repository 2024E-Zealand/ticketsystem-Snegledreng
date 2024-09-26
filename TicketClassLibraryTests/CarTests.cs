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
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            Car testSubject = new();

            Assert.AreEqual(240.0, testSubject.Price());
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            Car testSubject = new();

            Assert.AreEqual("Car", testSubject.VehicleType());
        }
    }
}