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
            ITransformable? elemento,
            string username,
            string password,
            string txtDinero,
            string nombre,
            string sector
            )
        {
            float dinero;
            if (!(elemento is null) && float.TryParse(txtDinero, out dinero))
            {
                Dictionary<string, object> modificaciones = new()
                {
                    { "username", username},
                    { "password", password },
                    { "dinero", dinero },
                    { "nombre", nombre },
                    { "sector", sector }
                };
                UsuarioFire usuarioFire = new UsuarioFire();


                await usuarioFire.ModAsync(elemento, modificaciones);
            }
            else
                throw new UsuarioInvalidoException("Error con alguno de los campos modificados");
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

        private async Task ModificarElementoAsync(FireBase conexion,ITransformable? elemento, Dictionary<string, object> modificaciones)
        {
            if (!(elemento is null))
                await conexion.ModAsync(elemento, modificaciones);
            else
                throw new Exception("Error, Elemento Inexistente");
        }
    }
}
