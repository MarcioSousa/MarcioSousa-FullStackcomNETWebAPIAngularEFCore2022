namespace ProEscolas.Domain
{
    public class Aluno : Pessoa
    {
        public int Id { get; set; }
        public string Escolaridade { get; set; }
        //public Matricula Matricula { get; set; }
        //public int MatriculaId { get; set; }
        public Aluno(string cpf, string nome) : base(cpf, nome)
        {
            base.Cpf = cpf;
            base.Nome = nome;
        }
    }
}