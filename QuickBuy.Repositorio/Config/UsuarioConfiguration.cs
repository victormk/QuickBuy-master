using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            builder.
                Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasKey(u => u.Nome);
            builder.
                Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasKey(u => u.Sobrenome);
            builder.
                Property(u => u.Sobrenome).
                IsRequired().
                HasMaxLength(50);

            builder.HasKey(u => u.Senha);
            builder.
                Property(u => u.Senha).
                IsRequired().
                HasMaxLength(500);

            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);


        }
    }
}
