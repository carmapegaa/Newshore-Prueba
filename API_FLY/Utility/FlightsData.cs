using API_FLY.Models;

namespace Api_Flights.Utility
{
    public class FlightsData
    {
        public static List<API> GetFlightsData0()
        { 
        List<API> list = new List<API>();
            API data = new API();
            data.DepartureStation = "MZL";
            data.ArrivalStation = "BOG";
            data.FlightCarrier = "AV";
            data.FlightNumber = "8001";
            data.Price = 150;
            list.Add(data);

            data = new API();
            data.DepartureStation = "BCN";
            data.ArrivalStation = "BOG";
            data.FlightCarrier = "AV";
            data.FlightNumber = "8002";
            data.Price = 900;
            list.Add(data);

            data = new API();
            data.DepartureStation = "MIA";
            data.ArrivalStation = "BOG";
            data.FlightCarrier = "AV";
            data.FlightNumber = "8003";
            data.Price = 600;
            list.Add(data);

            return list;

        }

        public static List<API> GetFlightsData1()
        {
            List<API> list = new List<API>();
            API data = new API();
            data.DepartureStation = "MZL";
            data.ArrivalStation = "BOG";
            data.FlightCarrier = "AV";
            data.FlightNumber = "8001";
            data.Price = 150;
            list.Add(data);

            data = new API();
            data.DepartureStation = "BOG";
            data.ArrivalStation = "BCN";
            data.FlightCarrier = "IBE";
            data.FlightNumber = "8002";
            data.Price = 900;
            list.Add(data);

            data = new API();
            data.DepartureStation = "BOG";
            data.ArrivalStation = "MIA";
            data.FlightCarrier = "AV";
            data.FlightNumber = "8003";
            data.Price = 600;
            list.Add(data);

            data = new API();
            data.DepartureStation = "BOG";
            data.ArrivalStation = "NYC";
            data.FlightCarrier = "LAT";
            data.FlightNumber = "8004";
            data.Price = 1200;
            list.Add(data);

            data = new API();
            data.DepartureStation = "SAO";
            data.ArrivalStation = "SCL";
            data.FlightCarrier = "IBE";
            data.FlightNumber = "8005";
            data.Price = 1600;
            list.Add(data);

            data = new API();
            data.DepartureStation = "MIA";
            data.ArrivalStation = "LIM";
            data.FlightCarrier = "LAT";
            data.FlightNumber = "8006";
            data.Price = 1100;
            list.Add(data);

            data = new API();
            data.DepartureStation = "BOG";
            data.ArrivalStation = "SAO";
            data.FlightCarrier = "LAT";
            data.FlightNumber = "8007";
            data.Price = 1500;
            list.Add(data);

            return list;
        }

        public static List<API> GetFlightsData2()
        {
            List<API> list = new List<API>();
            API data = new API();
            data.DepartureStation = "MZL";
            data.ArrivalStation = "BOG";
            data.FlightCarrier = "AV";
            data.FlightNumber = "8001";
            data.Price = 150;
            list.Add(data);

            data = new API();
            data.DepartureStation = "BOG";
            data.ArrivalStation = "BCN";
            data.FlightCarrier = "IBE";
            data.FlightNumber = "8002";
            data.Price = 900;
            list.Add(data);


            data = new API();
            data.DepartureStation = "BOG";
            data.ArrivalStation = "MIA";
            data.FlightCarrier = "AV";
            data.FlightNumber = "8003";
            data.Price = 600;
            list.Add(data);

            data = new API();
            data.DepartureStation = "BOG";
            data.ArrivalStation = "NYC";
            data.FlightCarrier = "IBE";
            data.FlightNumber = "8002";
            data.Price = 1200;
            list.Add(data);

            data = new API();
            data.DepartureStation = "BOG";
            data.ArrivalStation = "MZL";
            data.FlightCarrier = "AV";
            data.FlightNumber = "8001";
            data.Price = 150;
            list.Add(data);

            data = new API();
            data.DepartureStation = "BCN";
            data.ArrivalStation = "BOG";
            data.FlightCarrier = "IBE";
            data.FlightNumber = "8002";
            data.Price = 1000;
            list.Add(data);


            data = new API();
            data.DepartureStation = "MIA";
            data.ArrivalStation = "BOG";
            data.FlightCarrier = "AV";
            data.FlightNumber = "8003";
            data.Price = 800;
            list.Add(data);

            data = new API();
            data.DepartureStation = "NYC";
            data.ArrivalStation = "BOG";
            data.FlightCarrier = "IBE";
            data.FlightNumber = "8002";
            data.Price = 1000;
            list.Add(data);


            return list;
        }

    }
}
