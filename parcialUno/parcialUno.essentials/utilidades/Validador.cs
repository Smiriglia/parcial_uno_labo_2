using parcialUno.essentials.excepciones;
using parcialUno.essentials.Factory;
using parcialUno.essentials.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.utilidades
{
    /// <summary>
    /// Clase estática que proporciona métodos para validar usuarios y crear nuevos usuarios.
    /// </summary>
    public static class Validador
    {
        /// <summary>
        /// Valida un usuario existente en base al nombre de usuario y contraseña proporcionados.
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <param name="password">Contraseña.</param>
        /// <returns>Un objeto Usuario válido si la validación es exitosa.</returns>
        /// <exception cref="UsuarioInvalidoException">Se produce cuando no se ha ingresado un usuario válido.</exception>
        public async static Task<Usuario> ValidarUsuario(string username, string password)
        {
            UsuarioFire usuarioFire = new UsuarioFire();
            string sector;
            string password_ingresada;

            if (await usuarioFire.ContieneAsync(username, "username"))
            {
                var usuarioDict = await usuarioFire.GetOneAsync("username", username);
                password_ingresada = (string)usuarioDict["password"];
                if (password_ingresada == password)
                {
                    sector = (string)usuarioDict["sector"];
                    if (sector == "eliminado")
                        throw new UsuarioInvalidoException("Error, Ese usuario ha sido eliminado");
                    else if (sector == "comprador")
                        return new Usuario(usuarioDict);
                    else
                        return new Administrador(usuarioDict);
                }
            }
            throw new UsuarioInvalidoException("Error, No has ingresado un usuario valido");
        }

        /// <summary>
        /// Valida y crea un nuevo usuario en base a los datos proporcionados. Y lo añade a la base de datos FireBase
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <param name="password">Contraseña.</param>
        /// <param name="password2">Confirmación de contraseña.</param>
        /// <returns>Un objeto Usuario válido si la validación es exitosa y el usuario se crea correctamente.</returns>
        /// <exception cref="UsuarioInvalidoException">Se produce cuando se proporciona información inválida para crear el usuario.</exception>
        /// <exception cref="ContraseñasNoCoincidenException">Se produce cuando la contraseña y la confirmación de contraseña no coinciden.</exception>
        /// <exception cref="UsuarioTomadoException">Se produce cuando el nombre de usuario ya ha sido tomado.</exception>
        public static async Task<Usuario> ValidarNuevoUsuarioAsync(string username, string nombre , string password, string password2)
        {
            if (nombre == "")
                throw new UsuarioInvalidoException("Error, El nombre no puede ser vacio");
            else if (username == "")
                throw new UsuarioInvalidoException("Error, El nombre de usuario no puede ser vacio");
            else if (password == "" || password2 == "")
                throw new UsuarioInvalidoException("Error, la contraseña puede estar vacia");
            else if (password != password2)
                throw new ContraseñasNoCoincidenException("Error, La Contraseña y la confirmacion Deben coincidir");
            
            Usuario nuevoUsuario = await UsuarioFactory.CrearUsuario(username, nombre, password);
            UsuarioFire usuarioFire = new UsuarioFire();
            bool usuarioCreado =  await usuarioFire.AddAsync(nuevoUsuario, "username");
            if (usuarioCreado)
                return nuevoUsuario;

            throw new UsuarioTomadoException("Error, El nombre de usuario que quieres utilizar ya ha sido tomado");
        }

        /// <summary>
        /// Valida y crea un nuevo usuario en base a los datos proporcionados.
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <param name="password">Contraseña.</param>
        /// <param name="txtDinero">Confirmación de contraseña.</param>
        /// <returns>Un objeto Usuario válido si la validación es exitosa y el usuario se crea correctamente.</returns>
        /// <exception cref="UsuarioInvalidoException">Se produce cuando se proporciona información inválida para crear el usuario.</exception>
        /// <exception cref="UsuarioTomadoException">Se produce cuando el nombre de usuario ya ha sido tomado.</exception>
        public static async Task<Usuario> ValidarNuevoUsuarioAsync
            (string username, string nombre, string password, string sector, string txtDinero)
        {
            float dinero;
            if (nombre == "")
                throw new UsuarioInvalidoException("Error, El nombre no puede ser vacio");
            else if (username == "")
                throw new UsuarioInvalidoException("Error, El nombre de usuario no puede ser vacio");
            else if (password == "" )
                throw new UsuarioInvalidoException("Error, la contraseña puede estar vacia");
            else if (!(float.TryParse(txtDinero, out dinero)))
                throw new UsuarioInvalidoException("Error, El dinero tiene un formato incorrecto");
            else if (sector == "")
                throw new UsuarioInvalidoException("Error, sector no puede estar vacio");

            Usuario nuevoUsuario = await UsuarioFactory.CrearUsuario(username, nombre, password, sector, dinero);
            UsuarioFire usuarioFire = new UsuarioFire();
            bool usuarioCreado = await usuarioFire.AddAsync(nuevoUsuario, "username");
            if (usuarioCreado)
                return nuevoUsuario;

            throw new UsuarioTomadoException("Error, El nombre de usuario que quieres utilizar ya ha sido tomado");
        }
    }


}