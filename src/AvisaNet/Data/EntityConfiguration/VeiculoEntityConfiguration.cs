using AvisaNet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avisa.Net.Data.EntityConfiguration
{
    public class VeiculoEntityConfiguration : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .Property(c => c.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder
                .Property(c => c.ModeloVeiculo)
                .HasColumnName("ModeloVeiculo")
                .IsRequired();
            
            builder
                .Property(c => c.ModeloVeiculo_Id)
                .HasColumnName("Modelo_Id")
                .IsRequired();

            builder
                .Property(c => c.Pessoa_id)
                .HasColumnName("Pessoa_Id")
                .IsRequired();        

            builder
                .Property(c => c.Placa)
                .HasColumnName("Placa")
                .IsRequired(); 

            builder
                .Property(c => c.CaracteristicasExtra)
                .HasColumnName("CaracteristicasExtra")
                .IsRequired();     

            builder.ToTable("Veiculo");

        }
    }
}