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
        public static async Task<Usuario> CrearUsuario
            (string username, string nombre, string password, string sector, float dinero)
        {
            UsuarioFire usuarioFire = new UsuarioFire();
            int id = await usuarioFire.GetUltimoIdAsync() + 1;
            Usuario nuevoUsuario = new Usuario(id, nombre, username, password, sector, dinero);
            return nuevoUsuario;
        }
        public static async Task<Usuario> getUsuarioAsync(int id)
        {
            UsuarioFire usuarioFire = new UsuarioFire();
            var usuarioDict = await usuarioFire.GetOneAsync("id", id);
            return new Usuario(usuarioDict);
        }
    }
}
