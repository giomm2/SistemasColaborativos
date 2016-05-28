using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica.Negocio;

namespace Calculadora.Tests
{
    [TestClass]
    public class Sumas
    {
        [TestMethod]
        public void SumarUnoMasDos()
        {
            //Paso 1: Defina el escenario de la prueba
            var elPrimerOperando = 1;
            var elSegundoOperando = 2;
            var elResultadoEsperado = 3;

            //Paso 2: Invoque al metodo que se desea validar.
            var laSuma = new Suma();
            var elResultado = laSuma.Operar(elPrimerOperando, elSegundoOperando);

            //Paso 3: Verificar o comparar el resltado obtenido con el esperado.
            Assert.AreEqual(elResultadoEsperado,elResultado);


        }
    }
}
