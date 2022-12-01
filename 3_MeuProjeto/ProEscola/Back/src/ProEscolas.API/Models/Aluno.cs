namespace ProEscolas.API.Models
{
    public class Aluno : Pessoa
    {
        public int AlunoId { get; set; }
        public string Escolaridade { get; set; }
        public Matricula Matricula { get; set; }
        public Aluno(string cpf, string nome) : base(cpf, nome)
        {
            base.Cpf = cpf;
            base.Nome = nome;
        }
    }
}