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
using parcialUno.essentials.eventos;
using parcialUno.essentials.Factory;
using parcialUno.essentials.models;

namespace parcialUno.userControls
{
    public partial class ProductoUC : UserControl
    {
        private event Compra _funcCompra;
        private int _idUsuario;
        private Producto _producto;
        public ProductoUC(Producto producto, int idUsuario, Compra funcCompra)
        {
            _producto = producto;
            _idUsuario = idUsuario;
            InitializeComponent();
            labelNombre.Text = producto.Nombre;
            labelPrecio.Text = $"$ {producto.Precio:F2}";
            imgProducto.Image = Image.FromFile(producto.ImagePath);
            _funcCompra = funcCompra;
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

            FormCompra frmCompra = new FormCompra(_producto, _funcCompra);
            frmCompra.ShowDialog();
        }
    }
}
