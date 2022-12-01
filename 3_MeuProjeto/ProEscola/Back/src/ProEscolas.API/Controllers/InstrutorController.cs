using Microsoft.AspNetCore.Mvc;

namespace ProEscolas.API.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class InstrutorController : ControllerBase
    {
        public InstrutorController(){

        }

        [HttpGet]
        public string Get()
        {
            return "value";
        }

        [HttpGet("{InstrutorId}")]
        public string Get(int InstrutorId)
        {
            return "value";
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut("{InstrutorId}")]
        public string Put(int InstrutorId)
        {
            return "value";
        }

        [HttpDelete("{InstrutorId}")]
        public string Delete(int InstrutorId)
        {
            return "value";
        }

    }
}