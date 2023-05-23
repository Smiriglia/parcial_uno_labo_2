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
using System.Xml.Linq;

namespace parcialUno
{
    public partial class FormRegistroPublicaciones : Form
    {
        private Administrador _administrador;
        private ListaProductos _productos;
        private Producto? _productoSeleccionado = null;
        public FormRegistroPublicaciones(Administrador administrador)
        {
            InitializeComponent();
            _administrador = administrador;
            _productos = new ListaProductos();
        }

        private async Task CargarProductos()
        {
            _productos.Clear();
            await _productos.CargarFireAsync();
            dgProductos.DataSource = _productos.Productos;
        }

        private async void FormRegistroPublicaciones_Load(object sender, EventArgs e)
        {
            try
            {

                await CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _productoSeleccionado = _productos.Productos[e.RowIndex];
                labelId.Text = _productoSeleccionado.Id.ToString();
                txtNombre.Text = _productoSeleccionado.Nombre;
                txtDescripcion.Text = _productoSeleccionado.Descripcion;
                txtPrecio.Text = $"{_productoSeleccionado.Precio:F2}";
                txtEstado.Text = _productoSeleccionado.Estado;
                txtImagePath.Text = _productoSeleccionado.ImagePath;
                txtIdVendedor.Text = _productoSeleccionado.IdVendedor.ToString();
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                await _administrador.ModificarProductoAsync
                (
                    _productoSeleccionado,
                    txtNombre.Text,
                    txtDescripcion.Text,
                    txtPrecio.Text,
                    txtImagePath.Text,
                    txtEstado.Text,
                    txtIdVendedor.Text
                );
                await CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                await _administrador.EliminarProductoAsync(_productoSeleccionado);
                await CargarProductos();
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
