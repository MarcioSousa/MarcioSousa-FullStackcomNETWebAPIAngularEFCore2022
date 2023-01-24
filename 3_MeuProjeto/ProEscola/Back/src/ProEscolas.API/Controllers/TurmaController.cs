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
        private readonly DataContext _context;

        public TurmaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Turma> Get()
        {
            return _context.Turmas;
        }

        [HttpGet("{id}")]
        public Turma Get(int id)
        {
            //Retornar somente Aluno para retirar o sinal de colchetes
            return _context.Turmas.FirstOrDefault(Turma => Turma.Id== id);
        }

        [HttpGet("Nome/{descricao}")]
        public IEnumerable<Turma> Get(string descricao)
        {
            return _context.Turmas.Where(e => e.Descricao.ToLower().Contains(descricao.ToLower()));
        }

        [HttpPost]
        public string Post(Turma model)
        {
            _context.Turmas.Add(model);
            _context.SaveChanges();
            return "Cadastrado com sucesso!";
        }

        [HttpPut("{turmaId}")]
        public string Put(Turma model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
            return "Atualizado com Sucesso!";
        }

        [HttpDelete("{turmaId}")]
        public string Delete(int turmaId)
        {
            Turma turma =  _context.Turmas.Find(turmaId);
            _context.Turmas.Remove(turma);
            _context.SaveChanges();
            return "Removido com Sucesso!";
        }

    }
}