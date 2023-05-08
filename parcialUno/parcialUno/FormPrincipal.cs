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
        public FormPrincipal(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
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
    }
}
