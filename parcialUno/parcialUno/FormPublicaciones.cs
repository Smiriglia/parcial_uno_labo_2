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
    public partial class FormPublicaciones : Form
    {
        private Administrador _administrador;
        public FormPublicaciones(Administrador administrador)
        {
            InitializeComponent();
            _administrador = administrador;
        }

        private void cargarFormulario(Form form)
        {
            if (contenedorPrincipal.Controls.Count > 0)
                contenedorPrincipal.Controls.RemoveAt(0);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            contenedorPrincipal.Controls.Add(form);
            form.Show();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            cargarFormulario(new FormRegistroPublicaciones(_administrador));
        }

        private void btnPendientes_Click(object sender, EventArgs e)
        {
            cargarFormulario(new FormPublicacionesPendientes(_administrador));
        }
    }
}
