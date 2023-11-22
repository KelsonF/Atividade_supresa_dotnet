namespace projeto_otilio_aula.Models
{
    public class Carrinho
    {
        public Int16 Id {get; set;}
        public Int16 UserId { get; set; }
        public ICollection<Produto>? Produtos { get; set; }
    }
}