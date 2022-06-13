
using ProjetoMercadoLivre.Lib.Data.Repositorios.Interface;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Lib.Data.Repositorios
{
    public class ProdutoXPedidoRepositorio : RepositorioBase<ProdutoXPedido>, IProdutoXPedidoRepositorio
    {
        private readonly MercadoLivreContext _context;

        public ProdutoXPedidoRepositorio(MercadoLivreContext context) : base(context, context.ProdutosXPedidos)
        {
            
        }
        public void AlterarProduto(int id, int IdProduto)
        {
            var item = _dbset.Find(id);
            item.IdProduto = IdProduto;
            _context.SaveChanges(); 
        }
     
    }
}