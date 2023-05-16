using parcialUno.essentials.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.utilidades
{
    public static class Validador
    { 
        public async static Task<Usuario?> ValidarUsuario(string username, string password)
        {
            UsuarioFire usuarioFire = new UsuarioFire();
            if (await usuarioFire.ContieneAsync(username, "username"))
            {
                var usuarioDict = await usuarioFire.GetOneAsync("username", username);
                if ((string)usuarioDict["password"] == password)
                {
                    return new Usuario(usuarioDict);
                }
            }
            return null;
        }
    }
}
