using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Web.Controllers.DTO.DTOs
{
    public class VendedoresDTO
    {
        public int Id { get; set; }
        public List<Produto> Produtos { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Cnpj { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}