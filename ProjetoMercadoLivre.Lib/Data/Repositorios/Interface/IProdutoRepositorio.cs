using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Lib.Data.Repositorios.Interface
{
    public interface IProdutoRepositorio : IRepositorioBase<Produto>
    {
         public List<Produto> BuscarProdutoComVendedor();
         public void AlterarValor (int id, double valor);
    }
}