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
    public class AvistaController
    {
        private readonly DataContext _context;

        public AvistaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Avista> Get()
        {
            return _context.Avistas;
        }

        [HttpGet("{id}")]
        public Avista Get(int id)
        {
            //Retornar somente Aluno para retirar o sinal de colchetes
            return _context.Avistas.FirstOrDefault(Avista => Avista.Id== id);
        }

        [HttpPost]
        public string Post(Avista model)
        {
            _context.Avistas.Add(model);
            _context.SaveChanges();
            return "Cadastrado com sucesso!";
        }

        [HttpPut("{avistaId}")]
        public string Put(Avista model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
            return "Atualizado com Sucesso!";
        }

        [HttpDelete("{avistaId}")]
        public string Delete(int avistaId)
        {
            Avista avista = _context.Avistas.Find(avistaId);
            _context.Avistas.Remove(avista);
            _context.SaveChanges();
            return "Removido com Sucesso!";
        }
    }
}