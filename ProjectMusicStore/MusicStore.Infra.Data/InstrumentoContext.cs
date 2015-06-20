using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Infra.Data
{
     public class InstrumentoContext : DbContext
    {
        public DbSet<Instrumento> Instrumentos { get; set; }
        public DbSet<TipoInstrumento> TipoInstrumentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instrumento>().ToTable("TBInstrumento");
            modelBuilder.Entity<Instrumento>()
                .Property(b => b.Nome)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<TipoInstrumento>().ToTable("TBTipoInstrumento");
            modelBuilder.Entity<TipoInstrumento>()
                .Property(b => b.Descricao)
                .IsRequired()
                .HasMaxLength(200);
           
        }

    }
}

