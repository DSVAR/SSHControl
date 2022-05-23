using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SSHControl.Server.Controllers
{
  
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET
        [HttpGet("Index")]
        public string Index()
        {
            return "я бы с радостью если бы не учеба и работа !";
        }
    }
}