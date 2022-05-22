using Microsoft.AspNetCore.Mvc;

namespace SSHControl.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        // GET
        [HttpGet]
        [Route("Index")]
        public string Index()
        {
            return "я бы с радостью если бы не учеба и работа !";
        }
    }
}