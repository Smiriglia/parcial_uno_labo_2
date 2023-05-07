using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.utilidades
{
    public static class Parser
    {
        public static List<string> ToStringList(List<object> lista)
        {
            List<string> listaModificada = new List<string>();
            foreach (var objeto in lista)
            {
                listaModificada.Add(objeto.ToString());
            }
            return listaModificada;
        }

        public static DateTime ToDateTime(string fechaString)
        {
            DateTime dateTime = DateTime.ParseExact(fechaString, "d/M/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            return dateTime;
        }
    }
}
