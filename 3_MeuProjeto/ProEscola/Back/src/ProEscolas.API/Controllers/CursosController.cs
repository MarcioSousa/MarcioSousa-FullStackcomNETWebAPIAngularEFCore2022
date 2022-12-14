using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEscolas.Persistence;
using ProEscolas.Domain;

namespace ProEscolas.API.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class CursosController : ControllerBase
    {  
        private readonly ProEscolasContext context;
        public CursosController(ProEscolasContext context){
            this.context = context;
        }
        
        [HttpGet]
        public IEnumerable<Curso> Get()
        {
            return context.Cursos;
        }

        [HttpGet("{Id}")]
        public Curso GetById(int Id)
        {
            return context.Cursos.FirstOrDefault(curso => curso.Id == Id);
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut("{Id}")]
        public string Put(int Id)
        {
            return "value";
        }

        [HttpDelete("{Id}")]
        public string Delete(int Id)
        {
            return "value";
        }

    }
}