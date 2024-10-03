using TicketClassLibrary;

namespace Oresundbron
{
    public class Oresundbron
    {
        private const double priceCar = 410.0;
        private const double priceCarBrobizz = 161.0;
        private const double priceMC = 210.0;
        private const double priceMCBrobizz = 73.0;

        public static double OresundbronPrice(Vehicle v)
        {
            double finalprice = 0.0;
            if (v.TypeOfVehicle == "Car")
            {
                if (v.Brobizz == true)
                    finalprice = priceCarBrobizz;
                else
                    finalprice = priceCar;
            }

            if (v.TypeOfVehicle == "MC")
            {
                if (v.Brobizz == true)
                    finalprice = priceMCBrobizz;
                else
                    finalprice = priceMC;
            }
            return finalprice;
        }

        public string VehicleType(Vehicle v)
        {
            if (v.TypeOfVehicle == "Car")
                return "Oresund car";
            else
                return "Oresund MC";
        }
    }
}
