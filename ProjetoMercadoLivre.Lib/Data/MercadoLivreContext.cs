using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Models;


namespace ProjetoMercadoLivre.Lib.Data
{
    public class MercadoLivreContext : DbContext
    {
        public MercadoLivreContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Produto>().ToTable("Produtos");
            modelBuilder.Entity<Produto>().HasKey(key => key.IdVendedor); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<Produto>()
                        .HasOne(x => x.Venda) //Indica a propriedade do relacionamento One = 1 Many = N
                        .WithMany(x => x.Venda)
                        .HasForeignKey<Produto>(x => x.IdVendedor);
        }
    }
}
