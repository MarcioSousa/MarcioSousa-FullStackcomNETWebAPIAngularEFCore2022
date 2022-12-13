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
        /*
        [HttpGet]
        public IEnumerable<Instrutor> Get()
        {
            return context.Instrutores;
        }

        [HttpGet("{InstrutorId}")]
        public Instrutor GetById(int Id)
        {
            return context.Instrutores.FirstOrDefault(intrutor => intrutor.Id == Id);
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut("{InstrutorId}")]
        public string Put(int Id)
        {
            return "value";
        }

        [HttpDelete("{InstrutorId}")]
        public string Delete(int Id)
        {
            return "value";
        }
        */

    }
}