namespace ProEscolas.API.Models
{
    public class Matricula
    {
         public int Id { get; set; }
        public string Data { get; set; }
        public int QtdeFaltas { get; set; }
        public double Nota { get; set; }
        public Aluno Aluno { get; set; }
        public int? AlunoId { get; set; }
        public Turma Turma { get; set; }
        public int? TurmaId { get; set; }
        public void EmitirCarne()
        {

        }
    }
}