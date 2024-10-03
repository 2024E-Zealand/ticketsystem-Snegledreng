using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public class TicketsRepo
    {
        public TicketsRepo()
        {
            _vehicles = new List<Vehicle>();
        }

        private List<Vehicle> _vehicles;
        public void Add(Vehicle v) => _vehicles.Add(v);
        public List<Vehicle> GetAll() => _vehicles;

        public List<Vehicle> GetByLicensePlate(string licenseplate)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            foreach (Vehicle v in _vehicles)
            {
                if (licenseplate == v.LicensePlate)
                {
                    vehicles.Add(v);
                }
            }

            return vehicles;
        }
    }
}
