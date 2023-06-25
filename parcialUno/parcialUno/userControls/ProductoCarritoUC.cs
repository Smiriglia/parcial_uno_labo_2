using parcialUno.essentials.eventos;
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
        private Producto _producto;
        private event EliminaProducto _eliminaProducto;
        public ProductoCarritoUC(Producto producto, EliminaProducto funcEliminar)
        {
            InitializeComponent();
            _producto = producto;
            labelNombre.Text = producto.Nombre;
            labelPrecio.Text = $"$ {producto.Precio:F2}";
            imgProducto.Image = Image.FromFile(producto.ImagePath);
            _eliminaProducto += funcEliminar;
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
            _eliminaProducto?.Invoke(this, _producto);
            this.Dispose();
        }
    }
}
