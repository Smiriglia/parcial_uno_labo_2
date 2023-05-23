using parcialUno.essentials.abstractas;
using parcialUno.essentials.utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.models
{
    public class Producto : ITransformable
    {
        private int _id;
        private string _nombre;
        private string _descripcion;
        private float _precio;
        private List<string> _etiquetas;
        private string _imagePath;
        private string _estado;
        private float _relevanciaProducto = 0;
        private int _idVendedor;

        /// <summary>
        /// ID del producto.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Nombre del producto.
        /// </summary>
        public string Nombre { get { return _nombre; } }

        /// <summary>
        /// Descripción del producto.
        /// </summary>
        public string Descripcion { get { return _descripcion; } }

        /// <summary>
        /// Precio del producto.
        /// </summary>
        public float Precio { get { return _precio; } }

        /// <summary>
        /// Lista de etiquetas asociadas al producto.
        /// </summary>
        public List<string> Etiquetas { get { return _etiquetas; } }

        /// <summary>
        /// Ruta de la imagen del producto.
        /// </summary>
        public string ImagePath { get { return _imagePath; } }

        /// <summary>
        /// Relevancia del producto.
        /// </summary>
        public float RelevanciaProducto 
        {
            get { return _relevanciaProducto; } 
            set { _relevanciaProducto = value; } 
        }

        /// <summary>
        /// Estado del producto. (publicado/revision/rechazado/eliminado)
        /// </summary>
        public string Estado { get { return _estado; } }

        /// <summary>
        /// ID del vendedor asociado al producto.
        /// </summary>
        public int IdVendedor { get { return _idVendedor; } }

        /// <summary>
        /// Constructor de la clase Producto. Con todos los atributos tomados por parametro
        /// </summary>
        /// <param name="id">ID del producto.</param>
        /// <param name="nombre">Nombre del producto.</param>
        /// <param name="descripcion">Descripción del producto.</param>
        /// <param name="precio">Precio del producto.</param>
        /// <param name="etiquetas">Lista de etiquetas asociadas al producto.</param>
        /// <param name="imagePath">Ruta de la imagen del producto.</param>
        /// <param name="estado">Estado del producto.</param>
        /// <param name="idVendedor">ID del vendedor asociado al producto.</param>
        public Producto
            (
                int id,
                string nombre,
                string descripcion,
                float precio,
                List<string> etiquetas,
                string imagePath,
                string estado,
                int idVendedor
            )
        {
            _id = id;
            _nombre = nombre;
            _descripcion = descripcion;
            _precio = precio;
            _etiquetas = etiquetas;
            _imagePath = imagePath;
            _estado = estado;
            _idVendedor = idVendedor;
        }

        /// <summary>
        /// Constructor de la clase Producto que establece el estado como "revision".
        /// </summary>
        /// <param name="id">ID del producto.</param>
        /// <param name="nombre">Nombre del producto.</param>
        /// <param name="descripcion">Descripción del producto.</param>
        /// <param name="precio">Precio del producto.</param>
        /// <param name="etiquetas">Lista de etiquetas asociadas al producto.</param>
        /// <param name="imagePath">Ruta de la imagen del producto.</param>
        /// <param name="idVendedor">ID del vendedor asociado al producto.</param>
        public Producto
            (
                int id,
                string nombre,
                string descripcion,
                float precio,
                List<string> etiquetas,
                string imagePath,
                int idVendedor
            ) : 
            this
            (
                id,
                nombre,
                descripcion,
                precio, etiquetas,
                imagePath ,
                "revision",
                idVendedor
            )
        {}

        /// <summary>
        /// Constructor de la clase Producto a partir de un diccionario.
        /// </summary>
        /// <param name="pDict">Diccionario que contiene los datos del producto.</param>
        public Producto(Dictionary<string, object> pDict) :
            this(
                    (int)(long)pDict["id"],
                    (string)pDict["nombre"],
                    (string)pDict["descripcion"],
                    (float)(double)pDict["precio"],
                    Parser.ToStringList((List<object>)pDict["etiquetas"]),
                    (string)pDict["imagePath"],
                    (string)pDict["estado"],
                    (int)(long)pDict["idVendedor"]
                )
        {}

        /// <summary>
        /// Sobrecarga del operador de suma para sumar un monto de dinero y el precio de un producto.
        /// </summary>
        /// <param name="dinero">Monto de dinero.</param>
        /// <param name="producto">Producto.</param>
        /// <returns>El resultado de la suma.</returns>
        public static float operator +(float dinero, Producto producto)
        {
            return dinero + producto.Precio;
        }

        /// <summary>
        /// Sobrecarga del operador de suma para sumar el precio de un producto y un monto de dinero.
        /// </summary>
        /// <param name="producto">Producto.</param>
        /// <param name="dinero">Monto de dinero.</param>
        /// <returns>El resultado de la suma.</returns>
        public static float operator +(Producto producto, float dinero)
        {
            return dinero + producto;
        }


        /// <summary>
        /// Convierte el objeto Producto a un diccionario.
        /// </summary>
        /// <returns>Diccionario que representa el objeto Producto.</returns>
        public Dictionary<string, object> ToDict()
        {
            Dictionary<string, object> productoDict = new()
            {
                {"id", Id},
                {"nombre", Nombre },
                {"descripcion", Descripcion },
                {"precio", Precio },
                {"etiquetas", Etiquetas },
                {"imagePath",  ImagePath},
                {"estado", Estado },
                {"idVendedor", IdVendedor }
            };

            return productoDict;
        }
    }
}
