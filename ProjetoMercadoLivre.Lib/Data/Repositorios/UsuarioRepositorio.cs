
using ProjetoMercadoLivre.Lib.Data.Repositorios.Interface;
using ProjetoMercadoLivre.Lib.Models;


namespace ProjetoMercadoLivre.Lib.Data.Repositorios
{
    public class UsuarioRepositorio : RepositorioBase<Usuario>, IUsuarioRepositorio
    {
        private readonly MercadoLivreContext _context;

        public UsuarioRepositorio(MercadoLivreContext context) : base(context, context.Usuarios)
        {
            _context = context;
        }
    }
}                                                                                                       