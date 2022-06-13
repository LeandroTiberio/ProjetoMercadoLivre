using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Web.Controllers.DTO.DTOs
{
    public class ProdutoDTO
    {
         public int Id { get; set; }
        public virtual Vendedores Vendedor { get; set; }
        public int IdVendedor { get; set; }
        
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual List<ProdutoXPedido> ProdutosXPedidos { get; set; }
    }
}