using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Web.Controllers.DTO.DTOs
{
    public class UsuarioDTO
    {
        public int? Usuarios  { get; set; }
        public List<Pedido> Pedidos { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Senha { get; set; }
    }
}