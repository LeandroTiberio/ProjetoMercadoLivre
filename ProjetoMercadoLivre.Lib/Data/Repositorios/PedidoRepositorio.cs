
using ProjetoMercadoLivre.Lib.Data.Repositorios.Interface;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Lib.Data.Repositorios
{
    public class PedidoRepositorio : RepositorioBase<Pedido>, IPedidoRepositorio
    {
        private readonly MercadoLivreContext _context;

        public PedidoRepositorio(MercadoLivreContext context) : base(context, context.Pedidos)
        {
            _context = context;
        }
        public void ConfirmaPedido(int idPedido, DateTime datapedido)
        {
            var pedido = _context.Pedidos.Find(idPedido);
            pedido.DataPedido = datapedido;
            _context.SaveChanges();
        }
      
    }
}
        