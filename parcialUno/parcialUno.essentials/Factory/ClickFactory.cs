using parcialUno.essentials.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.Factory
{
    public class ClickFactory
    {
        public static async Task<Click?> CrearAsync(int idUsuario, string nombreControl)
        {
            try
            {

                ClickFire clickFire = new ClickFire();
                int idClick = await clickFire.GetUltimoIdAsync() + 1;
                Click nuevoClick = new Click(idClick, idUsuario, nombreControl);
                return nuevoClick;
            }
            catch
            {
                return null;
            }
        }
    }
}
