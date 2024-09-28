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
            Car testSubject = new("123", false);
            //Assert
            Assert.AreEqual(240.0, testSubject.Price());
        }

        [TestMethod()]
        public void CarVehicleTypeTest()
        {
            //Arrange
            Car testSubject = new("123", false);
            //Assert
            Assert.AreEqual("Car", testSubject.VehicleType());
        }

        [TestMethod()]
        public void MCPriceTest()
        {
            MC testSubject = new("123", false);

            Assert.AreEqual(125.0, testSubject.Price());
        }

        [TestMethod()]
        public void MCVehicleTypeTest()
        {
            MC testSubject = new("123", false);

            Assert.AreEqual("MC", testSubject.VehicleType());
        }

        [TestMethod()]
        public void LicensePlateLengthTest()
        {
            //Arrange
            Car testSubject = new("123", false);
            //Act
            testSubject.LicensePlate = "AB12345";
            //Assert
            Assert.AreEqual("AB12345", testSubject.LicensePlate);
        }

        [TestMethod()]
        public void LicensePlateLengthTestException()
        {
            //Arrange
            Car testSubject = new("123", false);
            //Act
            void Act()
            {
                testSubject.LicensePlate = "AB123456789StringThatIsObviouslyTooLong";
            }
            //Assert
            Assert.ThrowsException<ArgumentException>(Act);
        }

        [TestMethod()]
        public void BrobizzPriceIsDifferentTest()
        {
            //Arrange
            Car testSubject1 = new("123", false);
            Car testSubject2 = new("123", true);
            //Assert
            Assert.AreNotEqual(testSubject1.Price(), testSubject2.Price());
        }

        [TestMethod()]
        public void BrobizzPriceIsFivePercentTest()
        {
            MC testSubject = new("123", true);
            double actualPrice = testSubject.Price();
            double expectedPrice = 125 * 0.95;

            Assert.AreEqual(expectedPrice, actualPrice);
        }
    }
}
