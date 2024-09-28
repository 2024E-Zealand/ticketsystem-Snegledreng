using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public abstract class Vehicle
    {
        private string _licensePlate;
        private DateTime _date;
        private bool _brobizz;
        private double _priceForVehicle;
        private string _typeOfVehicle;

        /// <summary>
        /// String containing the license plate of a vehicle. Must not be longer than 7 characters.
        /// </summary>
        public string LicensePlate
        {
            get => _licensePlate;
            set
            {
                if (value.Length <= 7)
                {
                    _licensePlate = value;
                }
                else
                {
                    throw new ArgumentException("License plate too long. Must be 7 characters or less.", value);
                }
            }
        }

        /// <summary>
        /// Date of the given fare.
        /// </summary>
        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }

        /// <summary>
        /// Whether a vehicle has Brobizz or not.
        /// </summary>
        public bool Brobizz
        {
            get => _brobizz;
            set => _brobizz = value;
        }

        public double PriceForVehicle
        {
            get => _priceForVehicle;
            set => _priceForVehicle = value;
        }

        public string TypeOfVehicle
        {
            get => _typeOfVehicle;
            set => _typeOfVehicle = value;
        }

        /// <summary>
        /// Function to check the price for a vehicles fare
        /// </summary>
        /// <returns>Double with the price of the fare.</returns>
        public double Price()
        {
            if (Brobizz == true)
                return PriceForVehicle * 0.95;
            else
                return PriceForVehicle;
        }

        /// <summary>
        /// Function to check the type of vehicle crossing the bridge.
        /// </summary>
        /// <returns>String with description of vehicles type.</returns>
        public string VehicleType()
        {
            return this.TypeOfVehicle;
        }
    }
}
