using Google.Protobuf.WellKnownTypes;
using parcialUno.essentials.models;
using parcialUno.essentials.utilidades;
using System.Windows.Forms;

namespace parcialUno
{
    public partial class FormRegistrarse : Form
    {
        public FormRegistrarse()
        {
            InitializeComponent();
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (btnRegistrar.Enabled)
            {
                btnRegistrar.Enabled = false;
                string username = txtUsuario.Text;
                string nombre = txtNombre.Text;
                string password = txtPassword.Text;
                string password2 = txtPassword2.Text;


                try
                {
                    await Validador.ValidadarNuevoUsuarioAsync
                    (
                        username,
                        nombre,
                        password,
                        password2
                    );
                    MessageBox.Show("Usuario Creado Exitosamente",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                catch (Grpc.Core.RpcException ex)
                {
                    MessageBox.Show("Error, no se pudo establecer conexion con el servidor",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                btnRegistrar.Enabled = true;
            }
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == (char)0)
            {
                btnOcultar.BackgroundImage = Properties.Resources.mostrar_contrasenia;
                txtPassword.PasswordChar = '•';
                txtPassword2.PasswordChar = '•';
            }
            else
            {
                btnOcultar.BackgroundImage = Properties.Resources.ocultar_contrasenia;
                txtPassword.PasswordChar = (char)0;
                txtPassword2.PasswordChar = (char)0;
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
                btnRegistrar_Click(sender, e);
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnRegistrar_Click(sender, e);
                e.Handled = true;
            }
        }

        private void labelLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtPassword.Clear();
        }

        private void labelLoguearse_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}