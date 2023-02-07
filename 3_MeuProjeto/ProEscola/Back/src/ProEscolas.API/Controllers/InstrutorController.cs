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
    public class InstrutorController : ControllerBase
    {
        private readonly DataContext _context;

        public InstrutorController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Instrutor> Get()
        {
            return _context.Instrutores
                .Include(i => i.Turmas);
        }

        [HttpGet("{id}")]
        public Instrutor Get(int id)
        {
            //Retornar somente Aluno para retirar o sinal de colchetes
            return _context.Instrutores.FirstOrDefault(Instrutor => Instrutor.Id== id);
        }

        [HttpGet("Nome/{nome}")]
        public IEnumerable<Instrutor> Get(string nome)
        {
            return _context.Instrutores.Where(e => e.Nome.ToLower().Contains(nome.ToLower()));
        }

        [HttpPost]
        public string Post(Instrutor model)
        {
            _context.Instrutores.Add(model);
            _context.SaveChanges();
            return "Cadastrado com sucesso!";
        }

        [HttpPut("{instrutorId}")]
        public string Put(Instrutor model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
            return "Atualizado com Sucesso!";
        }

        [HttpDelete("{instrutorId}")]
        public string Delete(int instrutorId)
        {
            Instrutor instrutor =  _context.Instrutores.Find(instrutorId);
            _context.Instrutores.Remove(instrutor);
            _context.SaveChanges();
            return "Removido com Sucesso!";
        }

    }
}