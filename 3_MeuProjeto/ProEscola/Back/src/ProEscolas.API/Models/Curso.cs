using System.Collections.Generic;

namespace ProEscolas.API.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public double Valor { get; set; }
        public string DataVigencia { get; set; }
        public double ValorHoraInstrutor { get; set; }
        public string Programa { get; set; }
        public ICollection<Turma> Turmas { get; set; }

        public Curso(string sigla, string nome)
        {
            this.Sigla = sigla;
            this.Nome = nome;
        }
    }
}