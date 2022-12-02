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
    public class TurmaController : ControllerBase
    {  
        private readonly DataContext context;
        public TurmaController(DataContext context){
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Turma> Get()
        {
            return context.Turmas
                .Include(c => c.Curso)
                .Include(i => i.Instrutor);
        }

        [HttpGet("{TurmaId}")]
        public Turma GetById(int TurmaId)
        {
            return context.Turmas
                .Include(c => c.Curso)
                .Include(i => i.Instrutor)
                .FirstOrDefault(turma => turma.TurmaId == TurmaId);
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut("{TurmaId}")]
        public string Put(int TurmaId)
        {
            return "value";
        }

        [HttpDelete("{TurmaId}")]
        public string Delete(int TurmaId)
        {
            return "value";
        }

    }
}