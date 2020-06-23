using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio;
using QuickBuy.Dominio.Entidades;
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
        public QuickBuyContexto([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }

    }
}
