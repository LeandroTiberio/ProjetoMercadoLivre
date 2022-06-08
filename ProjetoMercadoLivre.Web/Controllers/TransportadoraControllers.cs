using ProjetoMercadoLivre.Lib.Models;
using Microsoft.AspNetCore.Mvc;
using ProjetoMercadoLivre.Lib.Data;

namespace ProjetoMercadoLivre.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransportadoraControllers : ControllerBase
    {
        private readonly MercadoLivreContext _context; 
        public TransportadoraControllers(MercadoLivreContext context)
        {
            _context = context;
        }
    

        [HttpGet]
        public IActionResult GetTodos()
        {
            var transportadora = _context.Transportadoras.ToList();
            return Ok(transportadora);
        }
        [HttpGet("Transportadora{id}")]
        public IActionResult GetTransportadoraId(int id)
        {
            return Ok(_context.Transportadoras.Find(id));
        }
        [HttpPost("Adicionar Transportadora")]
        public IActionResult AdicionarTransportadoraId(Transportadora transportadora)
        {
            _context.Transportadoras.Add(transportadora);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut("Atualizar")]
        public IActionResult AtualizarNome(int idTransportadora, string nome)
        {
            var transportadora = _context.Transportadoras.Find(idTransportadora);
            transportadora.Nome = nome;
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("Deletar Transportadora Por {id}")]
        public IActionResult DeleteById(int id)
        {
            var transportadora = _context.Transportadoras.Find(id);
            _context.Transportadoras.Remove(transportadora);
            _context.SaveChanges();
            return Ok();
        }
    }
}