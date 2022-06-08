using ProjetoMercadoLivre.Lib.Models;
using Microsoft.AspNetCore.Mvc;
using ProjetoMercadoLivre.Lib.Data;
using ProjetoMercadoLivre.Lib.Data.Repositorios;

namespace ProjetoMercadoLivre.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProdutoControllers : ControllerBase
    {
        private readonly ProdutoRepositorio _context;
        public ProdutoControllers(ProdutoRepositorio context)
        {
            _context = context;
        }
       
        [HttpGet]
        public IActionResult GetTodos()
        {
            var produtos = _context.Produtos.ToList();
            return Ok(produtos);
        }
        [HttpGet("Produto {id}")]
        public IActionResult GetProdutoId(int id)
        {
            var produtos = _context.Produtos
            return Ok(_context.Produto.Find(id));
        }
        [HttpPost("Adicionar Produto")]
        public IActionResult AdicionarProduto(Produto produto)
        {
            _context.Produto.Add(produto);
            return Ok();
        }
        [HttpPut("Confirmar")]
        public IActionResult ConfirmaValor(int idProduto, double valor)
        {
            var produto = _context.Produtos.Find(idProduto);
            produto.Valor = valor;
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("Deletar Produto Por{id}")]
        public IActionResult DeleteById(int id)
        {
            var produto = _context.Produtos.Find(id);
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            return Ok();
        }
    }
}