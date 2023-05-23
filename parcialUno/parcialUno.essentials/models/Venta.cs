using parcialUno.essentials.abstractas;
using parcialUno.essentials.Factory;
using parcialUno.essentials.utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.models
{
    /// <summary>
    /// Clase que representa una venta.
    /// </summary>
    public class Venta : ITransformable
    {
        private int _id;
        private int _idComprador;
        private int _idVendedor;
        private string _nombre;
        private float _precio;
        private float _ganancia;
        private DateTime _fecha;
        private string _estado;

        /// <summary>
        /// ID de la venta.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// ID del comprador.
        /// </summary>
        public int IdComprador { get { return _idComprador; } }

        /// <summary>
        /// ID del vendedor.
        /// </summary>
        public int IdVendedor { get { return _idVendedor; } }

        /// <summary>
        /// Nombre del producto vendido.
        /// </summary>
        public string Nombre { get { return _nombre; } }

        /// <summary>
        /// Precio de la venta.
        /// </summary>
        public float Precio { get { return _precio; } }

        /// <summary>
        /// Ganancia generada por la venta.
        /// </summary>
        public float Ganancia { get { return _ganancia; } }

        /// <summary>
        /// Fecha en la que se realizo la venta.
        /// </summary>
        public DateTime Fecha { get { return _fecha; } }

        /// <summary>
        /// Estado de la venta. (pendiente/entregado)
        /// </summary>
        public string Estado { get { return _estado; } set { _estado = value; } }

        /// <summary>
        /// Constructor de la clase Venta. Con la totalidad de atributos
        /// </summary>
        /// <param name="id">ID de la venta.</param>
        /// <param name="idComprador">ID del comprador.</param>
        /// <param name="idVendedor">ID del vendedor.</param>
        /// <param name="nombre">Nombre del producto vendido.</param>
        /// <param name="precio">Precio de la venta.</param>
        /// <param name="ganancia">Ganancia de la venta.</param>
        /// <param name="fecha">Fecha de la venta.</param>
        /// <param name="estado">Estado de la venta.</param>
        public Venta
        (
            int id,
            int idComprador,
            int idVendedor,
            string nombre,
            float precio,
            float ganancia,
            DateTime fecha,
            string estado
        )
        {
            _id = id;
            _idComprador = idComprador;
            _idVendedor = idVendedor;
            _nombre = nombre;
            _precio = precio;
            _ganancia = ganancia;
            _fecha = fecha;
            _estado = estado;
        }

        /// <summary>
        /// Constructor de la clase Venta. Calcula la ganancia,
        /// asigna la fecha actual y asigna el estado "pendiente"
        /// </summary>
        /// <param name="id">ID de la venta.</param>
        /// <param name="idComprador">ID del comprador.</param>
        /// <param name="idVendedor">ID del vendedor.</param>
        /// <param name="nombre">Nombre del producto vendido.</param>
        /// <param name="precio">Precio de la venta.</param>
        private Venta(int id, int idComprador, int idVendedor, string nombre, float precio) :
            this
            (
                id,
                idComprador,
                idVendedor,
                nombre,
                precio,
                precio * Constantes.comision,
                DateTime.Now,
                "pendiente" 
            )
        { }
        /// <summary>
        /// Constructor de la clase Venta. Utiliza los datos del producto vendido
        /// </summary>
        /// <param name="id">ID de la venta.</param>
        /// <param name="idComprador">ID del comprador.</param>
        /// <param name="producto">Producto Vendido</param>
        public Venta(int id, int idComprador, Producto producto) :
            this
            (
                id,
                idComprador,
                producto.IdVendedor,
                producto.Nombre,
                producto.Precio
            )
        {}

        /// <summary>
        /// Constructor de la clase Venta que recibe un diccionario de datos de venta.
        /// </summary>
        /// <param name="ventaDict">Diccionario que representa los datos de una venta</param>
        public Venta(Dictionary<string, object> ventaDict) :
            this
            (
                (int)(long)ventaDict["id"],
                (int)(long)ventaDict["idComprador"],
                (int)(long)ventaDict["idVendedor"],
                (string)ventaDict["nombre"],
                (float)(double)ventaDict["precio"],
                (float)(double)ventaDict["ganancia"],
                Parser.ToDateTime((string)ventaDict["fecha"]),
                (string) ventaDict["estado"]
            )
        { }

        /// <summary>
        /// Convierte la Venta en un diccionario.
        /// </summary>
        /// <returns>Diccionario con los datos de la Venta.</returns>
        public Dictionary<string, object> ToDict()
        {
            Dictionary<string, object> vistaProductoDict = new()
            {
                {"id", Id},
                {"idComprador", Id},
                {"idVendedor", _idComprador},
                {"nombre", _nombre },
                {"precio", Precio},
                {"ganancia", Ganancia},
                {"fecha", Fecha.ToString()},
                {"estado", Estado}

            };

            return vistaProductoDict;
        }

        /// <summary>
        /// Agrega la venta Asincronicamenta a la base de datos FireBase
        /// </summary>
        /// <returns>
        /// true: Si se añadio correctamente
        /// false: Si hubo un error al ser añadida
        /// </returns>
        public async Task<bool> AddFireAsync()
        {
            try
            {
                VentaFire ventaFire = new VentaFire();
                Usuario vendedor = await UsuarioFactory.getUsuarioAsync(IdVendedor);
                vendedor.AñadirDinero(Precio - Ganancia);
                await vendedor.UpdateAsync();

                return await ventaFire.AddAsync(this);
            }
            catch
            {
                return false;
            }
        }
    }
}
