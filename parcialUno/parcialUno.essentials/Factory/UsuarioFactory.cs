using parcialUno.essentials.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.Factory
{
    public static class UsuarioFactory
    {
        public static async Task<Usuario> CrearUsuario(string username, string nombre, string password)
        {
            UsuarioFire usuarioFire = new UsuarioFire();
            int id = await usuarioFire.GetUltimoIdAsync() + 1;
            Usuario nuevoUsuario = new Usuario(id, nombre, username, password);

            return nuevoUsuario;
        }
    }
}
