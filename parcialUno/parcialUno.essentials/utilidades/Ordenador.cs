using parcialUno.essentials.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.utilidades
{
    /// <summary>
    /// Clase estática que proporciona métodos para ordenar listas de productos.
    /// </summary>
    public static class Ordenador
    {
        /// <summary>
        /// Ordena una lista de productos por relevancia.
        /// </summary>
        /// <param name="productos">Lista de productos a ordenar.</param>
        /// <param name="idUsuario">ID del usuario para calcular la relevancia.</param>
        /// <returns>Una tarea que representa la operación de ordenación.</returns>
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
