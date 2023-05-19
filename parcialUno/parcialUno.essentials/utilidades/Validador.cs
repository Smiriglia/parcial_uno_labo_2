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
    public static class Validador
    { 
        public async static Task<Usuario> ValidarUsuario(string username, string password)
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
            throw new UsuarioInvalidoException("Error, No has ingresado un usuario valido");
        }
        public static async Task<Usuario>  ValidadarNuevoUsuarioAsync(string username, string nombre , string password, string password2)
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
    }


}