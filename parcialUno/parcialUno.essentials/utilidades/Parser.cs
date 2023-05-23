using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.utilidades
{
    /// <summary>
    /// Clase estática que proporciona métodos para convertir valores a diferentes tipos de datos.
    /// </summary>
    public static class Parser
    {
        /// <summary>
        /// Convierte una lista de objetos en una lista de cadenas de texto.
        /// </summary>
        /// <param name="lista">Lista de objetos a convertir.</param>
        /// <returns>Una lista de cadenas de texto.</returns>
        public static List<string> ToStringList(List<object> lista)
        {
            List<string> listaModificada = new List<string>();
            foreach (string objeto in lista)
            {
                listaModificada.Add(objeto.ToString());
            }
            return listaModificada;
        }

        /// <summary>
        /// Convierte una cadena de texto en una fecha y hora en formato DateTime.
        /// </summary>
        /// <param name="fechaString">Cadena de texto que representa la fecha y hora.</param>
        /// <returns>Un objeto DateTime que representa la fecha y hora convertida.</returns>
        public static DateTime ToDateTime(string fechaString)
        {
            DateTime dateTime = DateTime.ParseExact(fechaString, "d/M/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            return dateTime;
        }
    }
}
