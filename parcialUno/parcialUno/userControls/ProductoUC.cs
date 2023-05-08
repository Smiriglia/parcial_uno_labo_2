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
using parcialUno.essentials.models;

namespace parcialUno.userControls
{
    public partial class ProductoUC : UserControl
    {
        private Producto _producto;
        public ProductoUC(Producto producto)
        {
            _producto = producto;
            InitializeComponent();
            labelNombre.Text = producto.Nombre;
            labelPrecio.Text = $"$ {producto.Precio:F2}";
            imgProducto.Image = Image.FromFile(_producto.ImagePath);
        }

        private void ProductoUC_MouseEnter(object sender, EventArgs e)
        {
            ForeColor = Color.Silver;
        }

        private void ProductoUC_MouseLeave(object sender, EventArgs e)
        {
            ForeColor = Color.Black;
        }
    }
}
