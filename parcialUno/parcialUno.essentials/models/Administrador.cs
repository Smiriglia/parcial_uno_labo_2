using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.models
{
    internal class Administrador : Usuario
    {
        public Administrador(int id, string nombre, string username, string password, string sector) : base(id, nombre, username, password, sector)
        {
        }
    }
}
