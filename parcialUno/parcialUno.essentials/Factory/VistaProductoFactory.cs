using parcialUno.essentials.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.Factory
{
    /// <summary>
    /// Clase estática que proporciona un método para crear instancias de la clase VistaProducto.
    /// </summary>
    public static class VistaProductoFactory
    {
        /// <summary>
        /// Crea una nueva instancia de VistaProducto.
        /// </summary>
        /// <param name="idUsuario">ID del usuario que visualizó el producto.</param>
        /// <param name="productoVisto">Producto visualizado.</param>
        /// <returns>Una instancia de VistaProducto si se crea correctamente, o null en caso contrario.</returns>
        public static async Task<VistaProducto?> Crear(int idUsuario, Producto productoVisto)
        {
            try
            {

                VistaProductoFire vpFire = new VistaProductoFire();
                int idVistaProducto = await vpFire.GetUltimoIdAsync() + 1;
                VistaProducto nuevaVP = new VistaProducto(idVistaProducto, idUsuario, productoVisto);
                return nuevaVP;
            }
            catch
            {
                return null;
            }
        }
    }
}
