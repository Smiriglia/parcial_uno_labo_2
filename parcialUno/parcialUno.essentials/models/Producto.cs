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

        public int Id { get { return _id; } }
        public string Nombre { get { return _nombre; } }
        public string Descripcion { get { return _descripcion; } }
        public float Precio { get { return _precio; } }
        public List<string> Etiquetas { get { return _etiquetas; } }
        public string ImagePath { get { return _imagePath; } }
        public float RelevanciaProducto { get { return _relevanciaProducto; } set { _relevanciaProducto = value; } }
        public string Estado { get { return _estado; }}

        public int IdVendedor { get { return _idVendedor; } }

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

        public static float operator +(float dinero, Producto producto)
        {
            return dinero + producto.Precio;
        }

        public static float operator +(Producto producto, float dinero)
        {
            return dinero + producto;
        }



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
