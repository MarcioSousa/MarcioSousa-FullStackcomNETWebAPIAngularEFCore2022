using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEscolas.API.Data;
using ProEscolas.API.Models;

namespace ProEscolas.API.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class InstrutorController : ControllerBase
    {  
        private readonly DataContext context;
        public InstrutorController(DataContext context){
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Instrutor> Get()
        {
            return context.Instrutores;
        }

        [HttpGet("{InstrutorId}")]
        public Instrutor GetById(int InstrutorId)
        {
            return context.Instrutores.FirstOrDefault(intrutor => intrutor.InstrutorId == InstrutorId);
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut("{InstrutorId}")]
        public string Put(int InstrutorId)
        {
            return "value";
        }

        [HttpDelete("{InstrutorId}")]
        public string Delete(int InstrutorId)
        {
            return "value";
        }

    }
}