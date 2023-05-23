using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using parcialUno.essentials.Factory;
using parcialUno.essentials.models;

namespace parcialUno.userControls
{
    public partial class ProductoUC : UserControl
    {
        private int _idUsuario;
        private Producto _producto;
        private ListaProductos _carrito;
        public ProductoUC(Producto producto, int idUsuario, ListaProductos carrito)
        {
            _producto = producto;
            _idUsuario = idUsuario;
            _carrito = carrito;
            InitializeComponent();
            labelNombre.Text = producto.Nombre;
            labelPrecio.Text = $"$ {producto.Precio:F2}";
            imgProducto.Image = Image.FromFile(producto.ImagePath);
        }

        private void ProductoUC_MouseEnter(object sender, EventArgs e)
        {
            ForeColor = Color.Silver;
        }

        private void ProductoUC_MouseLeave(object sender, EventArgs e)
        {
            ForeColor = Color.Black;
        }

        private async void ProductoUC_Click(object sender, EventArgs e)
        {
            
            VistaProducto? nuevaVp = await VistaProductoFactory.Crear(_idUsuario, _producto);
            if (nuevaVp != null)
                await nuevaVp.AddFireAsync();

            FormCompra frmCompra = new FormCompra(_producto);
            frmCompra.ShowDialog();
            if (frmCompra.DialogResult == DialogResult.OK)
            {
                _carrito.AddProducto(_producto);
            }
        }
    }
}
