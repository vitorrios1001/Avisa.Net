using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AvisaNet.Models;

namespace Avisa.Net.Data.EntityConfiguration
{
    public class ModeloVeiculoEntityConfiguration : IEntityTypeConfiguration<ModeloVeiculo>
    {
        public void Configure(EntityTypeBuilder<ModeloVeiculo> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .Property(c => c.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder
                .Property(c => c.Descricao)
                .HasColumnName("Descricao")
                .IsRequired();

            builder
                .Property(c => c.MarcaVeiculo_Id)
                .HasColumnName("MarcaVeiculo_Id")
                .IsRequired();

            builder.ToTable("ModeloVeiculo");
        }
    }
}