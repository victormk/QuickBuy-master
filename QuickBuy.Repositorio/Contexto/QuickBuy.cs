using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Repositorio.Config;
using QuickBuy.Repositorio.Repositorios;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto : DbContext 
    {
      
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos  { get; set; }
        public DbSet<Pedido>  Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }
        public QuickBuyContexto(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /// Classes de mapeamento

            ModelBuilder.ApplyConfiguration(new UsuarioConfiguration);

            ModelBuilder.ApplyConfiguration(new ProdutoConfiguration);

            ModelBuilder.ApplyConfiguration(new ItemPedidoConfiguration);

            ModelBuilder.ApplyConfiguration(new FormaPagamentConfiguration);
            base.OnModelCreating(modelBuilder);
        }
    }
}
