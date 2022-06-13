using ProjetoMercadoLivre.Lib.Data.Repositorios.Interface;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Lib.Data.Repositorios
{
    public class ProdutoRepositorio : RepositorioBase<Produto>, IProdutoRepositorio
    {
        private readonly MercadoLivreContext _context;

        public ProdutoRepositorio(MercadoLivreContext context) : base(context, context.Produtos)
        {
            _context = context;
        }
        public void AlterarValor(int idProduto, double valor)
        {
            var produto = _context.Produtos.Find(idProduto);
            produto.Valor = valor;
            _context.SaveChanges();
        }
        
    }
}
