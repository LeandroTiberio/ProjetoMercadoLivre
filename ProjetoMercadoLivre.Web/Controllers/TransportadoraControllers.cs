using ProjetoMercadoLivre.Lib.Models;
using Microsoft.AspNetCore.Mvc;
using ProjetoMercadoLivre.Lib.Data;
using ProjetoMercadoLivre.Lib.Data.Repositorios;

namespace ProjetoMercadoLivre.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransportadoraControllers : ControllerBase
    {
        private readonly TransportadoraRepositorio _repositorio; 
        public TransportadoraControllers(TransportadoraRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
    

        [HttpGet]
        public IActionResult GetTodos()
        {
            var transportadora = _repositorio.GetTodos();
            return Ok(transportadora);
        }
        [HttpGet("{id}")]
        public IActionResult GetTransportadoraId(int id)
        {
            var transportadora = _repositorio.BuscarPorId(id);
            return Ok(transportadora);
        }
        [HttpPost()]
        public IActionResult AdicionarTransportadoraId(Transportadora transportadora)
        {
            _repositorio.Adicionar(transportadora);
            return Ok();
        }
        [HttpPut()]
        public IActionResult AtualizarNome(int idTransportadora, string nome)
        {
            _repositorio.AtualizarNome(idTransportadora, nome);
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