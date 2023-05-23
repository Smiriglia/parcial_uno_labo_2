using Google.Type;
using parcialUno.essentials.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.models
{
    /// <summary>
    /// Clase que representa una lista de Productos pero facilitando 
    /// metodos propios y abstractos y encapsulando logica a la que no se quiere
    /// que el usuario acceda
    /// </summary>
    public class ListaProductos : IEnumerable
    {
        private List<Producto> _productos;

        /// <summary>
        /// Constructor de la clase ListaProductos. Crea la lista
        /// </summary>
        public ListaProductos()
        {
            _productos = new List<Producto>();
        }

        /// <summary>
        /// Obtiene una copia de la lista de productos como una BindingList.
        /// </summary>
        public BindingList<Producto> Productos { get { return new BindingList<Producto>(_productos); } }


        /// <summary>
        /// Calcula el precio total de todos los productos en la lista.
        /// </summary>
        /// <returns>Precio total de los productos.</returns>
        public float CalcularPrecio()
        {
            float acumuladorPrecio = 0;
            foreach (Producto producto in this)
            {
                acumuladorPrecio += producto;
            }
            return acumuladorPrecio;
        }

        /// <summary>
        /// Calcula y asigna la relevancia de cada producto en función
        /// de un diccionario de relevancia por etiqueta.
        /// </summary>
        /// <param name="dictRelevancia">Diccionario de relevancia por etiqueta.</param>
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

        /// <summary>
        /// Convierte una lista de diccionarios que representan Productos en objetos
        /// de tipo Producto y los añade a la lista
        /// </summary>
        /// <param name="productosDict">Lista de diccionarios que representan Productos a convertir</param>
        private void CargarProductosDict(List<Dictionary<string, object>> productosDict)
        {
            foreach (var productoDict in productosDict)
            {
                Producto nuevoProducto = new Producto(productoDict);
                AddProducto(nuevoProducto);
            }
        }

        /// <summary>
        /// Carga los productos publicados desde Firebase.
        /// </summary>
        public async Task CargarPublicadosFireAsync()
        {
            ProductoFire productoFire = new ProductoFire();
            var productosDict = await productoFire.GetAsync("estado", "publicado");
            CargarProductosDict(productosDict);
        }

        /// <summary>
        /// Carga todos los productos desde Firebase.
        /// </summary>
        public async Task CargarFireAsync()
        {
            ProductoFire productoFire = new ProductoFire();
            var productosDict = await productoFire.GetAsync();
            CargarProductosDict(productosDict);
        }

        /// <summary>
        /// Ordena los productos por relevancia en orden descendente.
        /// </summary>
        public void OrdenarPorRelevancia()
        {
            _productos = _productos.OrderByDescending(p => p.RelevanciaProducto).ToList();
        }

        /// <summary>
        /// Obtiene un producto de la lista por su índice.
        /// </summary>
        /// <param name="indice">Índice del producto.</param>
        /// <returns>Producto en el índice especificado.</returns>
        public Producto GetProducto(int indice)
        {
            return _productos[indice];
        }

        /// <summary>
        /// Agrega un producto a la lista.
        /// </summary>
        /// <param name="producto">Producto a agregar.</param>

        public void AddProducto(Producto producto)
        {
            _productos.Add(producto);
        }

        /// <summary>
        /// Elimina un producto de la lista.
        /// </summary>
        /// <param name="producto">Producto a eliminar.</param>
        public void RemoveProducto(Producto producto)
        {
            _productos.Remove(producto);
        }

        /// <summary>
        /// Verifica si la lista de productos está vacía.
        /// </summary>
        /// <returns>
        /// true: Si esta vacia
        /// false: si no esta vacia
        /// </returns>
        public bool IsEmpty()
        {
            return _productos.Count == 0;
        }

        /// <summary>
        /// Vacia la lista de productos
        /// </summary>
        public void Clear()
        {
            _productos.Clear();
        }

        /// <summary>
        /// Devuelve un enumerador que recorre la lista de Productos.
        /// </summary>
        /// <returns>Enumerador para la lista de Productos.</returns>
        public IEnumerator GetEnumerator()
        {
            return new EnumeradorProducto(_productos);
        }
    }

    /// <summary>
    /// Enumerador interno para recorrer la lista de Productos.
    /// </summary>
    internal class EnumeradorProducto : IEnumerator
    {
        private List<Producto> data;
        private int currentIndex;

        /// <summary>
        /// Constructor del enumerador.
        /// </summary>
        public EnumeradorProducto(List<Producto> data)
        {
            this.data = data;
            currentIndex = -1;
        }

        /// <summary>
        /// Obtiene el elemento actual del enumerador.
        /// </summary>
        public object Current => data[currentIndex];

        /// <summary>
        /// Avanza al siguiente elemento del enumerador.
        /// </summary>
        /// <returns>true si se avanzó correctamente; false si se alcanzó el final de la lista.</returns>
        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < data.Count;
        }

        /// <summary>
        /// Reinicia el enumerador a su posición inicial.
        /// </summary>
        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
