using parcialUno.essentials.models;

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
            string username = txtUsuario.Text;
            string password = txtPassword.Text;

            if (await Fire.ContieneAsync("usuarios", username, "username"))
            {
                var usuarioDict = await Fire.GetAsync("usuarios", "username", username);
                if ((string)usuarioDict["password"] == password)
                {
                    Usuario usuarioIngresado = new Usuario(usuarioDict);
                    MessageBox.Show(usuarioIngresado.ToString());
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
        }
    }
}