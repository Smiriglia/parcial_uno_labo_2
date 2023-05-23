using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.models
{
    /// <summary>
    /// Clase que representa una lista de vista productos pero facilitando 
    /// metodos propios y abstractos y encapsulando logica a la que no se quiere
    /// que el usuario acceda
    /// </summary>
    public class ListaVistaProducto
    {

        private List<VistaProducto> _vistaProductos;

        /// <summary>
        /// Constructor de la clase ListaVistaProducto. Crea la lista
        /// </summary>
        public ListaVistaProducto()
        {
            _vistaProductos = new List<VistaProducto>();
        }

        /// <summary>
        /// Calcula la relevancia de las etiquetas de los productos vistos en la lista.
        /// </summary>
        /// <returns>Un diccionario que contiene las etiquetas y su relevancia.</returns>
        public Dictionary<string, float> CalcularRelevancia()
        {
            Dictionary<string, float> valorPorEtiqueta = new Dictionary<string, float>();
            float relevanciaPorFecha;
            TimeSpan tiempoTranscurrido;
            int mesesTranscurridos;
            foreach (var vp in _vistaProductos)
            {
                tiempoTranscurrido = DateTime.Now - vp.Fecha;
                mesesTranscurridos = tiempoTranscurrido.Days / 30;
                relevanciaPorFecha = 1 / (mesesTranscurridos + 1);
                foreach (string etiqueta in vp.Etiquetas)
                {

                    if (valorPorEtiqueta.ContainsKey(etiqueta))
                    {
                        valorPorEtiqueta[etiqueta] += relevanciaPorFecha;
                    }
                    else
                    {
                        valorPorEtiqueta.Add(etiqueta, relevanciaPorFecha);
                    }
                }
            }
            return valorPorEtiqueta;
        }

        /// <summary>
        /// Carga los datos de los productos vistos desde Firebase para un usuario específico.
        /// </summary>
        /// <param name="idUsuario">ID del usuario.</param>
        /// <returns>Una tarea que representa la operación asincrónica.</returns>
        public async Task CargarFireAsync(int idUsuario)
        {
            VistaProductoFire vpFire = new VistaProductoFire();
            var productosDict = await vpFire.GetAsync("id", idUsuario);
            foreach (var productoDict in productosDict)
            {
                VistaProducto nuevoVP = new VistaProducto(productoDict);
                _vistaProductos.Add(nuevoVP);
            }
        }
    }
}
