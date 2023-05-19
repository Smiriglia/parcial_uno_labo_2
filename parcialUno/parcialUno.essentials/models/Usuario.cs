using parcialUno.essentials.abstractas;
using parcialUno.essentials.excepciones;
using parcialUno.essentials.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.models
{
    public class Usuario : ITransformable
    {
        private int _id;
        private string _nombre;
        private string _username;
        private string _password;
        private float _dinero;
        private string _sector;


        public int Id { get { return _id; } }
        public string Username { get { return _username; } }
        public string Password { get { return _password; } }
        public float Dinero { get { return _dinero; } }
        public string Nombre { get { return _nombre; } }

        public string Sector { get { return _sector; } set { _sector = value; } }

        public Usuario(Dictionary<string, object> usuarioDict) :
            this((int)(long)usuarioDict["id"],
                (string) usuarioDict["nombre"],
                (string)usuarioDict["username"],
                (string) usuarioDict["password"],
                (string) usuarioDict["sector"],
                (float)(double) usuarioDict["dinero"])
        {}

        public Usuario(int id, string nombre, string username, string password, string sector, float dinero)
        {
            _id = id;
            _nombre = nombre;
            _username = username;
            _password = password;
            _sector = sector;
            _dinero = dinero;
        }

        public Usuario(int id, string nombre, string username, string password, string sector) : 
            this(id, nombre, username, password, sector, 0.0f)
        {}

        public Usuario(int id, string nombre, string username, string password) :
            this(id, nombre, username, password, "comprador")
        {}

        public async Task ComprarAsync(ListaProductos carrito)
        {
            float total = carrito.CalcularPrecio();
            if (_dinero < total)
                throw new SaldoInsuficienteException("Error, No posee saldo suficiente para realizar esta compra");
            else if (carrito.IsEmpty())
                throw new CarritoVacioException("Error, No tienes productos para comprar");
            UsuarioFire usuarioFire = new UsuarioFire();
            _dinero -= total;

            await usuarioFire.Update(this);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Username: {Username}");
            sb.AppendLine($"Contraseña: {Password}");
            sb.AppendLine($"Dinero: {Dinero}");
            return sb.ToString();
        }

        public Dictionary<string, object> ToDict()
        {
            Dictionary<string, object> usuarioDict = new()
            {
                {"id", Id},
                {"username", Username},
                {"password", Password},
                {"dinero", Dinero },
                {"nombre", Nombre },
                {"sector", Sector }
            };

            return usuarioDict;
        }
    }
}
