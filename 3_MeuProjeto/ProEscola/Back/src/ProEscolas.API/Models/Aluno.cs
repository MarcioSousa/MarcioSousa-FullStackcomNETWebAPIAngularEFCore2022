using System.Collections.Generic;

namespace ProEscolas.API.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string DataNasc { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Rg { get; set; }
        public string Email { get; set; }
        public string Escolaridade { get; set; }
        public Aluno(string cpf, string nome)
        {
            this.Cpf = cpf;
            this.Nome = nome;
        }
        public Aluno(){ }

        public List<Aluno> listarAlunos()
        {
            List<Aluno> alunos = new List<Aluno>();
            
            Aluno aluno1 = new("123.456.789-22", "João")
            {
                Id = 1,
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
            };
            Aluno aluno2 = new("012.645.201-77", "Marcio")
            {
                Id = 2,
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
            };

            alunos.Add(aluno1);
            alunos.Add(aluno2);

            return alunos;
        }

    }
}