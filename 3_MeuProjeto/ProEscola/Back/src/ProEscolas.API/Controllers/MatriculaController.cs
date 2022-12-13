using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProEscolas.Persistence;
using ProEscolas.Domain;

namespace ProEscolas.API.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class MatriculaController : ControllerBase
    {    
        private readonly ProEscolasContext context;
        public MatriculaController(ProEscolasContext context){
            this.context = context;
        }
        /*
        [HttpGet]
        public IEnumerable<Matricula> Get()
        {
            return context.Matriculas;
                //.Include(a => a.Aluno)
                //.Include(t => t.Turma);
        }

        [HttpGet("{MatriculaId}")]
        public Matricula GetById(int Id)
        {
            return context.Matriculas
                .Include(a => a.Aluno)
                .Include(t => t.Turma)
                .FirstOrDefault(matricula => matricula.Id == Id);
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut("{MatriculaId}")]
        public string Put(int Id)
        {
            return "value";
        }

        [HttpDelete("{MatriculaId}")]
        public string Delete(int Id)
        {
            return "value";
        }
        */
    }
}