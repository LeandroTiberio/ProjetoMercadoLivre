using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Lib.Data.Repositorios.Interface
{
    public interface IRepositorioBase<T> where T : ModelBase
    {
       public List<T> BuscarTodos();
       public T BuscarProId (int id);
       public void Adicionar (T item);
       public void Deletar (int id);

    }
   
}







