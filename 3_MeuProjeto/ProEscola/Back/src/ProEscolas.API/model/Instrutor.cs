using System.Collections.Generic;

namespace ProEscolas.Domain
{
    public class Instrutor : Pessoa
    {
        public int Id { get; set; }
        public string Formacao { get; set; }
        public string AreaAtuacao { get; set; }
        public virtual ICollection<Turma> Turmas { get; set; }
        public Instrutor(string cpf, string nome) : base(cpf, nome)
        {
            base.Cpf = cpf;
            base.Nome = nome;
        }
    }
}