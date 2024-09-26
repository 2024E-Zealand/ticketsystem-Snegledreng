using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public abstract class Vehicle
    {
        /// <summary>
        /// String containing the license plate of a vehicle.
        /// </summary>
        public string LicensePlate { get; set; }

        /// <summary>
        /// Date of the given fare.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Function to check the price for a vehicles fare
        /// </summary>
        /// <returns>Double with the price of the fare.</returns>
        public virtual double Price()
        {
            return -1;
        }

        /// <summary>
        /// Function to check the type of vehicle crossing the bridge.
        /// </summary>
        /// <returns>String with description of vehicles type.</returns>
        public virtual string VehicleType()
        {
            return "";
        }
    }
}
