using parcialUno.essentials.Factory;
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
    /// Clase que representa una lista de Ventas pero facilitando 
    /// metodos propios y abstractos y encapsulando logica a la que no se quiere
    /// que el usuario acceda
    /// </summary>
    public class ListaVentas : IEnumerable
    {
        private BindingList<Venta> _ventas;

        /// <summary>
        /// Obtiene una copia de la lista de ventas.
        /// </summary>
        public BindingList<Venta> Ventas { get { return new BindingList<Venta>(_ventas); } }
        //retorno una copia de la lista para que no la puedan modificar al ser pasada por referencia

        /// <summary>
        /// Constructor de la clase ListaVentas. Crea la lista de ventas
        /// </summary>
        public ListaVentas()
        {
            _ventas = new BindingList<Venta>();
        }

        /// <summary>
        /// Convierte una lista de diccionarios que representan ventas en objetos
        /// de tipo Venta y los añade a la lista
        /// </summary>
        /// <param name="ventasDict">Lista de diccionarios que representan Ventas a convertir</param>
        private void CargarDictsVentas(List<Dictionary<string, object>> ventasDict)
        {
            foreach (var ventaDict in ventasDict)
            {
                Venta nuevaVenta = new Venta(ventaDict);
                AddVenta(nuevaVenta);
            }
        }

        /// <summary>
        /// Carga los datos de las ventas desde Firebase.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica.</returns>
        public async Task CargarFireAsync()
        {
            VentaFire ventaFire = new VentaFire();
            var ventasDict = await ventaFire.GetAsync();
            CargarDictsVentas(ventasDict);
        }

        /// <summary>
        /// Carga los datos de las ventas pendientes desde Firebase.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica.</returns>
        public async Task CargarPendientesFireAsync()
        {
            VentaFire ventaFire = new VentaFire();
            var ventasDict = await ventaFire.GetAsync("estado", "pendiente");
            CargarDictsVentas(ventasDict);
        }

        /// <summary>
        /// Calcula el total de precios de las ventas en la lista.
        /// </summary>
        /// <returns>El total de precios.</returns>
        public float CalcularTotal()
        {
            float acumuladorPrecio = 0;
            foreach (Venta venta in _ventas)
            {
                acumuladorPrecio += venta.Precio;
            }
            return acumuladorPrecio;
        }

        /// <summary>
        /// Calcula la cantidad de ventas por nombre de producto.
        /// </summary>
        /// <returns>Un diccionario que contiene los nombres de producto y su cantidad de ventas.</returns>
        public Dictionary<string, int> CalcularCantidad()
        {
            Dictionary<string, int> cantidadVentas = new Dictionary<string, int>();
            foreach (Venta venta in _ventas)
            {
                if (cantidadVentas.ContainsKey(venta.Nombre))
                    cantidadVentas[venta.Nombre] += 1;
                else
                    cantidadVentas[venta.Nombre] = 1;
            }
            return cantidadVentas;
        }

        /// <summary>
        /// Registra las ventas en la lista y en Firebase.
        /// </summary>
        /// <param name="idComprador">ID del comprador.</param>
        /// <param name="carrito">Lista de productos del carrito de compra.</param>
        /// <returns>Un valor booleano que indica si se registraron las ventas correctamente.</returns>
        public async Task<bool> RegistarVentasAsync(int idComprador, ListaProductos carrito)
        {
            foreach (Producto producto in carrito)
            {
                Venta nuevaVenta = await VentaFactory.CrearVenta(idComprador, producto);
                AddVenta(nuevaVenta);
                if (await nuevaVenta.AddFireAsync())
                    continue;
                return false;
            }
            return true;
        }

        /// <summary>
        /// Obtiene el número de ventas en la lista.
        /// </summary>
        public int Count()
        {
            return _ventas.Count;
        }

        /// <summary>
        /// Vacia la lista de ventas
        /// </summary>
        public void Clear()
        {
            _ventas.Clear();
        }

        /// <summary>
        /// Añade la venta dada a la lista
        /// </summary>
        /// <param name="venta">Venta a agregar</param>
        private void AddVenta(Venta venta)
        {
            _ventas.Add(venta);
        }

        /// <summary>
        /// Devuelve un enumerador que recorre la lista de ventas.
        /// </summary>
        /// <returns>Enumerador para la lista de ventas.</returns>
        public IEnumerator GetEnumerator()
        {
            return new EnumeradorVenta(_ventas);
        }

    }

    /// <summary>
    /// Enumerador interno para recorrer la lista de ventas.
    /// </summary>
    internal class EnumeradorVenta : IEnumerator
    {
        private BindingList<Venta> data;
        private int currentIndex;

        /// <summary>
        /// Constructor del enumerador.
        /// </summary>
        public EnumeradorVenta(BindingList<Venta> data)
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
