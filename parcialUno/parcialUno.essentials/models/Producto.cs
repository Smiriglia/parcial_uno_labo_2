using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.models
{
    internal class Producto
    {
        private int _id;
        private string _nombre;
        private string _descripcion;
        private float _precio;
        private List<string> _etiquetas;
        private string _imagePath;

        public int Id { get { return _id; }}
        public string Nombre { get { return _nombre; }}
        public string Descripcion { get { return _descripcion; }}
        public float Precio { get { return _precio; }}
        public List<string> Etiquetas { get { return _etiquetas; }}
        public string ImagePath { get { return _imagePath; }}

        public static float CalcularPrecio(List<Producto> productos)
        {
            float acumuladorPrecio = 0;
            foreach (Producto producto in productos)
            {
                acumuladorPrecio += producto;
            }
            return acumuladorPrecio;
        }


        public Producto(int id, string nombre, string descripcion, float precio, List<string> etiquetas, string imagePath)
        {
            _id = id;
            _nombre = nombre;
            _descripcion = descripcion;
            _precio = precio;
            _etiquetas = etiquetas;
            _imagePath = imagePath;
        }

        public static float operator +(float dinero, Producto producto)
        {
            return dinero + producto.Precio;
        }

        public static float operator +(Producto producto, float dinero)
        {
            return dinero + producto;
        }


    }
}
