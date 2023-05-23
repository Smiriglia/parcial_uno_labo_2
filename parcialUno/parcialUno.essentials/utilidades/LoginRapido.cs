using Google.Cloud.Firestore;
using Google.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.utilidades
{
    /// <summary>
    /// Clase estática que proporciona métodos para guardar, cargar y eliminar datos de inicio de sesión de forma rápida.
    /// </summary>
    public static class LoginRapido
    {
        /// <summary>
        /// Guarda los datos de inicio de sesión en un archivo binario.
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <param name="password">Contraseña.</param>
        public static void GuardarLoginData(string username, string password)
        {
            using (BinaryWriter writer =
                new BinaryWriter(File.Open(Constantes.archivoContrasenia, FileMode.Create)))
            {
                writer.Write(username);
                writer.Write(password);
            }
        }

        /// <summary>
        /// Carga los datos de inicio de sesión desde un archivo binario.
        /// </summary>
        /// <returns>
        /// Un diccionario con los datos de inicio de sesión (nombre de usuario y contraseña) |
        /// null: si el archivo no existe.
        /// </returns>
        public static Dictionary<string, string>? CargarLoginData()
        {
            if (File.Exists(Constantes.archivoContrasenia))
            {
                using (BinaryReader reader =
                    new BinaryReader(File.Open(Constantes.archivoContrasenia, FileMode.Open)))
                {
                    string username = reader.ReadString();
                    string password = reader.ReadString();
                    Dictionary<string, string> datos = new()
                    {
                        { "username", username },
                        { "password", password }
                    };

                    return datos;
                }
            }

            return (null);
        }

        /// <summary>
        /// Elimina el archivo de datos de inicio de sesión.
        /// </summary>
        public static void Eliminar()
        {
            if (File.Exists(Constantes.archivoContrasenia))
            {
                File.Delete(Constantes.archivoContrasenia);
            }
        }


    }
}
