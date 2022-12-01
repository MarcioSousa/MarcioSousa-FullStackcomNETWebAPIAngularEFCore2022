using Microsoft.AspNetCore.Mvc;

namespace ProEscolas.API.Controllers 
{ 
    [ApiController]
    [Route("api/[controller]")]
    public class AprazoController : ControllerBase
    {
        public AprazoController(){

        }

        [HttpGet]
        public string Get()
        {
            return "value";
        }

        [HttpGet("{AprazoId}")]
        public string Get(int AprazoId)
        {
            return "value";
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