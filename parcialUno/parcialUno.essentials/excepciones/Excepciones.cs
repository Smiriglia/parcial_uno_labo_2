using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.excepciones
{
    // <summary>
    /// Excepción lanzada cuando se valida un usuario inválido.
    /// </summary>
    public class UsuarioInvalidoException : Exception
    {
        /// <summary>
        /// Crea una nueva instancia de la clase UsuarioInvalidoException.
        /// </summary>
        public UsuarioInvalidoException() : base() { }

        /// <summary>
        /// Crea una nueva instancia de la clase UsuarioInvalidoException con un mensaje de error especificado.
        /// </summary>
        /// <param name="message">Mensaje de error que describe la excepción.</param>
        public UsuarioInvalidoException(string message) : base(message) { }
    }

    /// <summary>
    /// Excepción lanzada cuando se valida un producto inválido.
    /// </summary>
    public class ProductoInvalidoException : Exception
    {
        /// <summary>
        /// Crea una nueva instancia de la clase ProductoInvalidoException.
        /// </summary>
        public ProductoInvalidoException() : base() { }

        /// <summary>
        /// Crea una nueva instancia de la clase ProductoInvalidoException con un mensaje de error especificado.
        /// </summary>
        /// <param name="message">Mensaje de error que describe la excepción.</param>
        public ProductoInvalidoException(string message) : base(message) { }
    }

    /// <summary>
    /// Excepción lanzada cuando se produce un intento de realizar una operación con saldo insuficiente.
    /// </summary>
    public class SaldoInsuficienteException : Exception
    {
        /// <summary>
        /// Crea una nueva instancia de la clase SaldoInsuficienteException.
        /// </summary>
        public SaldoInsuficienteException() : base() { }

        /// <summary>
        /// Crea una nueva instancia de la clase SaldoInsuficienteException con un mensaje de error especificado.
        /// </summary>
        /// <param name="message">Mensaje de error que describe la excepción.</param>
        public SaldoInsuficienteException(string message) : base(message) { }
    }

    /// <summary>
    /// Excepción lanzada cuando se realiza una compra en un carrito de compras vacío.
    /// </summary>
    public class CarritoVacioException : Exception
    {
        /// <summary>
        /// Crea una nueva instancia de la clase CarritoVacioException.
        /// </summary>
        public CarritoVacioException() : base() { }

        /// <summary>
        /// Crea una nueva instancia de la clase CarritoVacioException con un mensaje de error especificado.
        /// </summary>
        /// <param name="message">Mensaje de error que describe la excepción.</param>
        public CarritoVacioException(string message) : base(message) { }
    }

    /// <summary>
    /// Excepción lanzada cuando las contraseñas no coinciden en una operación de validación.
    /// </summary>
    public class ContraseñasNoCoincidenException : Exception
    {
        /// <summary>
        /// Crea una nueva instancia de la clase ContraseñasNoCoincidenException.
        /// </summary>
        public ContraseñasNoCoincidenException() : base() { }

        /// <summary>
        /// Crea una nueva instancia de la clase ContraseñasNoCoincidenException con un mensaje de error especificado.
        /// </summary>
        /// <param name="message">Mensaje de error que describe la excepción.</param>
        public ContraseñasNoCoincidenException(string message) : base(message) { }
    }

    /// <summary>
    /// Excepción lanzada cuando se intenta utilizar un nombre de usuario que ya ha sido tomado.
    /// </summary>
    public class UsuarioTomadoException : Exception
    {
        /// <summary>
        /// Crea una nueva instancia de la clase UsuarioTomadoException.
        /// </summary>
        public UsuarioTomadoException() : base() { }

        /// <summary>
        /// Crea una nueva instancia de la clase UsuarioTomadoException con un mensaje de error especificado.
        /// </summary>
        /// <param name="message">Mensaje de error que describe la excepción.</param>
        public UsuarioTomadoException(string message) : base(message) { }
    }


    /// <summary>
    /// Excepción lanzada cuando no se encuentra un elemento en una operación de búsqueda.
    /// </summary>
    public class ElementoNoEncontradoExeption : Exception
    {
        /// <summary>
        /// Crea una nueva instancia de la clase ElementoNoEncontradoExeption.
        /// </summary>
        public ElementoNoEncontradoExeption() : base() { }

        /// <summary>
        /// Crea una nueva instancia de la clase ElementoNoEncontradoExeption con un mensaje de error especificado.
        /// </summary>
        /// <param name="message">Mensaje de error que describe la excepción.</param>
        public ElementoNoEncontradoExeption(string message) : base(message) { }
    }
}
