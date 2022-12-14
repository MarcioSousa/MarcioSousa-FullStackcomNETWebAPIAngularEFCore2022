using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEscolas.Persistence;
using ProEscolas.Domain;

namespace ProEscolas.API.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class InstrutorController : ControllerBase
    {  
        private readonly ProEscolasContext context;
        public InstrutorController(ProEscolasContext context){
            this.context = context;
        }
        
        [HttpGet]
        public IEnumerable<Instrutor> Get()
        {
            return context.Instrutores;
        }

        [HttpGet("{Id}")]
        public Instrutor GetById(int Id)
        {
            return context.Instrutores.FirstOrDefault(intrutor => intrutor.Id == Id);
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