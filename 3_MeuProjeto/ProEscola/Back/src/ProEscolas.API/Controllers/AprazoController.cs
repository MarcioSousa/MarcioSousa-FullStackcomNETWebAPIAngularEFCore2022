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
    public class AprazoController : ControllerBase
    {  
        private readonly DataContext context;
        public AprazoController(DataContext context){
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Aprazo> Get()
        {
            return context.Aprazos
                .Include(c => c.Matricula);
        }

        [HttpGet("{AprazoId}")]
        public Aprazo GetById(int AprazoId)
        {
            return context.Aprazos
                .Include(c => c.Matricula)
                .FirstOrDefault(aprazo => aprazo.AprazoId == AprazoId);
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut("{AprazoId}")]
        public string Put(int AprazoId)
        {
            return "value";
        }

        [HttpDelete("{AprazoId}")]
        public string Delete(int AprazoId)
        {
            return "value";
        }
    }
}