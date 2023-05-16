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
        private FormPrincipal _padre;
        public ProductoUC(Producto producto, int idUsuario, FormPrincipal padre)
        {
            _producto = producto;
            _idUsuario = idUsuario;
            _padre = padre;
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
            VistaProductoFire vpFire = new VistaProductoFire();
            int idVistaProducto = await vpFire.GetUltimoIdAsync() + 1;
            VistaProducto nuevaVP = new VistaProducto(idVistaProducto, _idUsuario, _producto);
            await vpFire.AddAsync(nuevaVP);
        }
    }
}
