using parcialUno.essentials.abstractas;
using parcialUno.essentials.utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.models
{
    public class Click : ITransformable
    {
        private int _id;
        private int _idUsuario;
        private string _nombreControl;
        private DateTime _fecha;

        public int Id { get { return _id; } }
        public int IdUsuario { get { return _idUsuario; } }

        public string NombreControl { get { return _nombreControl; } }
        public DateTime Fecha { get { return _fecha; } }

        private Click(int id, int idUsuario, string nombreControl, DateTime fecha)
        {
            _id = id;
            _idUsuario = idUsuario;
            _nombreControl = nombreControl;
            _fecha = fecha;
        }

        public Click(int id, int idUsuario, string nombreControl) : 
            this(id, idUsuario, nombreControl, DateTime.Now)
        { }

        public Click(Dictionary<string, object> usuarioDict) :
            this((int)(long)usuarioDict["id"],
                (int)usuarioDict["idUsuario"],
                (string)usuarioDict["nombreControl"],
                Parser.ToDateTime((string)usuarioDict["fecha"]))
        { }

        public async Task<bool> AddFireAsync()
        {
            try
            {
                ClickFire vistaProductoFire = new ClickFire();
                return await vistaProductoFire.AddAsync(this);
            }
            catch
            {
                return false;
            }
        }

        public Dictionary<string, object> ToDict()
        {
            Dictionary<string, object> usuarioDict = new()
            {
                {"id", Id},
                {"idUsuario", IdUsuario},
                {"nombreControl", NombreControl},
                {"fecha", Fecha.ToString() }
            };

            return usuarioDict;
        }

    }
}
