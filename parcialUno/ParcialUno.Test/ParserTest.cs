using parcialUno.essentials.utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialUno.Test
{
    [TestClass]
    public class ParserTest
    {
        [TestMethod]
        public void ValidarNulo()
        {
            List<object> lista = new List<object> { 1, "dos", 3.5, true };

            List<string> resultado = Parser.ToStringList(lista);

            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void ValidarCantidadElementos()
        {
            List<object> lista = new List<object> { 1, "dos", 3.5, true };

            List<string> resultado = Parser.ToStringList(lista);

            Assert.AreEqual(lista.Count, resultado.Count);

        }

        [TestMethod]
        public void ValidarResultadoCorrecto()
        {
            List<object> lista = new List<object> { 1, "dos", 3.5, true };

            List<string> resultado = Parser.ToStringList(lista);

            List<string> listaEsperada = new List<string> { "1", "dos", "3,5", "True" };

            CollectionAssert.AreEqual(listaEsperada, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void ToStringList_ListWithNullValues_ReturnsStringListWithNullValues()
        {
            List<object> lista = new List<object> { 1, null, "texto", null };

            List<string> resultado = Parser.ToStringList(lista);
        }

        [TestMethod]
        public void ValidarListaVacia()
        {
            List<object> lista = new List<object>();

            List<string> resultado = Parser.ToStringList(lista);

            Assert.IsNotNull(resultado);
            Assert.AreEqual(0, resultado.Count);
        }
    }
}
