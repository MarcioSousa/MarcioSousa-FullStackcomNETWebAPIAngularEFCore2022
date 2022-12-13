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
    public class TurmaController : ControllerBase
    {  
        private readonly ProEscolasContext context;
        public TurmaController(ProEscolasContext context){
            this.context = context;
        }
        /*
        [HttpGet]
        public IEnumerable<Turma> Get()
        {
            return context.Turmas
                .Include(c => c.Curso)
                .Include(i => i.Instrutor);
        }

        [HttpGet("{TurmaId}")]
        public Turma GetById(int Id)
        {
            return context.Turmas
                .Include(c => c.Curso)
                .Include(i => i.Instrutor)
                .FirstOrDefault(turma => turma.Id == Id);
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut("{TurmaId}")]
        public string Put(int Id)
        {
            return "value";
        }

        [HttpDelete("{TurmaId}")]
        public string Delete(int Id)
        {
            return "value";
        }
        */
    }
}