using Google.Protobuf.WellKnownTypes;
using parcialUno.essentials.models;
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

                if (await Fire.ContieneAsync("usuarios", username, "username"))
                {
                    var usuarioDict = await Fire.GetOneAsync("usuarios", "username", username);
                    if ((string)usuarioDict["password"] == password)
                    {
                        Usuario usuarioIngresado = new Usuario(usuarioDict);
                        FormPrincipal nuevoFormulario = new FormPrincipal(usuarioIngresado);
                        this.Hide();
                        nuevoFormulario.ShowDialog();
                        if (nuevoFormulario.DialogResult == DialogResult.OK)
                        {
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error, Contraseña incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("Error, usuario inexistente");
                }
                btnIngresar.Enabled = true;
            }
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{txtPassword.PasswordChar}");
            if (txtPassword.PasswordChar == (char)0)
            {
                btnOcultar.BackgroundImage = Properties.Resources.mostrar_contrasenia;
                //btnOcultar.BackgroundImageLayout = ImageLayout.Stretch;
                txtPassword.PasswordChar = '•';
            }
            else
            {
                btnOcultar.BackgroundImage = Properties.Resources.ocultar_contrasenia;
                //btnOcultar.BackgroundImageLayout = ImageLayout.Stretch;
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