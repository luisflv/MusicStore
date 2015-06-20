using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

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
    }
}
