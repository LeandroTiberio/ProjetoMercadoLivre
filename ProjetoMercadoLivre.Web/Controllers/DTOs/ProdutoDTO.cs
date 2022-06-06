namespace ProjetoMercadoLivre.Web.Controllers.DTOs
{
    public class ProdutoDTO
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}