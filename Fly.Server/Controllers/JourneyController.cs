using FlyBusiness.DTO;
using Microsoft.AspNetCore.Mvc;
using FlyBusiness.Services;

namespace Fly.Server.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class JourneyController : Controller
    {
        private JourneyService _journeyService;
        public JourneyController(JourneyService journeyservice)
        {
            _journeyService = journeyservice;
        }

        [HttpGet]
        [Route("Buscar")]
        public async Task<ActionResult> BuscarVuelo([FromQuery] JourneyDTO journeyDTO)
        {
            if (journeyDTO == null) return NotFound();

            var result = await _journeyService.BuscarVuelo(journeyDTO);

            return Ok(result);
        }
    }
}

