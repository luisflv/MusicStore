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
         public InstrumentoContext():base("MusicStoreDB")
         {

         }

        public DbSet<Instrumento> Instrumentos { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instrumento>().ToTable("TBInstrumento");
            modelBuilder.Entity<Instrumento>()
                .Property(b => b.Nome)
                .IsRequired()
                .HasMaxLength(255);

           
           
        }

    }
}

