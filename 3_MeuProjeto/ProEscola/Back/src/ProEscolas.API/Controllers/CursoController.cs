using Microsoft.AspNetCore.Mvc;

namespace ProEscolas.API.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class CursoController : ControllerBase
    {
        public CursoController(){

        }

        [HttpGet]
        public string Get()
        {
            return "value";
        }

        [HttpGet("{CursoId}")]
        public string Get(int CursoId)
        {
            return "value";
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut("{CursoId}")]
        public string Put(int CursoId)
        {
            return "value";
        }

        [HttpDelete("{CursoId}")]
        public string Delete(int CursoId)
        {
            return "value";
        }

    }
}