using ProjetoMercadoLivre.Lib.Models;
using Microsoft.AspNetCore.Mvc;
using ProjetoMercadoLivre.Lib.Data;


namespace ProjetoMercadoLivre.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProdutoControllers : ControllerBase
    {
        private readonly MercadoLivreContext _context; 
        public ProdutoControllers(MercadoLivreContext context)
        {
            _context = context;
        }
    

        [HttpGet]
        public IActionResult GetTodos()
        {
            var produtos = _context.Produtos.ToList();
            return Ok(produtos);
        }
        [HttpGet("{id}")]
        public IActionResult GetPorId(int id)
        {
            return Ok(_context.Produtos.Find(id));
        }
        [HttpPost()]
        public IActionResult SavePorId(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut()]
        public IActionResult ConfirmaValor(int idProduto, double valor)
        {
            var produto = _context.Produtos.Find(idProduto);
            produto.Valor = valor;
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var produto = _context.Produtos.Find(id);
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            return Ok();
        }
    }
}