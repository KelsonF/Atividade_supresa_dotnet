namespace projeto_otilio_aula.Models
{
    public class Produto
    {
        public Int16 Id { get; set; }
        public String? Descricao { get; set; }
        public String? PathImage { get; set; }
        public Decimal? Preço { get; set; }
        public Int16 Quantitade { get; set; }
        public Categoria? Categoria { get; set; }
    }
}