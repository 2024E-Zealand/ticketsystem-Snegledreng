using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{    
    /// <summary>
    /// Ticket for a car.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Constructor for a car ticket.
        /// </summary>
        /// <param name="licensePlate">License plate of the car. Cannot be more than 7 characters.</param>
        /// <param name="brobizz">Whether the car has Brobizz or not.</param>
        public Car(string licenseplate, bool brobizz)
        {
            this.LicensePlate = licenseplate;
            this.Brobizz = brobizz;
            this.Date = DateTime.Now;
            this.PriceForVehicle = 240.0;
            this.TypeOfVehicle = "Car";
        }
    }
}
