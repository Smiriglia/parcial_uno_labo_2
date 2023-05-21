using parcialUno.essentials.abstractas;
using parcialUno.essentials.excepciones;
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
                throw new UsuarioInvalidoException();
        }

        public Administrador(Dictionary<string, object> adminDict) : base(adminDict) { }

        public async Task ModificarElementoAsync
            (
            ITransformable? elemento,
            string username,
            string password,
            string txtDinero,
            string nombre,
            string sector
            )
        {
            float dinero;
            if (!(elemento is null) && float.TryParse(txtDinero, out dinero))
            {
                Dictionary<string, object> modificaciones = new()
                {
                    { "username", username},
                    { "password", password },
                    { "dinero", dinero },
                    { "nombre", nombre },
                    { "sector", sector }
                };
                UsuarioFire usuarioFire = new UsuarioFire();


                await usuarioFire.ModAsync(elemento, modificaciones);
            }
            else
                throw new UsuarioInvalidoException("Error con alguno de los campos modificados");
        }
        public async Task ModificarElementoAsync(ITransformable? elemento, Dictionary<string, object> modificaciones)
        {
            UsuarioFire usuarioFire = new UsuarioFire();
            if (!(elemento is null))
                await usuarioFire.ModAsync(elemento, modificaciones);
            else
                throw new UsuarioInvalidoException("Error, Elemento Inexistente");
        }
    }
}
