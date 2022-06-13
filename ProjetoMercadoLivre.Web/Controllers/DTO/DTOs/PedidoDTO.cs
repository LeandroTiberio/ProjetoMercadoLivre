using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Web.Controllers.DTO.DTOs
{
    public class PedidoDTO
    {
        public int IdUsuario { get; set; }
        public int Id { get; set; }
        public int IdTransportadora { get; set; }
        public virtual Transportadora Transportadoras { get; set; }
        public virtual Usuario Usuario { get; set; }
        
        public DateTime DataPedido { get; set; }
        public string Status { get; set; }

        
    }
}