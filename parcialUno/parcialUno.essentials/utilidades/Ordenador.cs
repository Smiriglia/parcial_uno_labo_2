using parcialUno.essentials.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.utilidades
{
    public static class Ordenador
    {
        public static async Task OrdenarPorRelevancia(ListaProductos productos, int idUsuario)
        {
            ListaVistaProducto vpList = new ListaVistaProducto();
            Dictionary<string, float> dictRelevancia = vpList.CalcularRelevancia();


            await vpList.CargarFireAsync(idUsuario);
            dictRelevancia = vpList.CalcularRelevancia();

            productos.CalcularRelevancia(dictRelevancia);
            productos.OrdenarPorRelevancia();
        }
    }
}
