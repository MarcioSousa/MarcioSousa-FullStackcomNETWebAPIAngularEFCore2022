namespace ProEscolas.API.Models
{
    public class Avista
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public int Agencia { get; set; }
        public int NCheque { get; set; }
        public string PreData { get; set; }
        public Matricula Matricula { get; set; }
        public int? MatriculaId { get; set; }
    }
}