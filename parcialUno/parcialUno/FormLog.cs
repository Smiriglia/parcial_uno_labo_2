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

namespace parcialUno
{
    public partial class FormLog : Form
    {
        private Administrador _administrador;
        private ListaClicks _clicks;
        public FormLog(Administrador administrador)
        {
            InitializeComponent();
            _administrador = administrador;
            _clicks = new ListaClicks();
        }

        private async Task CargarVentasAsync()
        {
            _clicks.Clear();
            await _clicks.CargarFireAsync();
            dgLog.DataSource = _clicks.Clicks;
        }

        private async void FormLog_Load(object sender, EventArgs e)
        {
            await CargarVentasAsync();
        }
    }
}
