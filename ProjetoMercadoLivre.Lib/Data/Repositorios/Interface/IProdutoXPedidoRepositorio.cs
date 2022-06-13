using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Lib.Data.Repositorios.Interface
{
    public interface IProdutoXPedidoRepositorio : IRepositorioBase<ProdutoXPedido>
    {
        void AlterarProduto(int id, int IdProduto);
    }
}