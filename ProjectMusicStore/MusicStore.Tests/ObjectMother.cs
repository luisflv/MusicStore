using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Tests
{
    public static class ObjectMother
    {


        public static Instrumento GetInstrumento()
        {
            Instrumento instrumento = new Instrumento();
            instrumento.Nome = "Guitarra Flying V";
            instrumento.DataFabricacao = new DateTime(1992, 09, 18);
            instrumento.TipoInstrumento = "Corda";
                


            return instrumento;
        }






    }
}
