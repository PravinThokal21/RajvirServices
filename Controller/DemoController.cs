using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RajvirServices.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public string Greetings()
        {
            return "welcome";
        }
    }
}
