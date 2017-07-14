using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class RecetaServiceIntegrationTest
    {
        [TestMethod]
        public void TestGuardarReceta()
        {
            Receta receta = new Receta(null, null);
            IRecetaRepository RecetaRepository = new RecetaRepository();
            IRecetaService sut = new RecetaService(RecetaRepository);
            
            sut.Guardar(receta);
        }
    }
}
