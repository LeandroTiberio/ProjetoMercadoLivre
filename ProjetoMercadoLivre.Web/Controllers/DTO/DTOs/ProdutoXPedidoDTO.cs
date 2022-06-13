using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Web.Controllers.DTO.DTOs
{
    public class ProdutoXPedidoDTO
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int IdPedido { get; set; }
        public Produto Produto { get; set; }
        public Pedido Pedido { get; set; }
    }
}