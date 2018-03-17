using AvisaNet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avisa.Net.Data.EntityConfiguration
{
    public class OcorreciaEntityCOnfiguration : IEntityTypeConfiguration<Ocorrencia>
    {
        public void Configure(EntityTypeBuilder<Ocorrencia> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .Property(c => c.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder
                .Property(c => c.Mensagem_Id)
                .HasColumnName("Mensagem_Id")
                .IsRequired();

            builder
                .Property(c => c.Pessoa_Id)
                .HasColumnName("Pessoa_Id")
                .IsRequired();

            builder
                .Property(c => c.Veiculo_Id)
                .HasColumnName("Veiculo_Id")
                .IsRequired();


            builder.ToTable("Ocorrencia");
            
        }
    }
}