using Google.Protobuf.WellKnownTypes;
using parcialUno.essentials.excepciones;
using parcialUno.essentials.models;
using parcialUno.essentials.utilidades;
using System.Windows.Forms;

namespace parcialUno
{
    public partial class FormLogin : Form
    {
        public FormLogin()
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


                try
                {
                    var usuario = await Validador.ValidarUsuario(username, password);
                    FormPrincipal nuevoFormulario = new FormPrincipal(usuario);
                    if (checkBoxGuardar.Checked)
                    {
                        LoginRapido.GuardarLoginData(username, password);
                    }
                    else
                    {
                        LoginRapido.Eliminar();
                    }
                    this.Hide();
                    nuevoFormulario.ShowDialog();
                    if (nuevoFormulario.DialogResult == DialogResult.OK)
                    {
                        this.Show();
                    }
                }
                catch (Grpc.Core.RpcException ex)
                {
                    MessageBox.Show("Error, no se pudo establecer conexion con el servidor",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (UsuarioInvalidoException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void labelRegistrate_Click(object sender, EventArgs e)
        {
            FormRegistrarse frmRegistrarse = new FormRegistrarse();
            this.Hide();
            frmRegistrarse.ShowDialog();
            if (frmRegistrarse.DialogResult == DialogResult.OK)
                this.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            var datos = LoginRapido.CargarLoginData();
            if (datos != null)
            {
                txtUsuario.Text = datos["username"];
                txtPassword.Text = datos["password"];
                checkBoxGuardar.Checked = true;
            }
        }
    }
}