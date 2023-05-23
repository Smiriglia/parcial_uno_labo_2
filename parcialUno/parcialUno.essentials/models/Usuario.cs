using parcialUno.essentials.abstractas;
using parcialUno.essentials.excepciones;
using parcialUno.essentials.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.models
{
    /// <summary>
    /// Clase que representa un usuario.
    /// </summary>
    public class Usuario : ITransformable
    {
        private int _id;
        private string _nombre;
        private string _username;
        private string _password;
        private float _dinero;
        private string _sector;

        /// <summary>
        /// ID del usuario.
        /// </summary>
        public int Id { get { return _id; } }
        /// <summary>
        /// Alias del usuario.
        /// </summary>
        public string Username { get { return _username; } }

        /// <summary>
        /// Contraseña del usuario.
        /// </summary>
        public string Password { get { return _password; } }

        /// <summary>
        /// Dinero del usuario.
        /// </summary>
        public float Dinero { get { return _dinero; } }

        /// <summary>
        /// Nombre del usuario.
        /// </summary>
        public string Nombre { get { return _nombre; } }

        /// <summary>
        /// Sector del usuario. (comprador/administrador/eliminado)
        /// </summary>
        public string Sector { get { return _sector; }}

        /// <summary>
        /// Constructor de la clase Usuario que recibe un diccionario de datos de usuario.
        /// </summary>
        public Usuario(Dictionary<string, object> usuarioDict) :
            this((int)(long)usuarioDict["id"],
                (string) usuarioDict["nombre"],
                (string)usuarioDict["username"],
                (string) usuarioDict["password"],
                (string) usuarioDict["sector"],
                (float)(double) usuarioDict["dinero"])
        {}

        /// <summary>
        /// Constructor de Usuario con la totalidad de los atributos para cargar un usuario existente
        /// </summary>
        /// <param name="id">Id del usuari</param>
        /// <param name="nombre">Nombre del usuario</param>
        /// <param name="username">Alias del usuario</param>
        /// <param name="password">Contraseña del usuario</param>
        /// <param name="sector">Sector del usuario</param>
        /// <param name="dinero">Cantidad de dinero que posee el Usuario</param>
        public Usuario(int id, string nombre, string username, string password, string sector, float dinero)
        {
            _id = id;
            _nombre = nombre;
            _username = username;
            _password = password;
            _sector = sector;
            _dinero = dinero;
        }

        /// <summary>
        /// Constructor de la clase Usuario. Que inicializa en 0 el dinero
        /// </summary>
        /// <param name="id">ID del usuario.</param>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <param name="username">Nombre de usuario.</param>
        /// <param name="password">Contraseña del usuario.</param>
        /// <param name="sector">Sector del usuario.</param>
        public Usuario(int id, string nombre, string username, string password, string sector) : 
            this(id, nombre, username, password, sector, 0.0f)
        {}


        /// <summary>
        /// Constructor de la clase Usuario. Que inicializa en 0 el dinero y le asigna el sector "comprador"
        /// </summary>
        /// <param name="id">ID del usuario.</param>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <param name="username">Nombre de usuario.</param>
        /// <param name="password">Contraseña del usuario.</param>
        /// <param name="sector">Sector del usuario.</param>
        /// <param name="dinero">Dinero del usuario.</param>
        public Usuario(int id, string nombre, string username, string password) :
            this(id, nombre, username, password, "comprador")
        {}

        /// <summary>
        /// Realiza una compra asincrónica. Restando el dinero
        /// </summary>
        /// <param name="carrito">Lista de productos a comprar.</param>
        /// <returns>
        /// 0: Si fue Exitoso
        /// 1: Si se pudieron comprar solo algunos elementos
        /// 2: si no se pudo comprar nada
        /// </returns>
        public async Task<int> ComprarAsync(ListaProductos carrito)
        {
            float total = carrito.CalcularPrecio();
            int codigoSalida;
            if (_dinero < total)
                throw new SaldoInsuficienteException("Error, No posee saldo suficiente para realizar esta compra");
            else if (carrito.IsEmpty())
                throw new CarritoVacioException("Error, No tienes productos para comprar");
            UsuarioFire usuarioFire = new UsuarioFire();
            ListaVentas listaVentas = new ListaVentas();
            
            if (await listaVentas.RegistarVentasAsync(Id, carrito))
            {
                _dinero -= total;
                codigoSalida = 0;

            }
            else if (listaVentas.Count() > 0)
            {
                _dinero -= listaVentas.CalcularTotal();
                codigoSalida = 1;
            }
            else
            {
                codigoSalida = 2;
            }
            //TODO Arreglar falla en la seguridad
            await usuarioFire.Update(this);
            return codigoSalida;
        }

        /// <summary>
        /// Añade una cantidad de dinero al usuario.
        /// </summary>
        /// <param name="cantidad">Cantidad de dinero a añadir.</param>
        public void AñadirDinero(float cantidad)
        {
            _dinero += cantidad;
        }

        /// <summary>
        /// Actualiza el usuario de forma asincrónica en la base de datos FireBase.
        /// </summary>
        public async Task UpdateAsync()
        {
            UsuarioFire usuarioFire = new UsuarioFire();
            await usuarioFire.Update(this);
        }

        /// <summary>
        /// Sobrescribe el método ToString para obtener una representación en cadena del objeto Usuario.
        /// </summary>
        /// <returns>Cadena con los datos del usuario.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Username: {Username}");
            sb.AppendLine($"Contraseña: {Password}");
            sb.AppendLine($"Dinero: {Dinero}");
            return sb.ToString();
        }

        /// <summary>
        /// Convierte el Usuario en un diccionario con los datos correspondientes.
        /// Es el formato utilizado para subir a la base de datos FireBase
        /// </summary>
        /// <returns>Diccionario con los datos del usuario.</returns>
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
