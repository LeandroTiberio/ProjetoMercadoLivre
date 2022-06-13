using ProjetoMercadoLivre.Lib.Models;
using Microsoft.AspNetCore.Mvc;
using ProjetoMercadoLivre.Lib.Data;
using ProjetoMercadoLivre.Lib.Data.Repositorios;


namespace ProjetoMercadoLivre.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class PedidoControllers : ControllerBase
    {
        private readonly PedidoRepositorio _repositorio; 
        
        public PedidoControllers(PedidoRepositorio _repositorio)
        {
            _repositorio = _repositorio;
        }
    

        [HttpGet("ListarTodos")]
        public IActionResult GetTodos()
        {
            var pedidos = _repositorio.GetTodos();
            return Ok(pedidos);
        }
        [HttpGet("{id}")]
        public IActionResult GetPedidoId(int id)
        {
            var pedidos = _repositorio.BuscarPorId(id);
            return Ok(pedidos);
        }
        [HttpPost()]
        public IActionResult AdicionarPedido(Pedido pedido)
        {
            _repositorio.Adicionar(pedido);
            return Ok(pedido);
        }
        [HttpPut()]
        public IActionResult ConfirmaPedido(int idPedido, DateTime datapedido)
        {
            _repositorio.ConfirmaPedido(idPedido, datapedido);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            _repositorio.DeleteById(id);
            return Ok();
        }
    }
}