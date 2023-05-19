using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.excepciones
{
    public class UsuarioInvalidoException : Exception
    {
        public UsuarioInvalidoException() : base() { }
        public UsuarioInvalidoException(string message) : base(message) { }
    }

    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException() : base() { }
        public SaldoInsuficienteException(string message) : base(message) { }
    }

    public class CarritoVacioException : Exception
    {
        public CarritoVacioException() : base() { }
        public CarritoVacioException(string message) : base(message) { }
    }

    public class ContraseñasNoCoincidenException : Exception
    {
        public ContraseñasNoCoincidenException() : base() { }
        public ContraseñasNoCoincidenException(string message) : base(message) { }
    }

    public class UsuarioTomadoException : Exception
    {
        public UsuarioTomadoException() : base() { }
        public UsuarioTomadoException(string message) : base(message) { }
    }
}
