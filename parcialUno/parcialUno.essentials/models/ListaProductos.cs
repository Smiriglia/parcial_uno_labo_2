using Google.Type;
using parcialUno.essentials.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.models
{
    public class ListaProductos : IEnumerable
    {
        private List<Producto> _productos;

        public ListaProductos()
        {
            _productos = new List<Producto>();
        }

        public float CalcularPrecio()
        {
            float acumuladorPrecio = 0;
            foreach (Producto producto in this)
            {
                acumuladorPrecio += producto;
            }
            return acumuladorPrecio;
        }

        public void CalcularRelevancia(Dictionary<string, float> dictRelevancia)
        {
            foreach (Producto producto in this)
            {
                producto.RelevanciaProducto = 0;
                foreach (string etiqueta in producto.Etiquetas)
                {
                    if (dictRelevancia.ContainsKey(etiqueta))
                    {
                        producto.RelevanciaProducto += dictRelevancia[etiqueta];
                    }
                }
            }
        }
        public async Task CargarFireAsync()
        {
            ProductoFire productoFire = new ProductoFire();
            var productosDict = await productoFire.GetAsync("estado", "publicado");
            foreach (var productoDict in productosDict)
            {
                Producto nuevoProducto = new Producto(productoDict);
                AddProducto(nuevoProducto);
            }
        }

        public void OrdenarPorRelevancia()
        {
            _productos = _productos.OrderByDescending(p => p.RelevanciaProducto).ToList();
        }

        public Producto GetProducto(int indice)
        {
            return _productos[indice];
        }
        public void AddProducto(Producto producto)
        {
            _productos.Add(producto);
        }
        public void RemoveProducto(Producto producto)
        {
            _productos.Remove(producto);
        }
        public bool IsEmpty()
        {
            return _productos.Count == 0;
        }
        public IEnumerator GetEnumerator()
        {
            return new EnumeradorProducto(_productos);
        }
    }
    internal class EnumeradorProducto : IEnumerator
    {
        private List<Producto> data;
        private int currentIndex;

        public EnumeradorProducto(List<Producto> data)
        {
            this.data = data;
            currentIndex = -1;
        }

        public object Current => data[currentIndex];

        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < data.Count;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
