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

        public int Id { get { return _id; } }
        public int IdComprador { get { return _idComprador; } }
        public int IdVendedor { get { return _idVendedor; } }
        public string Nombre { get { return _nombre; } }
        public float Precio { get { return _precio; } }
        public float Ganancia { get { return _ganancia; } }
        public DateTime Fecha { get { return _fecha; } }
        public string Estado { get { return _estado; } set { _estado = value; } }

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

        public async Task<bool> AddFireAsync()
        {
            VentaFire ventaFire = new VentaFire();
            try
            {
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
