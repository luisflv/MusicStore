using Domain;
using MusicStore.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Application
{
    public class InstrumentoService : IInstrumentoService
    {

        private IInstrumentoRepository _instrumentoRepository;

        public InstrumentoService(IInstrumentoRepository InstrumentoRepository)
        {
            _instrumentoRepository = InstrumentoRepository;
        }

        public Instrumento Create(Instrumento Instrumento)
        {
            Validator.Validate(Instrumento);

            var savedInstrumento = _instrumentoRepository.Save(Instrumento);

            return savedInstrumento;
        }


        public Instrumento Retrieve(int id)
        {
            return _instrumentoRepository.Get(id);
        }


        public Instrumento Update(Instrumento Instrumento)
        {
            Validator.Validate(Instrumento);

            var updatedInstrumento = _instrumentoRepository.Update(Instrumento);

            return updatedInstrumento;
        }


        public Instrumento Delete(int id)
        {
            return _instrumentoRepository.Delete(id);
        }


        public List<Instrumento> RetrieveAll()
        {
            return _instrumentoRepository.GetAll();
        }

    }
}
