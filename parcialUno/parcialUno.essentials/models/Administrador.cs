using parcialUno.essentials.abstractas;
using parcialUno.essentials.excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.models
{
    /// <summary>
    /// Clase que representa un administrador.
    /// </summary>
    public class Administrador : Usuario
    {
        /// <summary>
        /// Crea una nueva instancia de la clase Administrador. Con todos los atributos
        /// </summary>
        /// <param name="id">ID del administrador.</param>
        /// <param name="nombre">Nombre del administrador.</param>
        /// <param name="username">Alias administrador.</param>
        /// <param name="password">Contraseña del administrador.</param>
        /// <param name="sector">Sector del administrador.</param>
        public Administrador(int id, string nombre, string username, string password, string sector) : 
            base(id, nombre, username, password, sector)
        {
            if (sector == "comprador")
                throw new UsuarioInvalidoException();
        }

        /// <summary>
        /// Crea una nueva instancia de la clase Administrador a partir de un diccionario
        /// </summary>
        /// <param name="adminDict">Diccionario con los datos del administrador.</param>
        public Administrador(Dictionary<string, object> adminDict) : base(adminDict) { }

        /// <summary>
        /// Modifica los datos de un usuario. En la base de datos FireBase
        /// </summary>
        /// <param name="usuario">Usuario a modificar.</param>
        /// <param name="username">Nuevo nombre de usuario.</param>
        /// <param name="password">Nueva contraseña.</param>
        /// <param name="txtDinero">Nuevo dinero.</param>
        /// <param name="nombre">Nuevo nombre.</param>
        /// <param name="sector">Nuevo sector.</param>
        /// <returns>Tarea asincrónica.</returns>
        /// <exception cref="UsuarioInvalidoException">Se lanza si hay un error en alguno de los campos modificados.</exception>
        public async Task ModificarUsuarioAsync
            (
            Usuario? usuario,
            string username,
            string password,
            string txtDinero,
            string nombre,
            string sector
            )
        {
            float dinero;
            UsuarioFire usuarioFire = new UsuarioFire();
            bool usuarioTomado = await usuarioFire.ContieneAsync(username, "username");
            if (float.TryParse(txtDinero, out dinero) &&
                username != "" &&
                sector != "" &&
                !usuarioTomado)
            {
                Dictionary<string, object> modificaciones = new()
                {
                    { "username", username},
                    { "password", password },
                    { "dinero", dinero },
                    { "nombre", nombre },
                    { "sector", sector }
                };
                
                await ModificarUsuarioAsync(usuario, modificaciones);
            }
            else
                throw new UsuarioInvalidoException("Error con alguno de los campos modificados");
        }

        /// <summary>
        /// Elimina un usuario(Baja logica). En la base de datos FireBase
        /// </summary>
        /// <param name="usuario">Usuario a eliminar.</param>
        /// <returns>Tarea asincrónica.</returns>
        public async Task EliminarUsuarioAsync(Usuario? usuario)
        {
            Dictionary<string, object> modificacion = new()
            {
                { "sector", "eliminado"}
            };
            await ModificarUsuarioAsync(usuario, modificacion);
        }

        /// <summary>
        /// Modifica los datos de un usuario. En la base de datos FireBase
        /// </summary>
        /// <param name="usuario">Usuario a modificar.</param>
        /// <param name="modificaciones">Diccionario con las modificaciones a aplicar.</param>
        /// <returns>Tarea asincrónica.</returns>
        public async Task ModificarUsuarioAsync(Usuario? usuario, Dictionary<string, object> modificaciones)
        {
            UsuarioFire usuarioFire = new UsuarioFire();
            await ModificarElementoAsync(usuarioFire, usuario, modificaciones);
        }

        /// <summary>
        /// Modifica los datos de una venta. En la base de datos FireBase
        /// </summary>
        /// <param name="venta">Venta a modificar.</param>
        /// <param name="modificaciones">Diccionario con las modificaciones a aplicar.</param>
        /// <returns>Tarea asincrónica.</returns>
        public async Task ModificarVentaAsync(Venta? venta, Dictionary<string, object> modificaciones)
        {
            VentaFire ventaFire = new VentaFire();
            await ModificarElementoAsync(ventaFire, venta, modificaciones);
        }

        /// <summary>
        /// Modifica los datos de un producto. En la base de datos FireBase
        /// </summary>
        /// <param name="producto">Producto a modificar.</param>
        /// <param name="modificaciones">Diccionario con las modificaciones a aplicar.</param>
        /// <returns>Tarea asincrónica.</returns>
        public async Task ModificarProductoAsync(Producto? producto, Dictionary<string, object> modificaciones)
        {
            ProductoFire productoFire = new ProductoFire();
            await ModificarElementoAsync(productoFire, producto, modificaciones);
        }

        /// <summary>
        /// Elimina un producto (Baja Logica). En la base de datos FireBase
        /// </summary>
        /// <param name="producto">Producto a eliminar.</param>
        /// <returns>Tarea asincrónica.</returns>
        public async Task EliminarProductoAsync(Producto? producto)
        {
            Dictionary<string, object> modificacion = new()
            {
                {"estado", "eliminado" }
            };
            await ModificarProductoAsync(producto, modificacion);
        }

        /// <summary>
        /// Modifica los datos de un producto. En la base de datos FireBase
        /// </summary>
        /// <param name="elemento">Producto a modificar.</param>
        /// <param name="nombre">Nuevo nombre del producto.</param>
        /// <param name="descripcion">Nueva descripción del producto.</param>
        /// <param name="txtPrecio">Nuevo precio del producto.</param>
        /// <param name="imagePath">Nuevo path de la imagen del producto.</param>
        /// <param name="estado">Nuevo estado del producto.</param>
        /// <param name="txtIdVendedor">Nuevo ID del vendedor del producto.</param>
        /// <returns>Tarea asincrónica.</returns>
        /// <exception cref="UsuarioInvalidoException">Se lanza si hay un error en alguno de los campos modificados.</exception>
        public async Task ModificarProductoAsync
            (
            Producto? elemento,
            string nombre,
            string descripcion,
            string txtPrecio,
            string imagePath,
            string estado,
            string txtIdVendedor
            )
        {
            float precio;
            int idVendedor;
            if (!(elemento is null) &&
                float.TryParse(txtPrecio, out precio) &&
                int.TryParse(txtIdVendedor, out idVendedor))
            {
                Dictionary<string, object> modificaciones = new()
                {
                    { "nombre", nombre},
                    { "descripcion", descripcion },
                    { "precio", precio },
                    { "imagePath", imagePath },
                    { "estado", estado },
                    { "idVendedor", idVendedor }
                };
                ProductoFire productoFire = new ProductoFire();


                await productoFire.ModAsync(elemento, modificaciones);
            }
            else
                throw new UsuarioInvalidoException("Error con alguno de los campos modificados");
        }
        private async Task ModificarElementoAsync(FireBase conexion,ITransformable? elemento, Dictionary<string, object> modificaciones)
        {
            if (!(elemento is null))
                await conexion.ModAsync(elemento, modificaciones);
            else
                throw new Exception("Error, Elemento Inexistente");
        }
    }
}
