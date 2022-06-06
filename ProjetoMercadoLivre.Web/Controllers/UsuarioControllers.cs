using ProjetoMercadoLivre.Lib.Models;
using Microsoft.AspNetCore.Mvc;
using ProjetoMercadoLivre.Lib.Data;


namespace ProjetoMercadoLivre.Web.Controllers
{

    [ApiController]
    [Route("[controller]")]
    
    public class UsuarioControllers : ControllerBase
    {
        private readonly MercadoLivreContext _context; 
        public UsuarioControllers(MercadoLivreContext context)
        {
            _context = context;
        }
    

        [HttpGet]
        public IActionResult GetTodos()
        {
            var usuarios = _context.Usuarios.ToList();
            return Ok(usuarios);
        }
        [HttpGet("{id}")]
        public IActionResult GetPorId(int id)
        {
            return Ok(_context.Usuarios.Find(id));
        }
        [HttpPost()]
        public IActionResult SavePorId(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut()]
        public IActionResult AtualizarSenha(int idUsuario, string senha)
        {
            var usuario = _context.Usuarios.Find(idUsuario);
            usuario.Senha = senha;
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
            return Ok();
        }
    }
}


