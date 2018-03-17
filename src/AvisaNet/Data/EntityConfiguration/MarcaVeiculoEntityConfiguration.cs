using AvisaNet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AvisaNet.Data.EntityConfiguration
{
    public class MarcaVeiculoEntityConfiguration : IEntityTypeConfiguration<MarcaVeiculo>
    {
        public void Configure(EntityTypeBuilder<MarcaVeiculo> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .Property(c => c.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder
                .Property(c => c.Descricao)
                .HasColumnName("DescCurta")
                .IsRequired();

            builder.ToTable("MarcaVeiculo");
        }
    }
}