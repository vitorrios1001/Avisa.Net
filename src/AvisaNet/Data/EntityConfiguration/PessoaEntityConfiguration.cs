using AvisaNet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avisa.Net.Data.EntityConfiguration
{
    public class AlunoEntityConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .Property(c => c.Id)
                .HasColumnName("id")
                .IsRequired();

            builder
                .Property(c => c.Matricula)
                .HasColumnName("Matricula")
                .IsRequired();

            builder
                .Property(c => c.Nome)
                .HasColumnName("Nome")
                .IsRequired();

            builder
                .Property(c => c.Cpf)
                .HasColumnName("Cpf")
                .IsRequired();

            builder
                .Property(c => c.Rg)
                .HasColumnName("Rg")
                .IsRequired();
                
            builder
                .Property(c => c.Cnh)
                .HasColumnName("Cnh")
                .IsRequired();

            builder.ToTable("Pessoa");
        }
        
    }
}