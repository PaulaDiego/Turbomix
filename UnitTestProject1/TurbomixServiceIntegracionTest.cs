using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;


namespace UnitTestProject1
{
    [TestClass]
    public class TurbomixServiceIntegracionTest
    {
        private Alimento mAlimento1;
        private Alimento mAlimento2;
        private TurbomixService sut;
        private Receta receta;

        private Alimento mAlimentoReceta1;
        private Alimento mAlimentoReceta2;

        [TestInitialize]
        public void Init()
        {
            IBascula basculaService = new BasculaService();
            ICocina cocinaService = new CocinaService();

            sut = new TurbomixService(basculaService, cocinaService);
            mAlimento1 = new Alimento();
            mAlimento1.Nombre = "Curry";
            mAlimento1.Peso = 1.5F;
            mAlimento2 = new Alimento();
            mAlimento2.Nombre = "Queso";
            mAlimento2.Peso = 5F;

            mAlimentoReceta1 = new Alimento();
            mAlimentoReceta1.Nombre = "Curry";
            mAlimentoReceta1.Peso = 1.4F;
            mAlimentoReceta1.Calentado = true;
            mAlimentoReceta2 = new Alimento();
            mAlimentoReceta2.Nombre = "Queso";
            mAlimentoReceta2.Peso = 3F;
            mAlimentoReceta2.Calentado = true;

            receta = new Receta(mAlimentoReceta1, mAlimentoReceta2);
        }


        [TestMethod]
        public void TestPrepararPlato()
        {

            Plato resultado = sut.PrepararPlato(mAlimento1, mAlimento2);

            mAlimentoReceta1.Peso = 1.5F;
            mAlimentoReceta2.Peso = 5F;

            Plato mPlato = new Plato(mAlimentoReceta1, mAlimentoReceta2);
            Assert.AreEqual(mPlato, resultado);
        }

        [TestMethod]
        public void TestPrepararPlatoConReceta()
        {
            Plato resultado = sut.PrepararPlato(mAlimento1, mAlimento2, receta);

            Plato mPlato = new Plato(mAlimentoReceta1, mAlimentoReceta2);
            Assert.AreEqual(mPlato, resultado);
        }

        [TestMethod]
        public void TestGuardarReceta()
        {
            sut.GuardarReceta();
        }
    }
}
