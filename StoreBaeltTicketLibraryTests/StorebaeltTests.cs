using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StorebaeltTests
    {
        [TestMethod()]
        public void StorebaeltPriceTest()
        {
            Car testVehicle = new("AB12345", true); 
            StorebaeltPriceTest();
            Assert.Fail();
        }
    }
}