using parcialUno.essentials.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcialUno
{
    public partial class FormPrincipal : Form
    {
        private Usuario _usuario;
        public FormPrincipal(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            if (usuario.Sector != "comprador")
            {
                //TODO ADMIN MENU
            }
        }

    }
}
