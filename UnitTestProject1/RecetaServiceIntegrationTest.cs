using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;
using Moq;
using Microsoft.Practices.Unity;

namespace UnitTestProject1
{
    [TestClass]
    public class RecetaServiceIntegrationTest
    {
        private IUnityContainer container;
        private IRecetaRepository RecetaRepository;
        private IRecetaService sut;
      [TestInitialize]
        public void Init() {
            container = new UnityContainer();
            container.RegisterType<IRecetaService, RecetaService>();
            container.RegisterType<IRecetaRepository, RecetaRepository>();
            RecetaRepository = container.Resolve<IRecetaRepository>();
            sut = container.Resolve<IRecetaService>();
        }   
        [TestMethod]
        public void TestGuardar()
        {
            Receta receta = new Receta(null, null);
            
            
            sut.Guardar(receta);
        }

        [TestMethod]
        public void TestLeer()
        {
           
            sut.Lee("a");
        }

        [TestMethod]
        public void TestLista()
        {
            sut.Lista();
        }

        [TestMethod]
        public void TestUpdate()
        {
           
            sut.Update("a","b");
        }

        [TestMethod]
        public void TestDelete()
        {
            sut.Delete("a");
        }
    }
}
