using parcialUno.essentials.models;
using parcialUno.essentials.excepciones;
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
    public partial class FormAdmin : Form
    {
        private Administrador _administrador;
        private Color _colorAnterior = Color.Gray;
        private PictureBox? _opcionActual = null;
        public FormAdmin(Usuario _admin)
        {
            InitializeComponent();
            if (_admin.Sector != "comprador")
                _administrador = (Administrador)_admin;
            else
                throw new UsuarioInvalidoException();
        }

        private void imgCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cargarFormulario(Form form)
        {
            if (contenedorPrincipal.Controls.Count > 0)
                contenedorPrincipal.Controls.RemoveAt(0);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            contenedorPrincipal.Controls.Add(form);
            form.Show();
        }

        private void imgGrafico_Click(object sender, EventArgs e)
        {
            cambiarOpcionActual(sender);
            cargarFormulario(new FormGrafico());
        }

        private Color cambiarColor(object sender, Color color)
        {
            var sender_casteado = (PictureBox)sender;
            var colorAnterior = sender_casteado.BackColor;
            sender_casteado.BackColor = color;
            return colorAnterior;
        }

        private void imgDashboard_MouseEnter(object sender, EventArgs e)
        {
            _colorAnterior = cambiarColor(sender, Color.Silver);
        }

        private void imgDashboard_MouseLeave(object sender, EventArgs e)
        {
            cambiarColor(sender, _colorAnterior);
        }
        private void cambiarOpcionActual(object sender)
        {
            PictureBox senderCasteado = (PictureBox)sender;

            if (_opcionActual != null)
                _opcionActual.BackColor = Color.Gray;

            senderCasteado.BackColor = Color.LightGray;
            _colorAnterior = Color.LightGray;
            _opcionActual = senderCasteado;
        }

        private void imgUsuarios_Click(object sender, EventArgs e)
        {
            cambiarOpcionActual(sender);
            cargarFormulario(new FormUsuarios(_administrador));
        }

        private void imgVentas_Click(object sender, EventArgs e)
        {
            cambiarOpcionActual(sender);
            cargarFormulario(new FormVentas());
        }

        private void imgPublicaciones_Click(object sender, EventArgs e)
        {
            cambiarOpcionActual(sender);
            cargarFormulario(new FormPublicaciones());
        }
    }
}
