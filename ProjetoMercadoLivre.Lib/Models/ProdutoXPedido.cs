namespace ProjetoMercadoLivre.Lib.Models
{
    public class ProdutoXPedido
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int IdPedido { get; set; }
        public Produto Produto { get; set; }
        public Pedido Pedido { get; set; }

    }
}