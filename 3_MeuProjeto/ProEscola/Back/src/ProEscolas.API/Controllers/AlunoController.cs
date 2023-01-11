using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEscolas.API.Data;
using ProEscolas.API.Models;

namespace ProEscolas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly DataContext _context;

        public AlunoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return _context.Alunos;
        }

        [HttpGet("{id}")]
        public Aluno Get(int id)
        {
            //Retornar somente Aluno para retirar o sinal de colchetes
            return _context.Alunos.FirstOrDefault(aluno => aluno.AlunoId == id);
        }

        [HttpGet("Nome/{nome}")]
        public IEnumerable<Aluno> Get(string nome)
        {
            return _context.Alunos.Where(e => e.Nome.ToLower().Contains(nome.ToLower()));
        }

        [HttpPost]
        public string Post(Aluno model)
        {
            //Aluno aluno = new Aluno();
            //List<Aluno> alunos = new List<Aluno>();
            //alunos.AddRange(aluno.listarAlunos());
            //alunos.Add(model);
            return "Foi inserido com sucesso!";
        }

        [HttpPut("{Id}")]
        public string Put(int id, Aluno model)
        {
            return "teste";
        }

        [HttpDelete("{Id}")]
        public string Delete(int id)
        {
            return "teste";
        }

    }

}


        /*private static IEnumerable<Aluno> _alunos = new Aluno[] {
            new Aluno(){
                AlunoId = 1,
                DataNasc = "01/09/2000",
                Endereco = "Rua AA",
                Numero = 17,
                Bairro = "Centro",
                Cidade = "Itu",
                Estado = "SP",
                Cep = "11222-111",
                Telefone = "5555511111",
                Celular = "11922211111",
                Sexo = "M",
                EstadoCivil = "Casado",
                Rg = "11.111.222-22",
                Email = "teste2@teste.com",
                Escolaridade = "Ensino Médio"
            },
            new Aluno(){
                AlunoId = 2,
                DataNasc = "01/01/1990",
                Endereco = "Rua M",
                Numero = 15,
                Bairro = "Centro",
                Cidade = "Itu",
                Estado = "RJ",
                Cep = "31111-111",
                Telefone = "3311111111",
                Celular = "33911111111",
                Sexo = "M",
                EstadoCivil = "Solteiro",
                Rg = "33.111.111-11",
                Email = "teste3@teste.com",
                Escolaridade = "Ensino Superior"
            }
        };
        */