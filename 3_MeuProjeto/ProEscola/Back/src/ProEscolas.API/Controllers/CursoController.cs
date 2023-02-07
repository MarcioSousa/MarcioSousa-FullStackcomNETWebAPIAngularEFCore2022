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
    public class CursoController : ControllerBase
    {
        private readonly DataContext _context;

        public CursoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Curso> Get()
        {
            return _context.Cursos
                .Include(c => c.Turmas);
        }

        [HttpGet("{id}")]
        public Curso Get(int id)
        {
            //Retornar somente Aluno para retirar o sinal de colchetes
            return _context.Cursos.FirstOrDefault(Curso => Curso.Id== id);
        }

        [HttpGet("Nome/{nome}")]
        public IEnumerable<Curso> Get(string nome)
        {
            return _context.Cursos.Where(e => e.Nome.ToLower().Contains(nome.ToLower()));
        }

        [HttpPost]
        public string Post(Curso model)
        {
            _context.Cursos.Add(model);
            _context.SaveChanges();
            return "Cadastrado com sucesso!";
        }

        [HttpPut("{cursoId}")]
        public string Put(Curso model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
            return "Atualizado com Sucesso!";
        }

        [HttpDelete("{cursoId}")]
        public string Delete(int cursoId)
        {
            Curso curso =  _context.Cursos.Find(cursoId);
            _context.Cursos.Remove(curso);
            _context.SaveChanges();
            return "Removido com Sucesso!";
        }
    }
}