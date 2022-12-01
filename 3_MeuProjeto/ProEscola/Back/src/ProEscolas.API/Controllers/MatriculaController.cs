using Microsoft.AspNetCore.Mvc;

namespace ProEscolas.API.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class MatriculaController : ControllerBase
    {  
        public MatriculaController(){

        }

        [HttpGet]
        public string Get()
        {
            return "value";
        }

        [HttpGet("{MatriculaId}")]
        public string Get(int MatriculaId)
        {
            return "value";
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut("{MatriculaId}")]
        public string Put(int MatriculaId)
        {
            return "value";
        }

        [HttpDelete("{MatriculaId}")]
        public string Delete(int MatriculaId)
        {
            return "value";
        }
        
    }
}