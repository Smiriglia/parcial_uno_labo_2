using parcialUno.essentials.models;
using parcialUno.userControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Api.Distribution.Types;
using static System.Net.Mime.MediaTypeNames;
using Google.Rpc;
using Google.Type;
using System.Runtime.Intrinsics.Arm;
using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.Logging;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using parcialUno.essentials.utilidades;

namespace parcialUno
{
    public partial class FormPrincipal : Form
    {
        private Usuario _usuario;
        private ListaProductos _productos = new ListaProductos();
        private ListaProductos _carrito = new ListaProductos();
        private bool _menuExpand = false;

        public ListaProductos Carrito { get { return _carrito; } }
        public FormPrincipal(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            contenedorMenu.Width = contenedorMenu.MinimumSize.Width;
            labelNombre.Text = _usuario.Nombre;
            labelDinero.Text = $"$ {_usuario.Dinero:F2}";

            if (usuario.Sector != "comprador")
            {
                contenedorAdmin.Enabled = true;
                contenedorAdmin.Visible = true;

            }
            else
            {

                contenedorAdmin.Enabled = false;
                contenedorAdmin.Visible = false;
            }

        }

        private async void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {

                ProductoUC nuevoProductoUC;

                await _productos.CargarPublicadosFireAsync();
                await Ordenador.OrdenarPorRelevancia(_productos, _usuario.Id);

                foreach (Producto producto in _productos)
                {
                    nuevoProductoUC = new ProductoUC(producto, _usuario.Id, _carrito);
                    containerProductos.Controls.Add(nuevoProductoUC);
                }
            }
            catch
            {
                MessageBox.Show("Error de conexion");
            }
        }

        private void imgCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void imgMenu_Click(object sender, EventArgs e)
        {

        }
        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (_menuExpand)
            {
                contenedorMenu.Width -= 10;
                if (contenedorMenu.Width <= contenedorMenu.MinimumSize.Width)
                {
                    timerMenu.Stop();
                }
            }
            else
            {
                contenedorMenu.Width += 10;
                if (contenedorMenu.Width >= contenedorMenu.MaximumSize.Width)
                {
                    timerMenu.Stop();
                }
            }
        }

        private void contenedorMenu_MouseEnter(object sender, EventArgs e)
        {
            _menuExpand = false;
            timerMenu.Start();
        }

        private void contenedorMenu_MouseLeave(object sender, EventArgs e)
        {
            _menuExpand = true;
            timerMenu.Start();
        }

        private FlowLayoutPanel EncontrarFLPadre(object sender)
        {
            Control aux = (Control)sender;

            while (true)
            {
                if (aux.GetType() == typeof(FlowLayoutPanel))
                    break;
                aux = aux.Parent;
            }
            return (FlowLayoutPanel)aux;
        }
        private void contenedorVender_MouseEnter(object sender, EventArgs e)
        {
            FlowLayoutPanel senderCasteado = EncontrarFLPadre(sender);

            contenedorMenu_MouseEnter(sender, e);
            senderCasteado.ForeColor = System.Drawing.Color.WhiteSmoke;
            senderCasteado.BackColor = System.Drawing.Color.Silver;
        }

        private void contenedorVender_MouseLeave(object sender, EventArgs e)
        {
            FlowLayoutPanel senderCasteado = EncontrarFLPadre(sender);
            contenedorMenu_MouseLeave(sender, e);
            senderCasteado.ForeColor = System.Drawing.Color.Black;
            senderCasteado.BackColor = System.Drawing.Color.Transparent;
        }

        private void contenedorVender_Click(object sender, EventArgs e)
        {
            var formVenta = new FormVenta(_usuario.Id);
            formVenta.ShowDialog();
            if (formVenta.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Tu producto fue enviado correctamente y esta en revision");
            }
        }

        private void contenedorSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void contenedorCarrito_Click(object sender, EventArgs e)
        {
            FormCarrito frmCarrito = new FormCarrito(_carrito, _usuario);
            frmCarrito.ShowDialog();
            if (frmCarrito.DialogResult == DialogResult.OK)
            {
                labelDinero.Text = $"$ {_usuario.Dinero:F2}";
            }
        }

        private void contenedorAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin frmAdmin = new FormAdmin(_usuario);
            this.Hide();
            frmAdmin.ShowDialog();

            if(frmAdmin.DialogResult == DialogResult.OK)
                this.Show();
        }
    }
}
