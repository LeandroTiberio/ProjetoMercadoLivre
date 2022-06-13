using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Models;
using ProjetoMercadoLivre.Lib.Data.Repositorios.Interface;


namespace ProjetoMercadoLivre.Lib.Data
{
  
    public class RepositorioBase<T> :IRepositorioBase<T> where T : ModelBase
    {
        private readonly MercadoLivreContext _context;
        private readonly DbSet<T> _dbset;
        public RepositorioBase(MercadoLivreContext dbContext, DbSet<T> dbset)
        {
            _context = dbContext;
            _dbset = dbset;
        }
       
        public List<T> GetTodos()
        {
            var T = _dbset.ToList();
            return T;
        }
        public void Adicionar(T item)
        {
            _dbset.Add(item);
            _context.SaveChanges();
            
        }
        public void DeleteById(int id)
        {
            var item = _dbset.AsNoTracking().First(x => x.Id == id);
           _dbset.Remove(item);
           _context.SaveChanges();
        }
        public T BuscarPorId(int id)
        {
            return _dbset.AsNoTracking().First(x => x.Id == id);
        }


    }

}


    