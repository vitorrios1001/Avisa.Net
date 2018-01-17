using Avisa.Net.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avisa.Net.Data.EntityConfiguration
{
    public class MensagemEntityCOnfiguration : IEntityTypeConfiguration<Mensagem>
    {
        public void Configure(EntityTypeBuilder<Mensagem> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();

            builder.Property(c => c.DescricaoCurta).HasColumnName("DescCurta").IsRequired();

            builder.Property(c => c.DescricaoLonga).HasColumnName("DescLonga");

            builder.ToTable("Mensagem");
            
        }
    }
}