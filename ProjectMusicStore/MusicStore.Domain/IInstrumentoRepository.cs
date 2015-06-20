using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IInstrumentoRepository
    {
        Instrumento Save(Instrumento instrumento);
        Instrumento Get(int id);
        Instrumento Update(Instrumento instrumento);
        Instrumento Delete(int i);
        List<Instrumento> GetAll();

    }
}
