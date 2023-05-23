using parcialUno.essentials.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.Factory
{
    /// <summary>
    /// Clase estática que proporciona métodos para crear instancias de la clase Usuario y obtener usuarios existentes.
    /// </summary>
    public static class UsuarioFactory
    {
        /// <summary>
        /// Crea una nueva instancia de Usuario con los datos proporcionados.
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <param name="password">Contraseña del usuario.</param>
        /// <returns>Una instancia de Usuario.</returns>
        public static async Task<Usuario> CrearUsuario(string username, string nombre, string password)
        {
            UsuarioFire usuarioFire = new UsuarioFire();
            int id = await usuarioFire.GetUltimoIdAsync() + 1;
            Usuario nuevoUsuario = new Usuario(id, nombre, username, password);

            return nuevoUsuario;
        }

        /// <summary>
        /// Crea una nueva instancia de Usuario con los datos proporcionados.
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <param name="password">Contraseña del usuario.</param>
        /// <param name="sector">Sector al que pertenece el usuario.</param>
        /// <param name="dinero">Cantidad de dinero del usuario.</param>
        public static async Task<Usuario> CrearUsuario
            (string username, string nombre, string password, string sector, float dinero)
        {
            UsuarioFire usuarioFire = new UsuarioFire();
            int id = await usuarioFire.GetUltimoIdAsync() + 1;
            Usuario nuevoUsuario = new Usuario(id, nombre, username, password, sector, dinero);
            return nuevoUsuario;
        }

        /// <summary>
        /// Obtiene un usuario existente a partir de su ID.
        /// </summary>
        /// <param name="id">ID del usuario.</param>
        /// <returns>Una instancia de Usuario.</returns>
        public static async Task<Usuario> getUsuarioAsync(int id)
        {
            UsuarioFire usuarioFire = new UsuarioFire();
            var usuarioDict = await usuarioFire.GetOneAsync("id", id);
            return new Usuario(usuarioDict);
        }
    }
}
