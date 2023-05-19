using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.abstractas
{
    public interface ITransformable
    {
        public int Id { get; }
        public Dictionary<string, object> ToDict();

    }
}
