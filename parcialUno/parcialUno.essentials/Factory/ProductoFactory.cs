using parcialUno.essentials.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.Factory
{
    /// <summary>
    /// Clase estática que proporciona métodos para crear instancias de la clase Producto.
    /// </summary>
    public static class ProductoFactory
    {
        /// <summary>
        /// Crea una nueva instancia de Producto con los datos proporcionados y lo agrega a la base de datos.
        /// </summary>
        /// <param name="nombre">Nombre del producto.</param>
        /// <param name="descripcion">Descripción del producto.</param>
        /// <param name="precio">Precio del producto.</param>
        /// <param name="etiquetas">Lista de etiquetas del producto.</param>
        /// <param name="pathImage">Ruta de la imagen del producto.</param>
        /// <param name="idVendedor">ID del vendedor del producto.</param>
        /// <returns>Una instancia de Producto.</returns>

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
    }
}
