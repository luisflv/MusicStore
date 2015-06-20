using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Application
{
    public interface IInstrumentoService
    {
        Instrumento Create(Instrumento instrumento);
        Instrumento Retrieve(int id);
        Instrumento Update(Instrumento instrumento);
        Instrumento Delete(int id);
        List<Instrumento> RetrieveAll();
    }
}
