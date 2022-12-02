using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProEscolas.API.Data;
using ProEscolas.API.Models;

namespace ProEscolas.API.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class MatriculaController : ControllerBase
    {    
        private readonly DataContext context;
        public MatriculaController(DataContext context){
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Matricula> Get()
        {
            return context.Matriculas
                .Include(a => a.Aluno)
                .Include(t => t.Turma);
        }

        [HttpGet("{MatriculaId}")]
        public Matricula GetById(int MatriculaId)
        {
            return context.Matriculas
                .Include(a => a.Aluno)
                .Include(t => t.Turma)
                .FirstOrDefault(matricula => matricula.MatriculaId == MatriculaId);
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