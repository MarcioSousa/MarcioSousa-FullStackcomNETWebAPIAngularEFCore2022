using Microsoft.AspNetCore.Mvc;

namespace ProEscolas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AvistaController : ControllerBase
    {
        public AvistaController(){

        }

        [HttpGet]
        public string Get()
        {
            return "value";
        }

        [HttpGet("{AvistaId}")]
        public string Get(int AvistaId)
        {
            return "value";
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut("{AvistaId}")]
        public string Put(int AvistaId)
        {
            return "value";
        }

        [HttpDelete("{AvistaId}")]
        public string Delete(int AvistaId)
        {
            return "value";
        }

    }
}