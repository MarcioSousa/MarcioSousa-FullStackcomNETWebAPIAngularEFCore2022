using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEscolas.API.Data;
using ProEscolas.API.Models;

namespace ProEscolas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly DataContext context;
        public AlunoController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return context.Alunos;
        }

        [HttpGet("{AlunoId}")]
        public Aluno GetById(int AlunoId)
        {
            return context.Alunos.FirstOrDefault(aluno => aluno.AlunoId == AlunoId );        
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut("{AlunoId}")]
        public string Put(int AlunoId)
        {
            return "value";
        }

        [HttpDelete("{AlunoId}")]
        public string Delete(int AlunoId)
        {
            return "value";
        }
    }
}