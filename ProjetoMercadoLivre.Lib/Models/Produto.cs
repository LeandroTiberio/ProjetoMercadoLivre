using ProjetoMercadoLivre.Lib.Models;
namespace ProjetoMercadoLivre.Lib.Models
{
    public class Produto 
    {

        public  List<Produto> Produtos { get; set; }
        public int Id { get; set; }
        public Vendedores Vendedor { get; set; }
        public int IdVendedor { get; set; }
        
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<ProdutoXPedido> ProdutosXPedidos { get; set; }
    
        
        
        public Produto(string nome, string descricao, double valor, DateTime dataCadastro)
        {
            SetNome(nome);
            SetDescricao(descricao);
            SetDataCadastro(dataCadastro);
        } 
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetDescricao()
        {
            return Descricao;
        }
        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }
        public DateTime GetDataCadastro()
        {
            return DataCadastro;
        }
        public void SetDataCadastro(DateTime dataCadastro)
        {
            DataCadastro = dataCadastro;
        }

    }
}