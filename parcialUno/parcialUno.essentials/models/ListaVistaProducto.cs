using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.models
{
    public class ListaVistaProducto
    {
        private List<VistaProducto> _vistaProductos;
        public ListaVistaProducto()
        {
            _vistaProductos = new List<VistaProducto>();
        }
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



        public async Task CargarFireAsync(int idUsuario)
        {
            VistaProductoFire vpFire = new VistaProductoFire();
            var productosDict = await vpFire.GetAsync("id", idUsuario);
            foreach (var productoDict in productosDict)
            {
                VistaProducto nuevoVP = new VistaProducto(productoDict);
                AddVistaProducto(nuevoVP);
            }
        }
        private void AddVistaProducto(VistaProducto vistaProducto)
        {
            _vistaProductos.Add(vistaProducto);
        }
    }
}
