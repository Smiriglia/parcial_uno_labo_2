using parcialUno.essentials.abstractas;
using parcialUno.essentials.Factory;
using parcialUno.essentials.utilidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.models
{
    /// <summary>
    /// Clase que representa una vista de producto.
    /// </summary>
    public class VistaProducto : ITransformable
    {
        private int _id;
        private int _idUsuario;
        private int _idProducto;
        private List<string> _etiquetas;
        private DateTime _fecha;

        /// <summary>
        /// ID de la vista al producto.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// ID del usuario que realizó la vista.
        /// </summary>
        public int IdUsuario { get { return _idUsuario; } }

        /// <summary>
        /// ID del producto que se visualizó.
        /// </summary>
        public int IdProducto { get { return _idProducto; } }

        /// <summary>
        /// Lista de etiquetas asociadas al producto visto.
        /// </summary>
        public List<string> Etiquetas { get { return _etiquetas; } }

        /// <summary>
        /// Fecha en que se realizó la vista del producto.
        /// </summary>
        public DateTime Fecha { get { return _fecha; } }

        /// <summary>
        /// Constructor de la clase VistaProducto. Con la totalidad de atributos
        /// </summary>
        /// <param name="id">ID de la vista de producto.</param>
        /// <param name="idUsuario">ID del usuario que realizó la vista.</param>
        /// <param name="idProducto">ID del producto visualizado.</param>
        /// <param name="etiquetas">Lista de etiquetas asociadas al producto visto.</param>
        /// <param name="fecha">Fecha en que se realizó la vista del producto.</param>
        public VistaProducto(int id, int idUsuario, int idProducto, List<string> etiquetas, DateTime fecha)
        {
            _id = id;
            _idUsuario = idUsuario;
            _idProducto = idProducto;
            _fecha = fecha;
            _etiquetas = etiquetas;
        }

        /// <summary>
        /// Constructor de la clase VistaProducto. Asignando la fecha actual
        /// </summary>
        /// <param name="id">ID de la vista de producto.</param>
        /// <param name="idUsuario">ID del usuario que realizó la vista.</param>
        /// <param name="idProducto">ID del producto visualizado.</param>
        /// <param name="etiquetas">Lista de etiquetas asociadas al producto visto.</param>
        private VistaProducto(int id, int idUsuario, int idProducto, List<string> etiquetas):
            this(id, idUsuario, idProducto, etiquetas, DateTime.Now) {}

        /// <summary>
        /// Constructor de la clase VistaProducto. Asignando los datos (IdProducto y Etiquetas)
        /// a partir de un producto dado
        /// </summary>
        /// <param name="id">ID de la vista de producto.</param>
        /// <param name="idUsuario">ID del usuario que realizó la vista.</param>
        /// <param name="producto">Producto visualizado.</param>
        public VistaProducto(int id, int idUsuario, Producto producto):
            this(id, idUsuario, producto.Id, producto.Etiquetas) { }

        /// <summary>
        /// Constructor de la clase Venta que recibe un diccionario de datos de VistaProducto.
        /// </summary>
        /// <param name="vpDict">Diccionario que representa los datos de una VistaProducto</param>
        public VistaProducto(Dictionary<string, object> vpDict) :
            this(
                (int)(long)vpDict["id"],
                (int)(long)vpDict["idUsuario"],
                (int)(long)vpDict["idProducto"],
                Parser.ToStringList((List<object>)vpDict["etiquetas"]),
                Parser.ToDateTime((string)vpDict["fecha"])
                ) {}

        /// <summary>
        /// Convierte la VistaProducto en un diccionario.
        /// </summary>
        /// <returns>Diccionario con los datos de la VistaProducto.</returns>
        public Dictionary<string, object> ToDict()
        {
            Dictionary<string, object> vistaProductoDict = new()
            {
                {"id", Id},
                {"idUsuario", IdUsuario},
                {"idProducto", IdProducto},
                {"etiquetas", Etiquetas },
                {"fecha", Fecha.ToString()}
            };

            return vistaProductoDict;
        }

        /// <summary>
        /// Agrega la VistaProducto Asincronicamenta a la base de datos FireBase
        /// </summary>
        /// <returns>
        /// true: Si se añadio correctamente |
        /// false: Si hubo un error al ser añadida
        /// </returns>
        public async Task<bool> AddFireAsync()
        {
            try
            {
                VistaProductoFire vistaProductoFire = new VistaProductoFire();
                return await vistaProductoFire.AddAsync(this);
            }
            catch
            {
                return false;
            }
        }
    }
}
