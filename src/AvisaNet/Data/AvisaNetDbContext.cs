using Microsoft.EntityFrameworkCore;
using Avisa.Net.Data.EntityConfiguration;
using Avisa.Net.Models;
using AvisaNet.Models;

namespace Avisa.Net.Data
{
    public class AvisaNetDbContext : DbContext
    {
        
        #region DbSet

        public DbSet<Pessoa> Pessoa { get; set; }

        public DbSet<Mensagem> Mensagem { get; set; }

        public DbSet<MarcaVeiculo> MarcaVeiculo { get; set; }

        public DbSet<ModeloVeiculo> ModeloVeiculo { get; set; }

        public DbSet<Veiculo> Veiculo { get; set; }
        
        #endregion        
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            #region ForeignKeys

            modelBuilder.Entity<Pessoa>()
                .HasOne(s => s.Veiculos)
                .WithMany()
                .HasForeignKey(s => s.Id);
                   


            #endregion



            modelBuilder.Entity<AvisaNetDbContext>().ToTable("db_AvisaNet");

            base.OnModelCreating(modelBuilder);
        }

        public static string ConnectionString { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }
       
    }
}