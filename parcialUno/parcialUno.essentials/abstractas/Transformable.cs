using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.abstractas
{
    public abstract class Transformable
    {
        public abstract int Id { get; }
        public abstract Dictionary<string, object> ToDict();

    }
}
