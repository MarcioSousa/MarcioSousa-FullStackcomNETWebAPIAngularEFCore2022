namespace ProEscolas.Domain
{
    public class Aprazo
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public string DtVencimento { get; set; }
        public int QtdeMensalidade { get; set; }
        public double TaxaJuros { get; set; }
        public Matricula Matricula { get; set; }
        public int? MatriculaId { get; set; }
        public Aprazo(double valor, int qtdeMensalidade, double taxaJuros, string dtVencimento)
        {
            Valor = valor;
            DtVencimento = dtVencimento;
            QtdeMensalidade = qtdeMensalidade;
            TaxaJuros = taxaJuros;
        }
    }
}