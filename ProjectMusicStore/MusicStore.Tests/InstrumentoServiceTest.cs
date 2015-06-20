using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using MusicStore.Application;
using Moq;
using MusicStore.Infra;

namespace MusicStore.Tests
{
    [TestClass]
    public class InstrumentoServiceTest
    {
        private Instrumento _Instrumento;


        [TestMethod]
        public void Criando_Um_Servico_InstrumentoService_Test()
        {
            _Instrumento = ObjectMother.GetInstrumento();

            //ARRANGE - Criado Mock do Repositório para simular a persistência de dados
            var repository = new Mock<IInstrumentoRepository>();

            repository.Setup(r => r.Save(_Instrumento)).Returns(_Instrumento);

            //ARRANGE - Instancia do serviço a ser testado
            IInstrumentoService service = new InstrumentoService(repository.Object);

            //ARRANGE - Criado Mock para simular a validação do Customer
            var validation = new Mock<Instrumento>();

            validation.As<IObjectValidation>().Setup(Instrumento => Instrumento.Validate());

            //ACTION
            service.Create(validation.Object);

            //ASSERT
            validation.As<IObjectValidation>().Verify(x => x.Validate());
        }
    }
}
