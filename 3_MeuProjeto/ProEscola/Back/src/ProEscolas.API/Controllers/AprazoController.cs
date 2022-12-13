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
    public class AprazoController : ControllerBase
    {  
        private readonly ProEscolasContext context;
        public AprazoController(ProEscolasContext context){
            this.context = context;
        }

        /*
        [HttpGet]
        public IEnumerable<Aprazo> Get()
        {
            return context.Aprazos
                .Include(c => c.Matricula);
        }

        [HttpGet("{AprazoId}")]
        public Aprazo GetById(int Id)
        {
            return context.Aprazos
                .Include(c => c.Matricula)
                .FirstOrDefault(aprazo => aprazo.Id == Id);
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut("{AprazoId}")]
        public string Put(int Id)
        {
            return "value";
        }

        [HttpDelete("{AprazoId}")]
        public string Delete(int Id)
        {
            return "value";
        }
        */
    }
}