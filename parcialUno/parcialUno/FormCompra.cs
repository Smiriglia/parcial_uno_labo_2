using parcialUno.essentials.eventos;
using parcialUno.essentials.models;
using parcialUno.utilidades;
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
    public partial class FormCompra : Form
    {
        private event Compra _comprar;
        private Producto _producto;
        RegistradorClicks _registradorClicks;
        public FormCompra(Producto producto, Compra añadirCarrito, int idUsuario)
        {

            InitializeComponent();
            _producto = producto;
            labelDescripcion.Text = producto.Descripcion;
            labelNombre.Text = producto.Nombre;
            labelPrecio.Text = $"$ {producto.Precio:F2}";
            imgProducto.Image = Image.FromFile(producto.ImagePath);
            _registradorClicks = new RegistradorClicks(idUsuario, Controls);
            _comprar += añadirCarrito;
        }

        private void imgCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _comprar?.Invoke(_producto);
            DialogResult = DialogResult.OK;
        }
    }
}
