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
        /*
        [HttpGet]
        public IEnumerable<Curso> Get()
        {
            return context.Cursos;
        }

        [HttpGet("{CursoId}")]
        public Curso GetById(int Id)
        {
            return context.Cursos.FirstOrDefault(curso => curso.Id == Id);
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut("{CursoId}")]
        public string Put(int Id)
        {
            return "value";
        }

        [HttpDelete("{CursoId}")]
        public string Delete(int Id)
        {
            return "value";
        }
        */

    }
}