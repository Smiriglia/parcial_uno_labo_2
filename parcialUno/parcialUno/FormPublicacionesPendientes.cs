using parcialUno.essentials.Factory;
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
    public partial class FormPublicacionesPendientes : Form
    {
        private Administrador _administrador;
        private Producto? _producto;
        private Usuario? _vendedor;
        public FormPublicacionesPendientes(Administrador administrador)
        {
            InitializeComponent();
            _administrador = administrador;
        }
        private async Task CargarProducto()
        {
            try
            {

                ProductoFire productoFire = new ProductoFire();
                var productoDict = await productoFire.GetOneAsync("estado", "revision");
                _producto = new Producto(productoDict);
                MostrarProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay productos pendientes",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void MostrarProducto()
        {
            if (_producto != null)
            {
                labelDescripcion.Text = _producto.Descripcion;
                labelNombre.Text = _producto.Nombre;
                labelPrecio.Text = $"$ {_producto.Precio:F2}";
                imgProducto.Image = Image.FromFile(_producto.ImagePath);
            }
        }

        private async Task CargarUsuario()
        {
            try
            {

                if (_producto != null)
                {
                    Usuario vendedor = await UsuarioFactory.getUsuarioAsync(_producto.IdVendedor);
                    _vendedor = vendedor;
                    labelNombreUsuario.Text = vendedor.Nombre;
                }
            }
            catch
            {
                MessageBox.Show("Problema de conexion",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void FormPublicacionesPendientes_Load(object sender, EventArgs e)
        {
            await CargarProducto();
            await CargarUsuario();
        }
        private async Task DarRevision(string estado)
        {
            Dictionary<string, object> modificacion = new()
            {
                { "estado", estado }
            };
            await _administrador.ModificarProductoAsync(_producto, modificacion);
            await CargarProducto();
            await CargarUsuario();
        }
        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                await DarRevision("publicado");
            }
            catch
            {
                MessageBox.Show("Error de conexion",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRechazar_Click(object sender, EventArgs e)
        {
            try
            {
                await DarRevision("rechazado");
            }
            catch
            {
                MessageBox.Show("Error de conexion",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
