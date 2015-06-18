using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Instrumento
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataFabricacao { get; set; }

        public double Valor { get; set; }

        public TipoInstrumento MyProperty { get; set; }

        public void Validate()
        {

        }


    }
}
