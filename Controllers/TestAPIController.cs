using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TourWeb.API.Controllers {
    
    [Route("api/testAPI")]
    public class TestAPIController : Controller {

        [HttpGet]
        public IEnumerable<string> Get() {
            return new string[] {"value1", "value2"};
        }

        [HttpGet("{id}")]
        public string Get(int id) {
            return "value";
        }
    }
}