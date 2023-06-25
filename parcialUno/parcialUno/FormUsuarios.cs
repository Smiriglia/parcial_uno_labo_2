using parcialUno.essentials.Factory;
using parcialUno.essentials.models;
using parcialUno.essentials.utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace parcialUno
{
    public partial class FormUsuarios : Form
    {
        private Administrador _administrador;
        private BindingList<Usuario> _usuarios;
        private Usuario? _usuarioSeleccionado;
        public FormUsuarios(Administrador administrador)
        {
            InitializeComponent();
            _usuarios = new BindingList<Usuario>();
            _administrador = administrador;
        }
        private async Task CargarUsuarios()
        {
            _usuarios.Clear();
            UsuarioFire usuarioFire = new UsuarioFire();
            var usuariosDict = await usuarioFire.GetAsync();
            foreach (var usuarioDict in usuariosDict)
            {
                Usuario nuevoUsuario = new Usuario(usuarioDict);
                _usuarios.Add(nuevoUsuario);
            }
        }

        private async void FormUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                await CargarUsuarios();
                dgUsuarios.DataSource = _usuarios;
            }
            catch
            {
                MessageBox.Show("Error de conexion",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _usuarioSeleccionado = _usuarios[e.RowIndex];
                labelId.Text = _usuarioSeleccionado.Id.ToString();
                txtUsername.Text = _usuarioSeleccionado.Username;
                txtPassword.Text = _usuarioSeleccionado.Password;
                txtNombre.Text = _usuarioSeleccionado.Nombre;
                txtDinero.Text = $"{_usuarioSeleccionado.Dinero:F2}";
                txtSector.Text = _usuarioSeleccionado.Sector;
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                await _administrador.ModificarUsuarioAsync
                    (
                    _usuarioSeleccionado,
                    txtUsername.Text,
                    txtPassword.Text,
                    txtDinero.Text,
                    txtNombre.Text,
                    txtSector.Text
                    );
                await CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private async void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                await Validador.ValidarNuevoUsuarioAsync
                (
                    txtUsername.Text,
                    txtNombre.Text,
                    txtPassword.Text,
                    txtSector.Text,
                    txtDinero.Text
                );
                await CargarUsuarios();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                await _administrador.EliminarUsuarioAsync(_usuarioSeleccionado);
                await CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                    ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
