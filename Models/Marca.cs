namespace MarcaApi.Models
{
    public class Marca
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int AnoFundacao { get; set; }
        public string PaisOrigem { get; set; }
        public string Setor { get; set; }
        public string Slogan { get; set; }
        public string Website { get; set; }
        public string Descricao { get; set; }
    }
}