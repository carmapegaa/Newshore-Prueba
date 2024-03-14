using Core.Models;
using FlyBusiness.Models;
using System.Net.Http.Json;
namespace FlyDataAccess.FlyRepository
{
    public class FlyDA
    {
        private HttpClient _httpClient = new HttpClient();

        public async Task<List<Flight>> GetFlightAsync()
        {
            string PORT = "5154";
            string LEVEL = "1";
            string apiURL = $"http://localhost:{PORT}/api/flights/{LEVEL}";
            List<Flight> responseList = new List<Flight>();
            List<FlightAPI> responseListAPI = new List<FlightAPI>();

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(apiURL);

                if (response.IsSuccessStatusCode)
                {
                    responseListAPI = await response.Content.ReadFromJsonAsync<List<FlightAPI>>();
                    foreach (FlightAPI flightApi in responseListAPI)
                    {
                        Flight flight = new Flight();
                        flight.Origin = flightApi.DepartureStation;
                        flight.Destination = flightApi.ArrivalStation;
                        flight.Price = flightApi.Price;
                        Transport transport = new Transport();
                        transport.FlightCarrier = flightApi.FlightCarrier;
                        transport.FlightNumber = flightApi.FlightNumber;
                        flight.Transport = transport;
                        responseList.Add(flight);
                    }
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al realizar la solicitud:{ex.Message}");
            }

            return (responseList);
        }
    }

}