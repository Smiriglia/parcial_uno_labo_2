using parcialUno.essentials.abstractas;
using parcialUno.essentials.excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.models
{
    public class Administrador : Usuario
    {
        public Administrador(int id, string nombre, string username, string password, string sector) : 
            base(id, nombre, username, password, sector)
        {
            if (sector == "comprador")
                throw new UsuarioInvalidoException();
        }

        public Administrador(Dictionary<string, object> adminDict) : base(adminDict) { }

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

        public async Task EliminarUsuarioAsync(Usuario? usuario)
        {
            Dictionary<string, object> modificacion = new()
            {
                { "sector", "eliminado"}
            };
            await ModificarUsuarioAsync(usuario, modificacion);
        }

        public async Task ModificarUsuarioAsync(Usuario? usuario, Dictionary<string, object> modificaciones)
        {
            UsuarioFire usuarioFire = new UsuarioFire();
            await ModificarElementoAsync(usuarioFire, usuario, modificaciones);
        }

        public async Task ModificarVentaAsync(Venta? venta, Dictionary<string, object> modificaciones)
        {
            VentaFire ventaFire = new VentaFire();
            await ModificarElementoAsync(ventaFire, venta, modificaciones);
        }

        public async Task ModificarProductoAsync(Producto? producto, Dictionary<string, object> modificaciones)
        {
            ProductoFire productoFire = new ProductoFire();
            await ModificarElementoAsync(productoFire, producto, modificaciones);
        }

        public async Task EliminarProductoAsync(Producto? producto)
        {
            Dictionary<string, object> modificacion = new()
            {
                {"estado", "eliminado" }
            };
            await ModificarProductoAsync(producto, modificacion);
        }

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
