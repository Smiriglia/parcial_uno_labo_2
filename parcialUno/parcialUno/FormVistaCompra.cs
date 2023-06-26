using parcialUno.essentials.models;
using parcialUno.userControls;
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
    public partial class FormVistaCompra : Form
    {
        public FormVistaCompra(Venta compra)
        {
            InitializeComponent();
            labelNombre.Text = compra.Nombre;
            labelPrecio.Text = $"$ {compra.Precio:F2}";
            labelEstado.Text = compra.Estado;
        }
    }
}
