using parcialUno.essentials.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.Factory
{
    /// <summary>
    /// Clase estática que proporciona un método para crear instancias de la clase Venta.
    /// </summary>
    public static class VentaFactory
    {
        /// <summary>
        /// Crea una nueva instancia de Venta.
        /// </summary>
        /// <param name="idComprador">ID del comprador asociado a la venta.</param>
        /// <param name="producto">Producto que se va a vender.</param>
        /// <returns>Una instancia de Venta.</returns>
        public static async Task<Venta> CrearVenta(int idComprador, Producto producto)
        {
            VentaFire ventaFire = new VentaFire();
            int id = await ventaFire.GetUltimoIdAsync() + 1;
            Venta nuevoUsuario = new Venta(id, idComprador, producto);

            return nuevoUsuario;
        }
    }
}
