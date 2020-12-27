using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using TourWeb.API.Services;

namespace TourWeb.API.Controllers {
    [Route("api/[controller]")]
    public class TouristRoutesController : Controller {
        private ITouristRouteRepository _touristRouteRepository;

        public TouristRoutesController(ITouristRouteRepository touristRouteRepository) {
            this._touristRouteRepository = touristRouteRepository;
        }

        
        public IActionResult GetTouristRoutes() {
            var routes = _touristRouteRepository.GetTouristRoutes();
            return Ok(routes);
        }
    }
}