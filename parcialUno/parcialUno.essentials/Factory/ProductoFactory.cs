using parcialUno.essentials.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.Factory
{
    public static class ProductoFactory
    {
        public async static  Task<Producto> CrearProducto
            (string nombre,
            string descripcion,
            float precio,
            List<string> etiquetas,
            string pathImage,
            int idVendedor)
        {
            ProductoFire productoFire = new ProductoFire();
            int id = await productoFire.GetUltimoIdAsync() + 1;
            var nuevoProducto = new Producto
                (
                    id,
                    nombre,
                    descripcion,
                    precio,
                    etiquetas,
                    pathImage,
                    idVendedor
                );
            await productoFire.AddAsync(nuevoProducto);
            return nuevoProducto;
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
