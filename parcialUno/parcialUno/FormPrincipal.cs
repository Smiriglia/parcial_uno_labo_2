using parcialUno.essentials.models;
using parcialUno.userControls;
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
    public partial class FormPrincipal : Form
    {
        private Usuario _usuario;
        private List<Producto> _productos = new List<Producto>();
        private bool _menuExpand = false;
        public FormPrincipal(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            contenedorMenu.Width = contenedorMenu.MinimumSize.Width;
            labelNombre.Text = _usuario.Nombre;
            labelDinero.Text = $"$ {_usuario.Dinero:F2}";
            if (usuario.Sector != "comprador")
            {
                //TODO ADMIN MENU
            }

        }

        private async void FormPrincipal_Load(object sender, EventArgs e)
        {
            var productosDict = await Fire.GetAsync("productos");
            var productosDictVistosUsuario = await Fire.GetAsync("vistaProductos", "idUsuario", _usuario.Id);
            var listaVistaProducto = new List<VistaProducto>();
            List<Producto> productosDesordenados = new List<Producto>();
            Dictionary<string, float> dictRelevancia;
            Producto nuevoProducto;
            ProductoUC nuevoProductoUC;

            foreach (var productoDict in productosDict)
            {
                nuevoProducto = new Producto(productoDict);
                productosDesordenados.Add(nuevoProducto);
            }

            foreach (var productoDictVP in productosDictVistosUsuario)
            {
                listaVistaProducto.Add(new VistaProducto(productoDictVP));
            }

            dictRelevancia = VistaProducto.CalcularRelevancia(listaVistaProducto);
            Producto.CalcularRelevancia(productosDesordenados, dictRelevancia);

            _productos = productosDesordenados.OrderBy(p => p.RelevanciaProducto).ToList();



            foreach (var producto in _productos)
            {
                nuevoProductoUC = new ProductoUC(producto);
                containerProductos.Controls.Add(nuevoProductoUC);
            }

        }

        private void imgCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgMenu_Click(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.OK;

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
    }
}
