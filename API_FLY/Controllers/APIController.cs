using Api_Flights.Utility;
using API_FLY.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_FLY.Controllers
{
    [ApiController]
    [Route("/api/flights")]
    public class APIController : ControllerBase
    {
        [HttpGet]
        [Route("0")]
        public async Task<ActionResult<List<API>>> Unica()
        {
            List<API> result = FlightsData.GetFlightsData0();

            return Ok(result);
        }

        [HttpGet]
        [Route("1")]
        public async Task<ActionResult<List<API>>> Multiple()
        {
            List<API> result = FlightsData.GetFlightsData1();

            return Ok(result);
        }

        [HttpGet]
        [Route("2")]
        public async Task<ActionResult<List<API>>> MultipleRetorno()
        {
            List<API> result = FlightsData.GetFlightsData2();

            return Ok(result);
        }
    }
}
