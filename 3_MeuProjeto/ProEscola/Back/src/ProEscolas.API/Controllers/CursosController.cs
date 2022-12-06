using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEscolas.API.Data;
using ProEscolas.API.Models;

namespace ProEscolas.API.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class CursosController : ControllerBase
    {  
        private readonly DataContext context;
        public CursosController(DataContext context){
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Curso> Get()
        {
            return context.Cursos;
        }

        [HttpGet("{CursoId}")]
        public Curso GetById(int CursoId)
        {
            return context.Cursos.FirstOrDefault(curso => curso.CursoId == CursoId);
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