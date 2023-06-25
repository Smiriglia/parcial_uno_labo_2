using parcialUno.essentials.excepciones;
using parcialUno.essentials.utilidades;
using System.ComponentModel.DataAnnotations;

namespace ParcialUno.Test
{
    [TestClass]
    public class ValidarNuevoUsuarioTest
    {
        [TestClass]
        public class ValidadorTests
        {
            [TestMethod]
            public async Task ValidarNulo()
            {
                string username = "testuser1";
                string nombre = "Test User2";
                string password = "testpassword";
                string sector = "comprador";
                string txtDinero = "100,50";

                var usuario = await Validador.ValidarNuevoUsuarioAsync(username, nombre, password, sector, txtDinero);

                Assert.IsNotNull(usuario);
            }

            [TestMethod]
            public async Task ValidarDatosCorrespondientes()
            {
                string username = "testuser2";
                string nombre = "Test User2";
                string password = "testpassword";
                string sector = "comprador";
                string txtDinero = "100,50";

                var usuario = await Validador.ValidarNuevoUsuarioAsync(username, nombre, password, sector, txtDinero);

                Assert.AreEqual(username, usuario.Username);
                Assert.AreEqual(nombre, usuario.Nombre);
                Assert.AreEqual(sector, usuario.Sector);
                Assert.AreEqual(100.50f, usuario.Dinero);
            }

            [TestMethod]
            [ExpectedException(typeof(UsuarioInvalidoException))]
            public async Task ValidarUsuarioInvalidoNombre()
            {
                string username = "usuarioInvalido";
                string nombre = "";
                string password = "123";
                string sector = "comprador";
                string txtDinero = "100.50";

                var usuario = await Validador.ValidarNuevoUsuarioAsync(username, nombre, password, sector, txtDinero);
            }

            [TestMethod]
            [ExpectedException(typeof(UsuarioInvalidoException))]
            public async Task ValidarUsuarioInvalidoPassword()
            {
                string username = "usuarioInvalido";
                string nombre = "juan";
                string password = "";
                string sector = "comprador";
                string txtDinero = "100.50";

                var usuario = await Validador.ValidarNuevoUsuarioAsync(username, nombre, password, sector, txtDinero);
            }

            [TestMethod]
            [ExpectedException(typeof(UsuarioInvalidoException))]
            public async Task ValidarUsuarioInvalidoUsername()
            {
                string username = "";
                string nombre = "juan";
                string password = "123";
                string sector = "comprador";
                string txtDinero = "100.50";

                var usuario = await Validador.ValidarNuevoUsuarioAsync(username, nombre, password, sector, txtDinero);
            }

            [TestMethod]
            [ExpectedException(typeof(UsuarioInvalidoException))]
            public async Task ValidarUsuarioInvalidoSector()
            {
                string username = "usuarioInvalido";
                string nombre = "juan";
                string password = "123";
                string sector = "";
                string txtDinero = "100.50";

                var usuario = await Validador.ValidarNuevoUsuarioAsync(username, nombre, password, sector, txtDinero);
            }

            [TestMethod]
            [ExpectedException(typeof(UsuarioInvalidoException))]
            public async Task ValidarUsuarioInvalidoDineroVacio()
            {
                string username = "usuarioInvalido";
                string nombre = "juan";
                string password = "123";
                string sector = "comprador";
                string txtDinero = "";

                var usuario = await Validador.ValidarNuevoUsuarioAsync(username, nombre, password, sector, txtDinero);
            }

            [TestMethod]
            [ExpectedException(typeof(UsuarioInvalidoException))]
            public async Task ValidarUsuarioInvalidoDineroNoNumerico()
            {
                string username = "usuarioInvalido";
                string nombre = "juan";
                string password = "123";
                string sector = "comprador";
                string txtDinero = "abc";

                var usuario = await Validador.ValidarNuevoUsuarioAsync(username, nombre, password, sector, txtDinero);
            }

            [TestMethod]
            [ExpectedException(typeof(UsuarioTomadoException))]
            public async Task ValidarUsuarioTomado()
            {
                string username = "usuarioExistente";
                string nombre = "Existing User";
                string password = "testpassword";
                string sector = "comprador";
                string txtDinero = "100.50";

                var usuario = await Validador.ValidarNuevoUsuarioAsync(username, nombre, password, sector, txtDinero);
            }
        }
    }
}