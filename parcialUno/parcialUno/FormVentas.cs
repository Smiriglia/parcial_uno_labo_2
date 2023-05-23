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
    public partial class FormVentas : Form
    {
        //private BindingList<Venta> _ventas;
        private Administrador _administrador;
        private ListaVentas _ventas;
        private Venta? _ventaSeleccionada = null;
        public FormVentas(Administrador administrador)
        {
            InitializeComponent();
            _ventas = new ListaVentas();
            _administrador = administrador;
        }
        private async Task CargarVentas()
        {
            _ventas.Clear();
            await _ventas.CargarFireAsync();
            dgVentas.DataSource = _ventas.Ventas;
        }

        private async void FormVentas_Load(object sender, EventArgs e)
        {
            await CargarVentas();
        }

        private void dgVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _ventaSeleccionada = _ventas.Ventas[e.RowIndex];
                labelId.Text = $"Id Seleccionado: {_ventaSeleccionada.Id}";
            }
        }

        private async void btnEntregar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> modificacion = new()
            {
                {"estado", "entregado" }
            };
            try
            {
                await _administrador.ModificarVentaAsync(_ventaSeleccionada, modificacion);
                await CargarVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
