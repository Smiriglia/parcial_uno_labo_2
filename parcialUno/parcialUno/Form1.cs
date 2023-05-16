using Google.Protobuf.WellKnownTypes;
using parcialUno.essentials.models;
using parcialUno.essentials.utilidades;
using System.Windows.Forms;

namespace parcialUno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            if (btnIngresar.Enabled)
            {
                btnIngresar.Enabled = false;
                string username = txtUsuario.Text;
                string password = txtPassword.Text;
                var usuario = await Validador.ValidarUsuario(username, password);
                if (usuario is null)
                {
                    MessageBox.Show("Error, No has ingresado un usuario valido");
                }
                else
                {
                    FormPrincipal nuevoFormulario = new FormPrincipal(usuario);
                    this.Hide();
                    nuevoFormulario.ShowDialog();
                    if (nuevoFormulario.DialogResult == DialogResult.OK)
                    {
                        this.Show();
                    }
                }
                btnIngresar.Enabled = true;
            }
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == (char)0)
            {
                btnOcultar.BackgroundImage = Properties.Resources.mostrar_contrasenia;
                txtPassword.PasswordChar = '•';
            }
            else
            {
                btnOcultar.BackgroundImage = Properties.Resources.ocultar_contrasenia;
                txtPassword.PasswordChar = (char)0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar_Click(sender, e);
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar_Click(sender, e);
                e.Handled = true;
            }
        }

        private void labelLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtPassword.Clear();
        }
    }
}