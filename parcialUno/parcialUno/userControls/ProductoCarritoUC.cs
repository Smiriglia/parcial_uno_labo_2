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

namespace parcialUno.userControls
{
    public partial class ProductoCarritoUC : UserControl
    {
        private FormCarrito _frmPadre;
        private Producto _producto;
        public ProductoCarritoUC(FormCarrito frmPadre, Producto producto)
        {
            InitializeComponent();
            _frmPadre = frmPadre;
            _producto = producto;
            labelNombre.Text = producto.Nombre;
            labelPrecio.Text = $"$ {producto.Precio:F2}";
            imgProducto.Image = Image.FromFile(producto.ImagePath);
        }

        private void imgBasura_MouseEnter(object sender, EventArgs e)
        {
            imgBasura.Image = Properties.Resources.basura_abierta;
        }

        private void imgBasura_MouseLeave(object sender, EventArgs e)
        {
            imgBasura.Image = Properties.Resources.basura_cerrada;
        }

        private void imgBasura_Click(object sender, EventArgs e)
        {
            _frmPadre.EliminarProducto(_producto, this);
            this.Dispose();
        }
    }
}
