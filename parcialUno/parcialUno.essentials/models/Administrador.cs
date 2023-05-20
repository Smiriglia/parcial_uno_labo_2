using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.models
{
    public class Administrador : Usuario
    {
        public Administrador(int id, string nombre, string username, string password, string sector) : 
            base(id, nombre, username, password, sector)
        {
            if (sector == "comprador")
                throw new Exception();
        }

        public Administrador(Dictionary<string, object> adminDict) : base(adminDict) { }
    }
}
