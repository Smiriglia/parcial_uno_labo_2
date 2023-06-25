using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialUno.essentials.models
{
    public class ListaClicks
    {

        private List<Click> _clicks;
        public BindingList<Click> Clicks { get { return new BindingList<Click>(_clicks); } }

        /// <summary>
        /// Constructor de la clase ListaVistaProducto. Crea la lista
        /// </summary>
        public ListaClicks()
        {
            _clicks = new List<Click>();
        }

        public void Clear()
        {
            _clicks.Clear();
        }

        public async Task CargarFireAsync()
        {
            ClickFire clickFire = new ClickFire();
            var clicksDict = await clickFire.GetAsync();
            foreach (var clickDict in clicksDict)
            {
                Click nuevoClick = new Click(clickDict);
                _clicks.Add(nuevoClick);
            }
        }
    }
}
