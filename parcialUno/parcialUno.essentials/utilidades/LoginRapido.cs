using Google.Cloud.Firestore;
using Google.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.utilidades
{
    public static class LoginRapido
    {
        public static void GuardarLoginData(string username, string password)
        {
            using (BinaryWriter writer =
                new BinaryWriter(File.Open(Constantes.archivoContrasenia, FileMode.Create)))
            {
                writer.Write(username);
                writer.Write(password);
            }
        }

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
        public static void Eliminar()
        {
            if (File.Exists(Constantes.archivoContrasenia))
            {
                File.Delete(Constantes.archivoContrasenia);
            }
        }


    }
}
