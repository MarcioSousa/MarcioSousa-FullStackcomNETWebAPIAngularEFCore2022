using System.Collections.Generic;

namespace ProEscolas.API.Models
{
    public class Instrutor : Pessoa
    {
        public int InstrutorId { get; set; }
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