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
    public class AvistaController : ControllerBase
    {  
        private readonly ProEscolasContext context;
        public AvistaController(ProEscolasContext context){
            this.context = context;
        }
        
        [HttpGet]
        public IEnumerable<Avista> Get()
        {
            return context.Avistas.Include(c => c.Matricula);
        }

        [HttpGet("{Id}")]
        public Avista GetById(int Id)
        {
            return context.Avistas
                .Include(c => c.Matricula)
                .FirstOrDefault(avista => avista.Id == Id);
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut("{Id}")]
        public string Put(int Id)
        {
            return "value";
        }

        [HttpDelete("{Id}")]
        public string Delete(int Id)
        {
            return "value";
        }
        

    }
}