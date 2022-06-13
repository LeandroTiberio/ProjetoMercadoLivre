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
        private readonly ProdutoRepositorio _repositorio;
        public ProdutoControllers(ProdutoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
       
        [HttpGet("ListarTodos")]
        public IActionResult GetTodos()
        {
            var produtos = _repositorio.GetTodos();
            return Ok(produtos);
        }
        [HttpGet("{id}")]
        public IActionResult GetProdutoId(int id)
        {
            var produto = _repositorio.BuscarPorId(id);
            return Ok(produto);
        }
        [HttpPost()]
        public IActionResult AdicionarProduto(Produto produto)
        {   
            _repositorio.Adicionar(produto);
            return Ok();
        }
        [HttpPut()]
        public IActionResult AlterarValor(int idProduto, double valor)
        {
            _repositorio.AlterarValor(idProduto, valor );
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