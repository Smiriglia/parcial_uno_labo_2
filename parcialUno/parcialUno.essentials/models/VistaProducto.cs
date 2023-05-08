using parcialUno.essentials.abstractas;
using parcialUno.essentials.utilidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.models
{
    public class VistaProducto : Transformable
    {
        private int _id;
        private int _idUsuario;
        private int _idProducto;
        private List<string> _etiquetas;
        private DateTime _fecha;

        public override int Id { get { return _id; } }
        public int IdUsuario { get { return _idUsuario; } }
        public int IdProducto { get { return _idProducto; } }
        public List<string> Etiquetas { get { return _etiquetas; } }
        public DateTime Fecha { get { return _fecha; } }

        
        public static Dictionary<string, float> CalcularRelevancia(List<VistaProducto> vpList)
        {
            Dictionary<string, float> valorPorEtiqueta = new Dictionary<string, float>();
            float relevanciaPorFecha;
            TimeSpan tiempoTranscurrido;
            int mesesTranscurridos;
            foreach (var vp in vpList)
            {
                tiempoTranscurrido = DateTime.Now - vp.Fecha;
                //Cada 30 dias la relevancia de un producto visto se reduce
                mesesTranscurridos = tiempoTranscurrido.Days / 30;
                relevanciaPorFecha = 1 / mesesTranscurridos + 1;
                foreach(string etiqueta in vp.Etiquetas)
                {

                    if (valorPorEtiqueta.ContainsKey(etiqueta))
                    {
                        valorPorEtiqueta[etiqueta] += relevanciaPorFecha;
                    }
                    else
                    {
                        valorPorEtiqueta.Add(etiqueta, relevanciaPorFecha);
                    }
                }
            }
            return valorPorEtiqueta;
        }

        public VistaProducto(int id, int idUsuario, int idProducto, List<string> etiquetas, DateTime fecha)
        {
            _id = id;
            _idUsuario = idUsuario;
            _idProducto = idProducto;
            _fecha = fecha;
            _etiquetas = etiquetas;
        }

        public VistaProducto(int id, int idUsuario, int idProducto, List<string> etiquetas) : this(id, idUsuario, idProducto, etiquetas, DateTime.Now) {}

        public VistaProducto(Dictionary<string, object> vpDict) :
            this(
                (int)(long)vpDict["id"],
                (int)(long)vpDict["idUsuario"],
                (int)(long)vpDict["idProducto"],
                Parser.ToStringList((List<object>)vpDict["etiquetas"]),
                Parser.ToDateTime((string)vpDict["fecha"])
                ) {}

        public override Dictionary<string, object> ToDict()
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
    }
}
