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
    public class AlunosController : ControllerBase
    {
        private readonly DataContext context;
        public AlunosController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return context.Alunos
                .Include(m => m.Matricula);
        }

        [HttpGet("{AlunoId}")]
        public Aluno GetById(int AlunoId)
        {
            return context.Alunos
                .Include(m => m.Matricula)
                .FirstOrDefault(aluno => aluno.AlunoId == AlunoId);        
        }

        [HttpPost]
        public string Post(Aluno aluno)
        {
            context.Alunos.Add(aluno);
            context.SaveChanges();
            return "value";
        }

        [HttpPut("{AlunoId}")]
        public string Put(int AlunoId, Aluno aluno)
        {
            context.SaveChanges();
            return "value";
        }

        [HttpDelete("{AlunoId}")]
        public string Delete(int AlunoId)
        {
            return "value";
        }
    }
}