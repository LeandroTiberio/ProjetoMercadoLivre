using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Web.Controllers.DTO.DTOs
{
    public class TransportadoraDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Telefone { get; set; }
        public string Email { get; set; }
        public Transportadora Transportadoras { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}