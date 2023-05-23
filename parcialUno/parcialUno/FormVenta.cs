using Google.Protobuf.WellKnownTypes;
using parcialUno.essentials.Factory;
using parcialUno.essentials.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcialUno
{
    public partial class FormVenta : Form
    {
        private string _pathImage = "";
        private int _idUsuario;
        public FormVenta(int idUsuario)
        {
            _idUsuario = idUsuario;
            InitializeComponent();
        }

        private void imgProducto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgProducto.Image = Image.FromFile(openFileDialog1.FileName);
                _pathImage = openFileDialog1.FileName;
            }
        }

        private void imgCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private async void btnPublicar_Click(object sender, EventArgs e)
        {
            float precio;
            List<string> etiquetas;
            int id;
            Regex regex = new Regex(@"^[a-zA-Z\-]+,[a-zA-Z\-]+,[a-zA-Z\-]+$");

            bool errorNombreVacio = txtNombre.Text.Trim() == "";
            bool errorPrecioVacio = txtPrecio.Text.Trim() == "";
            bool errorPrecioNoNumerico = !float.TryParse(txtPrecio.Text.Trim().Replace(".", ","), out precio);
            bool errorDescripcionVacia = txtNombre.Text.Trim() == "";
            bool errorImagenVacia = _pathImage.Trim() == "";
            bool errorEtiquetaVacia = txtEtiquetas.Text.Trim() == "";
            bool errotEtiquetaMalFormato = !regex.IsMatch(txtEtiquetas.Text);

            etiquetas = new List<string>(txtEtiquetas.Text.Trim().ToLower().Split(','));

            if (!(errorNombreVacio ||
                errorPrecioVacio ||
                errorPrecioNoNumerico ||
                errorDescripcionVacia ||
                errorImagenVacia ||
                errorEtiquetaVacia ||
                errotEtiquetaMalFormato))
            {
                try
                {

                    await ProductoFactory.CrearProducto
                    (
                        txtNombre.Text.Trim(),
                        txtDescripcion.Text.Trim(),
                        precio,
                        etiquetas,
                        _pathImage,
                        _idUsuario
                    );
                }
                catch
                {
                    MessageBox.Show("Error de conexion",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                errorProvider1.Clear();
                if (errorNombreVacio)
                {
                    errorProvider1.SetError(txtNombre, "El nombre no puede estar vacio");
                    errorProvider1.SetIconPadding(txtNombre, -20);
                }

                if (errorPrecioVacio)
                {
                    errorProvider1.SetError(txtPrecio, "El precio no puede estar vacio");
                    errorProvider1.SetIconPadding(txtPrecio, -20);
                }
                else if (errorPrecioNoNumerico)
                {
                    errorProvider1.SetError(txtPrecio, "El precio deberia ser un numero");
                    errorProvider1.SetIconPadding(txtPrecio, -20);
                }

                if (errorDescripcionVacia)
                {
                    errorProvider1.SetError(txtDescripcion, "La descripcion no deberia estar vacia");
                    errorProvider1.SetIconPadding(txtDescripcion, -20);
                }

                if (errorImagenVacia)
                {
                    errorProvider1.SetError(imgProducto, "No has elegido una imagen para el producto");
                    errorProvider1.SetIconPadding(imgProducto, -20);
                }

                if (errorEtiquetaVacia)
                {
                    errorProvider1.SetError(txtEtiquetas, "No has elegido una imagen para el producto");
                    errorProvider1.SetIconPadding(txtEtiquetas, -20);
                }
                else if (errotEtiquetaMalFormato)
                {
                    errorProvider1.SetError(txtEtiquetas, "Error, formato incorrecto");
                    errorProvider1.SetIconPadding(txtEtiquetas, -20);
                }
            }
        }
    }
}
