using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System.Data.Entity;
using MusicStore.Infra.Data;

namespace MusicStore.Tests
{
    [TestClass]
    public class InstrumentoRepositoryTeste
    {
        private IInstrumentoRepository _repository;
        private Instrumento _Instrumento;

        [TestInitialize]
        public void Setup()
        {
            //Inicializa a base da dados, recriando-a
            Database.SetInitializer(new DropCreateDatabaseAlways<InstrumentoContext>());

            //Inicializa os objetos utilizados no teste
            _repository = new InstrumentoRepository();
            _Instrumento = ObjectMother.GetInstrumento();

            //Criar registro inicial na base da dados
            InstrumentoContext context = new InstrumentoContext();
            _Instrumento = context.Instrumentos.Add(_Instrumento);
            context.SaveChanges();
        }

        [TestMethod]
        public void Criando_Um_Teste_De_Persistencia_De_Um_Instrumento()
        {
            //ACTION
            Instrumento InstrumentoPersisted = _repository.Save(_Instrumento);

            //ASSERT
            Assert.IsTrue(InstrumentoPersisted.Id > 0);
        }

        [TestMethod]
        public void RetrieveAInstrumentoPersistedTest()
        {
            //ACTION
            Instrumento persistedInstrumento = _repository.Get(1);

            //ASSERT
            Assert.IsTrue(persistedInstrumento.Id == 1);
            Assert.AreEqual("Guitarra Flying V", persistedInstrumento.Nome);
        }

        [TestMethod]
        public void UpdateAInstrumentoPersistedTest()
        {
            //ARRANGE
            Instrumento persistedInstrumento = _repository.Get(1);
            persistedInstrumento.Nome = "Guitarra SG";


            //ACTION
            Instrumento updatedInstrumento = _repository.Update(persistedInstrumento);

            //ASSERT
            Instrumento Instrumento = _repository.Get(1);
            Assert.AreEqual(Instrumento.Nome, updatedInstrumento.Nome);

        }

        [TestMethod]
        public void DeleteAInstrumentoPersistedTest()
        {
            //ACTION
            Instrumento deletedInstrumento = _repository.Delete(1);

            //ASSERT
            Instrumento Instrumento = _repository.Get(1);
            Assert.IsNull(Instrumento);
        }
    }
}
