using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Lib.Data
{
    public class MercadoLivreContext : DbContext
    {
        public MercadoLivreContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Produto>().ToTable("ml_produtos");
            modelBuilder.Entity<Produto>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<Produto>()
                        .HasOne(x => x.Vendedor) //Indica a propriedade do relacionamento One = 1 Many = N
                        .WithMany(x => x.Produtos)
                        .HasForeignKey(x => x.IdVendedor);
            
            modelBuilder.Entity<Pedido>().ToTable("ml_pedidos");
            modelBuilder.Entity<Pedido>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<Pedido>()
                        .HasOne(x => x.Transportadoras) //Indica a propriedade do relacionamento One = 1 Many = N
                        .WithMany(x => x.Pedidos)
                        .HasForeignKey(x => x.IdTransportadora);

            
            modelBuilder.Entity<ProdutoXPedido>().ToTable("ml_produtosxpedidos");
            modelBuilder.Entity<ProdutoXPedido>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<ProdutoXPedido>()
                        .HasOne(x => x.Produto) //Indica a propriedade do relacionamento One = 1 Many = N
                        .WithMany(x => x.ProdutosXPedidos)
                        .HasForeignKey(x => x.IdProduto);

                        modelBuilder.Entity<ProdutoXPedido>()
                        .HasOne(x => x.Pedido) //Indica a propriedade do relacionamento One = 1 Many = N
                        .WithMany(x => x.ProdutosXPedidos)
                        .HasForeignKey(x => x.IdPedido);

            modelBuilder.Entity<Usuario>().ToTable("ml_usuarios");
            modelBuilder.Entity<Usuario>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<Usuario>()
                        .HasMany(x => x.Pedidos) //Indica a propriedade do relacionamento One = 1 Many = N
                        .WithOne(x => x.Usuario)
                        .HasForeignKey(x => x.IdUsuario);

            modelBuilder.Entity<Transportadora>().ToTable("mltransportadora");
            modelBuilder.Entity<Transportadora>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            
        }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Transportadora> Transportadoras { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vendedores> Vendedores { get; set; }
        public DbSet<ProdutoXPedido> ProdutosXPedidos { get; set; }


    }
}
