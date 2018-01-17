using Avisa.Net.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avisa.Net.Data.EntityConfiguration
{
    public class AlunoEntityConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("id").IsRequired();

            builder.Property(c => c.Matricula).HasColumnName("Matricula").IsRequired();

            builder.Property(c => c.Nome).HasColumnName("Nome").IsRequired();

            builder.Property(c => c.Veiculo).HasColumnName("Veiculo").IsRequired();

            builder.Property(c => c.Telefone).HasColumnName("Telefone");

            builder.Property(c => c.Email).HasColumnName("Email");

            builder.ToTable("Aluno");
        }
    }
}