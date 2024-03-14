using FlyBusiness.DTO;
using FlyBusiness.Models;
using FlyDataAccess.FlyRepository;

namespace FlyBusiness.Services
{
    public class JourneyService
    {
        // Método para buscar un vuelo según un DTO
        public async Task<Journey> BuscarVuelo(JourneyDTO journeyDTO)
        {
            Journey JourneyResponse = new Journey();
            JourneyResponse.Origin = journeyDTO.Origin;
            JourneyResponse.Destination = journeyDTO.Destination;

            FlyDA flyDA = new FlyDA();
            List<Flight> flightData = await flyDA.GetFlightAsync();

            // Llama a un método interno para encontrar las rutas disponibles y las establece en la respuesta
            JourneyResponse.Flights = FindRoutes(journeyDTO.Origin, journeyDTO.Destination, flightData);

            // Calcula el precio total del viaje y lo establece en la respuesta
            JourneyResponse.Price = GetPrice(JourneyResponse.Flights);

            return JourneyResponse;
        }


      
        internal List<Flight> FindRoutes(string origin, string destination, List<Flight> flightData)
        {
            List<Flight> routes = new List<Flight>();

            // Busca si el origen y el destino coinciden en los elementos de la lista
            foreach (var flight in flightData)
            {
                if (flight.Origin == origin && flight.Destination == destination)
                {
                    // Si coincide, agrega el vuelo a la lista de rutas
                    routes.Add(flight);

                    // Sale del bucle, ya que encontro una ruta directa
                    return routes; 
                }
            }

            // Obtiene todos los objetos cuyo origen coincida con el origen
            var matchingOrigins = flightData.Where(f => f.Origin == origin).ToList();

            // Obtiene todos los objetos cuyo destino coincida con el destino
            var matchingDestinations = flightData.Where(f => f.Destination == destination).ToList();

            // Busca combinaciones de origen y destino
            foreach (var originFlight in matchingOrigins)
            {
                foreach (var destFlight in matchingDestinations)
                {
                    if (originFlight.Destination == destFlight.Origin)
                    {
                        // Si existe una conexión, agrega ambos vuelos a la lista de rutas
                        routes.Add(originFlight);
                        routes.Add(destFlight);

                        // Sale del bucle, ya que encontro una ruta de conexión
                        return routes; 
                    }
                }
            }

            // Si no se encontró ninguna ruta, retorna una lista vacía
            return routes;
        }



        //calcula el precio total de una lista de vuelos
        internal double GetPrice(List<Flight> flights)
        {
            double price = 0;
            foreach (Flight flight in flights)
            {
                price += flight.Price;
            }

            return price;

        }

    
    }
}