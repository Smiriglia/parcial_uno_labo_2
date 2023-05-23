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
    public class ListaVentas : IEnumerable
    {
        private BindingList<Venta> _ventas;

        public BindingList<Venta> Ventas { get { return new BindingList<Venta>(_ventas); } }
        //retorno una copia de la lista para que no la puedan modificar al ser pasada por referencia
        public ListaVentas()
        {
            _ventas = new BindingList<Venta>();
        }

        public async Task CargarFireAsync()
        {
            VentaFire ventaFire = new VentaFire();
            var ventasDict = await ventaFire.GetAsync();
            foreach (var ventaDict in ventasDict)
            {
                Venta nuevaVenta = new Venta(ventaDict);
                AddVenta(nuevaVenta);
            }
        }
        public float CalcularTotal()
        {
            float acumuladorPrecio = 0;
            foreach (Venta venta in _ventas)
            {
                acumuladorPrecio += venta.Precio;
            }
            return acumuladorPrecio;
        }

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
        public int Count()
        {
            return _ventas.Count;
        }
        public void Clear()
        {
            _ventas.Clear();
        }

        private void AddVenta(Venta venta)
        {
            _ventas.Add(venta);
        }

        public IEnumerator GetEnumerator()
        {
            return new EnumeradorVenta(_ventas);
        }

    }

    internal class EnumeradorVenta : IEnumerator
    {
        private BindingList<Venta> data;
        private int currentIndex;

        public EnumeradorVenta(BindingList<Venta> data)
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
