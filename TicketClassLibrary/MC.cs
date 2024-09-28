using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// Ticket for a motorcycle.
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Constructor for a motorcycle ticket.
        /// </summary>
        /// <param name="licensePlate">License plate of the motorcycle. Cannot be more than 7 characters.</param>
        /// <param name="brobizz">Whether the motorcycle has Brobizz or not.</param>
        public MC(string licensePlate, bool brobizz)
        {
            this.LicensePlate = licensePlate;
            this.Brobizz = brobizz;
            this.Date = DateTime.Now;
            this.PriceForVehicle = 125.0;
            this.TypeOfVehicle = "MC";
        }
    }
}
