using parcialUno.essentials.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.Factory
{
    public static class VentaFactory
    {
        public static async Task<Venta> CrearVenta(int idComprador, Producto producto)
        {
            VentaFire ventaFire = new VentaFire();
            int id = await ventaFire.GetUltimoIdAsync() + 1;
            Venta nuevoUsuario = new Venta(id, idComprador, producto);

            return nuevoUsuario;
        }
    }
}
