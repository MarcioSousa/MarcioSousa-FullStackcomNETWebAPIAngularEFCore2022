using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProEscolas.API.Data;
using ProEscolas.API.Models;

namespace ProEscolas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly DataContext _context;

        public AlunoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return _context.Alunos;
        }

        [HttpGet("{id}")]
        public Aluno Get(int id)
        {
            //Retornar somente Aluno para retirar o sinal de colchetes
            return _context.Alunos.FirstOrDefault(aluno => aluno.AlunoId == id);
        }

        [HttpGet("Nome/{nome}")]
        public IEnumerable<Aluno> Get(string nome)
        {
            return _context.Alunos.Where(e => e.Nome.ToLower().Contains(nome.ToLower()));
        }

        [HttpPost]
        public string Post(Aluno model)
        {
            _context.Alunos.Add(model);
            _context.SaveChanges();
            return "Cadastrado com sucesso!";
        }

        [HttpPut("{alunoId}")]
        public string Put(Aluno model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
            return "Atualizado com Sucesso!";
        }

        [HttpDelete("{alunoId}")]
        public string Delete(int alunoId)
        {
            Aluno aluno =  _context.Alunos.Find(alunoId);
            _context.Alunos.Remove(aluno);
            _context.SaveChanges();
            return "Removido com Sucesso!";
        }

    }

}

      