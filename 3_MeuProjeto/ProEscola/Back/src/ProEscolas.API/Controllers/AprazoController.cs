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
    public class AprazoController
    {
        private readonly DataContext _context;

        public AprazoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Aprazo> Get()
        {
            return _context.Aprazos;
        }

        [HttpGet("{id}")]
        public Aprazo Get(int id)
        {
            //Retornar somente Aluno para retirar o sinal de colchetes
            return _context.Aprazos.FirstOrDefault(Aprazo => Aprazo.Id== id);
        }

        [HttpPost]
        public string Post(Aprazo model)
        {
            _context.Aprazos.Add(model);
            _context.SaveChanges();
            return "Cadastrado com sucesso!";
        }

        [HttpPut("{aprazoId}")]
        public string Put(Aprazo model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
            return "Atualizado com Sucesso!";
        }

        [HttpDelete("{aprazoId}")]
        public string Delete(int aprazoId)
        {
            Aprazo aprazo =  _context.Aprazos.Find(aprazoId);
            _context.Aprazos.Remove(aprazo);
            _context.SaveChanges();
            return "Removido com Sucesso!";
        }
    }
}