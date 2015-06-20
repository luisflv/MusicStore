using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using MusicStore.Infra;

namespace MusicStore.Tests
{
    [TestClass]
    public class InstrumentoDomainTest
    {
        [TestMethod]
        public void Criando_Um_Instrumento_Musical()
        {
            Instrumento instrumento = ObjectMother.GetInstrumento();

            Assert.IsNotNull(instrumento);

        }


        [TestMethod]
        [ExpectedException(typeof(DomainException))]
        public void Criando_Um_Instrumento_Com_Nome_Invalido()
        {
            Instrumento instrumento = new Instrumento();
            Validator.Validate(instrumento);
        }

        [TestMethod]
        [ExpectedException(typeof(DomainException))]
        public void Criando_Um_Instrumento_Com_Valor_Menor_Que_Zero()
        {
            Instrumento instrumento = new Instrumento();
            instrumento.Valor = -1;
            Validator.Validate(instrumento);
        }

    }
}
