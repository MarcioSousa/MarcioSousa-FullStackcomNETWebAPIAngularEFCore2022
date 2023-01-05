using Microsoft.AspNetCore.Mvc;

namespace ProEscolas.API.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "teste";
        }
    }

}