using Avisa.Net.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avisa.Net.Data.EntityConfiguration
{
    public class VeiculoEntityConfiguration : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();

            builder.Property(c => c.ModeloVeiculo).HasColumnName("ModeloVeiculo").IsRequired();

            builder.Property(c => c.Cor).HasColumnName("Cor");

            builder.ToTable("Veiculo");

        }
    }
}