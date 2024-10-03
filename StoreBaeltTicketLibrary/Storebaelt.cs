using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public class Storebaelt
    {
        public static double StorebaeltPrice(Vehicle v)
        {
            if (v.TypeOfVehicle != "Car")
                return v.Price();
            if (v.Date.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
                return v.Price() * 0.8;
            return v.Price();
        }
    }
}
