using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.abstractas
{
    /// <summary>
    /// Interfaz que representa un objeto que puede ser transformado en un diccionario.
    /// </summary>
    public interface ITransformable
    {
        /// <summary>
        /// ID del objeto.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Convierte el objeto en un diccionario.
        /// </summary>
        /// <returns>Diccionario que representa el objeto.</returns>
        public Dictionary<string, object> ToDict();

    }
}
