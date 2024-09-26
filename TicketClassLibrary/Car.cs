using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class Car : Vehicle
    {
        /// <summary>
        /// Function to check the price for a vehicles fare
        /// </summary>
        /// <returns>Double with the price of the fare.</returns>
        public override double Price()
        {
            return 240.0;
        }

        /// <summary>
        /// Function to check the type of vehicle crossing the bridge.
        /// </summary>
        /// <returns>String with description of vehicles type.</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
