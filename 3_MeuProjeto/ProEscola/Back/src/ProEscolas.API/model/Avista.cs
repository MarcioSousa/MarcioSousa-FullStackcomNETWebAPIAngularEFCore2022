namespace ProEscolas.Domain
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
        public Avista(double valor, int agencia, int nCheque, string preData)
        {
            Valor = valor;
            Agencia = agencia;
            NCheque = nCheque;
            PreData = preData;
        }
    }
}