using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Turbomix;
using Moq;
using Turbomix;

namespace TurbomixTest
{
    [TestClass]
    public class RecetaServiceTest
    {
        
        [TestMethod]
        public void TestGuardar()
        {
            var MockRecetaRepository = new Mock<IRecetaRepository>();
            var MockCategoriaService = new Mock<ICategoriaRecetaService>();
            IRecetaService sut = new RecetaService(MockRecetaRepository.Object, MockCategoriaService.Object);

            Receta receta = new Receta();
            sut.Guardar(receta);
            MockRecetaRepository.Verify(recetaRepository => recetaRepository.Create(It.IsAny<Receta>()), Times.Once);
        }
        [TestMethod]
        public void TestLeer()
        {
            var MockRecetaRepository = new Mock<IRecetaRepository>();
            var MockCategoriaService = new Mock<ICategoriaRecetaService>();
            IRecetaService sut = new RecetaService(MockRecetaRepository.Object, MockCategoriaService.Object);
            sut.Lee("");
            MockRecetaRepository.Verify(recetaRepository => recetaRepository.Lee(It.IsAny<String>()), Times.Once);
        }

        [TestMethod]
        public void TestLista()
        {
            var MockRecetaRepository = new Mock<IRecetaRepository>();
            var MockCategoriaService = new Mock<ICategoriaRecetaService>();
            IRecetaService sut = new RecetaService(MockRecetaRepository.Object, MockCategoriaService.Object);
            sut.Lista();
            MockRecetaRepository.Verify(recetaRepository => recetaRepository.Lista(), Times.Once);
        }

        [TestMethod]
        public void TestUpdate()
        {
            var MockRecetaRepository = new Mock<IRecetaRepository>();
            var MockCategoriaService = new Mock<ICategoriaRecetaService>();
            IRecetaService sut = new RecetaService(MockRecetaRepository.Object, MockCategoriaService.Object);
            sut.Update("a","b");
            MockRecetaRepository.Verify(recetaRepository => recetaRepository.Update(It.IsAny<String>(), It.IsAny<String>()), Times.Once);
        }

        [TestMethod]
        public void TestDelete()
        {
            var MockRecetaRepository = new Mock<IRecetaRepository>();
            var MockCategoriaService = new Mock<ICategoriaRecetaService>();
            IRecetaService sut = new RecetaService(MockRecetaRepository.Object, MockCategoriaService.Object);
            sut.Delete("a");
            MockRecetaRepository.Verify(recetaRepository => recetaRepository.Delete(It.IsAny<String>()), Times.Once);
        }
    }
}
