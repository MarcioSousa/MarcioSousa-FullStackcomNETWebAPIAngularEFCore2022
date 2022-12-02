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
    public class AvistaController : ControllerBase
    {  
        private readonly DataContext context;
        public AvistaController(DataContext context){
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Avista> Get()
        {
            return context.Avistas.Include(c => c.Matricula);
        }

        [HttpGet("{AvistaId}")]
        public Avista GetById(int AvistaId)
        {
            return context.Avistas
                .Include(c => c.Matricula)
                .FirstOrDefault(avista => avista.AvistaId == AvistaId);
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut("{AvistaId}")]
        public string Put(int AvistaId)
        {
            return "value";
        }

        [HttpDelete("{AvistaId}")]
        public string Delete(int AvistaId)
        {
            return "value";
        }

    }
}