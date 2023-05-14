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
        private int _idUsuario;
        private Producto _producto;
        public ProductoUC(Producto producto, int idUsuario)
        {
            _producto = producto;
            _idUsuario = idUsuario;
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

        private async void ProductoUC_Click(object sender, EventArgs e)
        {
            int idVistaProducto = await Fire.GetUltimoIdAsync("vistaProductos") + 1;
            VistaProducto nuevaVP = new VistaProducto(idVistaProducto, _idUsuario, _producto);
            await Fire.AddAsync("vistaProductos", nuevaVP);
        }
    }
}
