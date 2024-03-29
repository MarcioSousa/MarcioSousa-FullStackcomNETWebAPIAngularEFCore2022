using System.Collections.Generic;

namespace ProEscolas.API.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string SiglaTurma { get; set; }
        public string Descricao { get; set; }
        public string DataInicio { get; set; }
        public string DataTermino { get; set; }
        public string Periodo { get; set; }
        public int QtdeVagas { get; set; }
        public string Observacoes { get; set; }
        public Instrutor Instrutor { get; set; }
        public int? InstrutorId { get; set; }
        public Curso Curso { get; set; }
        public int? CursoId { get; set; }
        public virtual ICollection<Matricula> Matriculas { get; set; }
        public void EmitirListaFrequencia()
        {

        }
    }
}