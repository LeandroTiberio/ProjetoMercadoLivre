using ProjetoMercadoLivre.Lib.Models;
using Microsoft.AspNetCore.Mvc;
using ProjetoMercadoLivre.Lib.Data;

namespace ProjetoMercadoLivre.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class VendedoresControllers : ControllerBase
    {
        private readonly MercadoLivreContext _context; 
        public VendedoresControllers(MercadoLivreContext context)
        {
            _context = context;
        }
    

        [HttpGet]
        public IActionResult GetTodos()
        {
            var vendedores = _context.Vendedores.ToList();
            return Ok(vendedores);
        }
        [HttpGet("Vendedores {id}")]
        public IActionResult GetVendedorId(int id)
        {
            return Ok(_context.Vendedores.Find(id));
        }
        [HttpPost("Adicionar Vendedor")]
        public IActionResult AdicionarVendedorId(Vendedores vendedores)
        {
            _context.Vendedores.Add(vendedores);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut("Atualizar")]
        public IActionResult AtualizarNome(int idVendedores, string nome)
        {
            var vendedores = _context.Vendedores.Find(idVendedores);
            vendedores.Nome = nome;
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("Deletar Vendedor Por{id}")]
        public IActionResult DeleteById(int id)
        {
            var vendedor = _context.Vendedores.Find(id);
            _context.Vendedores.Remove(vendedor);
            _context.SaveChanges();
            return Ok();
        }
    }
}