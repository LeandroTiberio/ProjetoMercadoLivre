using ProjetoMercadoLivre.Lib.Models;
using Microsoft.AspNetCore.Mvc;
using ProjetoMercadoLivre.Lib.Data;


namespace ProjetoMercadoLivre.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class PedidoControllers : ControllerBase
    {
        private readonly MercadoLivreContext _context; 
        public PedidoControllers(MercadoLivreContext context)
        {
            _context = context;
        }
    

        [HttpGet]
        public IActionResult GetTodos()
        {
            var pedidos = _context.Pedidos.ToList();
            return Ok(pedidos);
        }
        [HttpGet("Pedido {id}")]
        public IActionResult GetPedidoId(int id)
        {
            return Ok(_context.Pedidos.Find(id));
        }
        [HttpPost("Adicionar pedido")]
        public IActionResult AdicionarPedidoId(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut("Confirmar")]
        public IActionResult ConfirmaValor(int idPedido, DateTime datapedido)
        {
            var pedido = _context.Pedidos.Find(idPedido);
            pedido.DataPedido = datapedido;
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("Deletar Pedido Por{id}")]
        public IActionResult DeleteById(int id)
        {
            var pedido = _context.Pedidos.Find(id);
            _context.Pedidos.Remove(pedido);
            _context.SaveChanges();
            return Ok();
        }
    }
}