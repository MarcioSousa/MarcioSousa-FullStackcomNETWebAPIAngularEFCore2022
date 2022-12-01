using Microsoft.AspNetCore.Mvc;

namespace ProEscolas.API.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public AlunoController(){

        }

        [HttpGet]
        public string Get()
        {
            return "value";
        }

        [HttpGet("{AlunoId}")]
        public string Get(int AlunoId)
        {
            return "value";
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut("{AlunoId}")]
        public string Put(int AlunoId)
        {
            return "value";
        }

        [HttpDelete("{AlunoId}")]
        public string Delete(int AlunoId)
        {
            return "value";
        }
    }
}