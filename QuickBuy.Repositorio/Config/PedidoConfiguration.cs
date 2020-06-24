using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<PedidoConfiguration>
    {
        public void Configure(EntityTypeBuilder<PedidoConfiguration> builder)
        {
            public void Configure(EntityTypeBuilder<Pedido> builder)
            {
                builder.HasKey(pd => pd.Id);

                builder.Property(pd => pd.DataPedido)
                    .IsRequired()

                builder.Property(pd => pd.DataPrevisaoEntrega)
                       .IsRequired()

                builder.Property(pd => pd.CEP)
                     .IsRequired()
                     .HasMaxLength(10);
                builder.Property(pd => pd.Cidade)
                    .IsRequired()
                    .HasMaxLength(100);

                builder.Property(pd => pd.Estado)
                   .IsRequired()
                   .HasMaxLength(30);

                builder.Property(pd => pd.EnderecoCompleto)
                    .IsRequired()
                    .HasMaxLength(100);

                builder.Property(pd => pd.NumeroEndereco)
                    .IsRequired()
                    .HasMaxLength(10);
        }
    }
}
