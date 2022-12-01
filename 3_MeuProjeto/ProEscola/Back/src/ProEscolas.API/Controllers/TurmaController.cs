using Microsoft.AspNetCore.Mvc;

namespace ProEscolas.API.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class TurmaController : ControllerBase
    {
        public TurmaController(){

        }

        [HttpGet]
        public string Get()
        {
            return "value";
        }

        [HttpGet("{TurmaId}")]
        public string Get(int TurmaId)
        {
            return "value";
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut("{TurmaId}")]
        public string Put(int TurmaId)
        {
            return "value";
        }

        [HttpDelete("{TurmaId}")]
        public string Delete(int TurmaId)
        {
            return "value";
        }

    }
}