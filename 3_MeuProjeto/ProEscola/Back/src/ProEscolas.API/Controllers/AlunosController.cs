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
    public class AlunosController : ControllerBase
    {
        private readonly ProEscolasContext context;
        public AlunosController(ProEscolasContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return context.Alunos;
        }

        [HttpGet("{Id}")]
        public Aluno GetById(int Id)
        {
            return context.Alunos
                .FirstOrDefault(aluno => aluno.Id == Id);        
        }

        [HttpPost]
        public string Post(Aluno aluno)
        {
            context.Alunos.Add(aluno);
            context.SaveChanges();
            return "value";
        }

        [HttpPut("{Id}")]
        public string Put(int Id, Aluno aluno)
        {
            context.SaveChanges();
            return "value";
        }

        [HttpDelete("{Id}")]
        public string Delete(int Id)
        {
            return "value";
        }

    }
}