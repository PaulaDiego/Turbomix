using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class RecetaServiceTest
    {
        [TestMethod]
        public void TestGuardarReceta()
        {
            var MockRecetaRepository= new Mock<IRecetaRepository>();
            IRecetaService sut = new RecetaService(MockRecetaRepository.Object);

            Receta receta = new Receta();
            sut.Guardar(receta);
            MockRecetaRepository.Verify(recetaRepository => recetaRepository.Create(It.IsAny<Receta>()), Times.Once);
        }
    }
}
