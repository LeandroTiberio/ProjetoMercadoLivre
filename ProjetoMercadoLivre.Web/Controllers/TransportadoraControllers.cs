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
        [HttpGet("{id}")]
        public IActionResult GetPorId(int id)
        {
            return Ok(_context.Transportadoras.Find(id));
        }
        [HttpPost()]
        public IActionResult SavePorId(Transportadora transportadora)
        {
            _context.Transportadoras.Add(transportadora);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut()]
        public IActionResult AtualizarNome(int idTransportadora, string nome)
        {
            var transportadora = _context.Transportadoras.Find(idTransportadora);
            transportadora.Nome = nome;
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var transportadora = _context.Transportadoras.Find(id);
            _context.Transportadoras.Remove(transportadora);
            _context.SaveChanges();
            return Ok();
        }
    }
}