using parcialUno.essentials.excepciones;
using parcialUno.essentials.models;
using parcialUno.essentials.utilidades;
using parcialUno.userControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace parcialUno
{
    public partial class FormCarrito : Form
    {
        ListaProductos _carrito;
        Usuario _usuario;
        float total;
        public FormCarrito(ListaProductos carrito, Usuario usuario)
        {
            InitializeComponent();
            _carrito = carrito;
            _usuario = usuario;
            ActualizarPrecio();
        }


        private void FormCarrito_Load(object sender, EventArgs e)
        {
            ProductoCarritoUC nuevoProductoCarritoUC;
            foreach (Producto producto in _carrito)
            {
                nuevoProductoCarritoUC = new ProductoCarritoUC(this, producto);
                contenedorCarrito.Controls.Add(nuevoProductoCarritoUC);
            }

        }

        private void imgCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        private async void btnComprar_Click(object sender, EventArgs e)
        {
            btnComprar.Enabled = false;
            try
            {
                int codigoSalida = await _usuario.ComprarAsync(_carrito);
                switch (codigoSalida)
                {
                    case 0:
                        MessageBox.Show("La compra se ha realizado correctamente");
                        DialogResult = DialogResult.OK;
                        break;
                    case 1:
                        MessageBox.Show("Ha habido un problema con la compra de algunos productos");
                        DialogResult = DialogResult.OK;
                        break;
                    case 2:
                        MessageBox.Show("Ha habido un problema con la compra");
                        break;

                }
                
            }
            catch (SaldoInsuficienteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (CarritoVacioException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al intentar relizar la compra");
            }
            btnComprar.Enabled = true;
        }
        public void EliminarProducto(Producto producto, ProductoCarritoUC productoCarritoUC)
        {
            _carrito.RemoveProducto(producto);
            contenedorCarrito.Controls.Remove(productoCarritoUC);
            ActualizarPrecio();
        }

        private void ActualizarPrecio()
        {
            total = _carrito.CalcularPrecio();
            labelTotal.Text = $"Total: $ {total:F2}";
        }
    }
}
