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
        private readonly DataContext _context;

        public MatriculaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Matricula> Get()
        {
            return _context.Matriculas;
        }

        [HttpGet("{id}")]
        public Matricula Get(int id)
        {
            //Retornar somente Aluno para retirar o sinal de colchetes
            return _context.Matriculas.FirstOrDefault(Instrutor => Instrutor.Id== id);
        }

        //[HttpGet("Nome/{nome}")]
        //public IEnumerable<Matricula> Get(string nome)
        //{
        //    return _context.Instrutores.Where(e => e.Nome.ToLower().Contains(nome.ToLower()));
        //}
        
        [HttpPost]
        public string Post(Matricula model)
        {
            _context.Matriculas.Add(model);
            _context.SaveChanges();
            return "Cadastrado com sucesso!";
        }

        [HttpPut("{matriculaId}")]
        public string Put(Matricula model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
            return "Atualizado com Sucesso!";
        }

        [HttpDelete("{matriculaId}")]
        public string Delete(int matriculaId)
        {
            Matricula matricula =  _context.Matriculas.Find(matriculaId);
            _context.Matriculas.Remove(matricula);
            _context.SaveChanges();
            return "Removido com Sucesso!";
        }

    }
}