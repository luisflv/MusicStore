using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Infra.Data
{
    public class InstrumentoRepository : IInstrumentoRepository
    {
        private InstrumentoContext context;

        public InstrumentoRepository()
        {
            context = new InstrumentoContext();
        }

        public Instrumento Save(Instrumento instrumento)
        {
            var newInstrumento = context.Instrumentos.Add(instrumento);
            context.SaveChanges();
            return newInstrumento;
        }


        public Instrumento Get(int id)
        {
            var instrumento = context.Instrumentos.Find(id);
            return instrumento;
        }


        public Instrumento Update(Instrumento instrumento)
        {
            DbEntityEntry entry = context.Entry(instrumento);
            entry.State = EntityState.Modified;
            context.SaveChanges();
            return instrumento;
        }


        public Instrumento Delete(int id)
        {
            var instrumento = context.Instrumentos.Find(id);
            DbEntityEntry entry = context.Entry(instrumento);
            entry.State = EntityState.Deleted;
            context.SaveChanges();
            return instrumento;
        }


        public List<Instrumento> GetAll()
        {
            return context.Instrumentos.ToList();
        }
    }
}
