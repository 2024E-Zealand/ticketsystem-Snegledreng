using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace TicketClassLibraryTests
{
    [TestClass()]
    public class VehicleTests
    {
        [TestMethod()]
        public void CarPriceTest()
        {
            //Arrange
            Car testSubject = new();
            //Assert
            Assert.AreEqual(240.0, testSubject.Price());
        }

        [TestMethod()]
        public void CarVehicleTypeTest()
        {
            //Arrange
            Car testSubject = new();
            //Assert
            Assert.AreEqual("Car", testSubject.VehicleType());
        }

        [TestMethod()]
        public void MCPriceTest()
        {
            MC testSubject = new();

            Assert.AreEqual(125.0, testSubject.Price());
        }

        [TestMethod()]
        public void MCVehicleTypeTest()
        {
            MC testSubject = new();

            Assert.AreEqual("MC", testSubject.VehicleType());
        }

        [TestMethod()]
        public void LicensePlateLengthTest()
        {
            //Arrange
            Car testSubject = new();
            //Act
            testSubject.LicensePlate = "AB12345";
            //Assert
            Assert.AreEqual("AB12345", testSubject.LicensePlate);
        }

        [TestMethod()]
        public void LicensePlateLengthTestException()
        {
            //Arrange
            Car testSubject = new();
            //Act
            void Act()
            {
                testSubject.LicensePlate = "AB123456789StringThatIsObviouslyTooLong";
            }
            //Assert
            Assert.ThrowsException<ArgumentException>(Act);
        }
    }
}
