using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Avisa.Net.Models;

namespace Avisa.Net.Data.EntityConfiguration
{
    public class ModeloVeiculoEntityConfiguration : IEntityTypeConfiguration<ModeloVeiculo>
    {
        public void Configure(EntityTypeBuilder<ModeloVeiculo> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();

            builder.Property(c => c.Nome).HasColumnName("Nome").IsRequired();

            builder.Property(c => c.MarcaVeiculo).HasColumnName("MarcaVeiculo");

            builder.ToTable("ModeloVeiculo");
        }
    }
}