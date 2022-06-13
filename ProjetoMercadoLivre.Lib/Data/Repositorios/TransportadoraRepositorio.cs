
using ProjetoMercadoLivre.Lib.Data.Repositorios.Interface;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Lib.Data.Repositorios
{
    public class TransportadoraRepositorio : RepositorioBase<Transportadora>, ITransportadoraRepositorio
    {
        private readonly MercadoLivreContext _context;

        public TransportadoraRepositorio(MercadoLivreContext context) : base(context, context.Transportadoras)
        {
            _context = context;
        }
        public void AtualizarNome(int idTransportadora, string nome)
        {
            var transportadora = _context.Transportadoras.Find(idTransportadora);
            transportadora.Nome = nome;
            _context.SaveChanges();
        }
      
    }
}