using MusicStore.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Instrumento : IObjectValidation
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataFabricacao { get; set; }

        public double Valor { get; set; }

        public string TipoInstrumento { get; set; }
        
        public void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new DomainException("Nome inválido");
           // if (TipoInstrumento == null)
           //     throw new DomainException("Tipo inválido");
            if(Valor <= 0)
               throw new DomainException("Valor inválido");
            if(DataFabricacao == null)
               throw new DomainException("Data inválido");
        }
        

    }
}
