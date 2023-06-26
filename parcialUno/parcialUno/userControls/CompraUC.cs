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
    public partial class CompraUC : UserControl
    {
        private Venta _compra;
        Action<Venta> _onClick;
        public CompraUC(Venta compra, Action<Venta> onClick)
        {
            InitializeComponent();
            _compra = compra;
            _onClick = onClick;
            labelNombre.Text = _compra.Nombre;
        }

        private void CompraUC_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Silver;
        }

        private void CompraUC_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void CompraUC_Click(object sender, EventArgs e)
        {
            _onClick.Invoke(_compra);
        }
    }
}
