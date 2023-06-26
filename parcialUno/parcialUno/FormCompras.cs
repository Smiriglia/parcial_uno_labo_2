using parcialUno.essentials.models;
using parcialUno.userControls;
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
    public partial class FormCompras : Form
    {
        private Usuario _usuario;
        public FormCompras(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void imgCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void imgMenu_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private async Task CargarCompras()
        {
            ListaVentas compras = new ListaVentas();
            await compras.CargarFireAsync(_usuario.Id);
            foreach (Venta compra in compras.Ventas)
            {
                CompraUC nuevo = new CompraUC(compra, CompraUC_Click);
                containerCompra.Controls.Add(nuevo);
            }
        }

        private async void FormCompras_Load(object sender, EventArgs e)
        {
            await CargarCompras();
        }

        private void CompraUC_Click(Venta compra)
        {
            var formCompra = new FormVistaCompra(compra);
            cargarFormulario(formCompra);
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
    }
}
