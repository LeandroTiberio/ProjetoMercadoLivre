
using ProjetoMercadoLivre.Lib.Data.Repositorios.Interface;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Lib.Data.Repositorios
{
    public class VendedoresRepositorio :RepositorioBase<Vendedores>, IVendedoresRepositorio
    {
        private readonly MercadoLivreContext _context;

        public VendedoresRepositorio(MercadoLivreContext context) : base(context, context.Vendedores)
        {
            _context = context;
        }
        
    }
}