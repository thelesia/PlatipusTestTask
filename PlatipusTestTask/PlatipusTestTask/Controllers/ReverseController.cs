using Microsoft.AspNetCore.Mvc;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlatipusTestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseController : ControllerBase
    {

        // GET api/<DataController>/5
        [HttpGet("{data}")]
        public string Get(object data)
        {
            int number;

            int.TryParse(data.ToString(),out number);

            if (number != default(int))
            {
                return JsonConvert.SerializeObject(Math.Sqrt(number));
            }
            
            return JsonConvert.SerializeObject(data.ToString().ToCharArray().Reverse().ToString());
        }
    }
}
