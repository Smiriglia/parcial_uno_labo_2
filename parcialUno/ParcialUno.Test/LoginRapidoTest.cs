using parcialUno.essentials.utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialUno.Test
{
    [TestClass]
    public class LoginRapidoTest
    {
        [TestInitialize]
        public void Initialize()
        {
            if (File.Exists(Constantes.archivoContrasenia))
            {
                File.Delete(Constantes.archivoContrasenia);
            }
        }

        [TestMethod]
        public void GuardarArchivoExiste()
        {
            string username = "testUser";
            string password = "testPassword";

            LoginRapido.GuardarLoginData(username, password);

            Assert.IsTrue(File.Exists(Constantes.archivoContrasenia));
        }

        [TestMethod]
        public void GuardarArchivoDatosCorrectos()
        {
            string username = "testUser";
            string password = "testPassword";

            using (BinaryWriter writer = new BinaryWriter(File.Open(Constantes.archivoContrasenia, FileMode.Create)))
            {
                writer.Write(username);
                writer.Write(password);
            }

            Dictionary<string, string>? loginData = LoginRapido.CargarLoginData();

            Assert.IsNotNull(loginData);
            Assert.AreEqual(2, loginData.Count);
            Assert.AreEqual(username, loginData["username"]);
            Assert.AreEqual(password, loginData["password"]);
        }

        [TestMethod]
        public void CargarArchivoInexistente()
        {
            
            Dictionary<string, string>? loginData = LoginRapido.CargarLoginData();

            Assert.IsNull(loginData);
        }

        [TestMethod]
        public void EliminarArchivo()
        {
            File.Create(Constantes.archivoContrasenia).Dispose();

            LoginRapido.Eliminar();

            Assert.IsFalse(File.Exists(Constantes.archivoContrasenia));
        }

        [TestMethod]
        public void Eliminar_FileDoesNotExist_DoesNothing()
        {
            LoginRapido.Eliminar();

            Assert.IsFalse(File.Exists(Constantes.archivoContrasenia));
        }
    }
}
