namespace parcialUno
{
    partial class FormVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
            imgCerrar = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            imgProducto = new PictureBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            btnPublicar = new Button();
            txtEtiquetas = new TextBox();
            panel1 = new Panel();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)imgCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgProducto).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // imgCerrar
            // 
            imgCerrar.Cursor = Cursors.Hand;
            imgCerrar.Image = (Image)resources.GetObject("imgCerrar.Image");
            imgCerrar.Location = new Point(585, 4);
            imgCerrar.Margin = new Padding(4);
            imgCerrar.Name = "imgCerrar";
            imgCerrar.Size = new Size(18, 18);
            imgCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            imgCerrar.TabIndex = 10;
            imgCerrar.TabStop = false;
            imgCerrar.Click += imgCerrar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Archivos PNG (*.png)|*.png|Archivos JPG (*.JPG)|*.JPG";
            // 
            // imgProducto
            // 
            imgProducto.BorderStyle = BorderStyle.FixedSingle;
            imgProducto.Cursor = Cursors.Hand;
            imgProducto.Image = (Image)resources.GetObject("imgProducto.Image");
            imgProducto.Location = new Point(11, 11);
            imgProducto.Name = "imgProducto";
            imgProducto.Size = new Size(100, 96);
            imgProducto.SizeMode = PictureBoxSizeMode.Zoom;
            imgProducto.TabIndex = 11;
            imgProducto.TabStop = false;
            imgProducto.Click += imgProducto_Click;
            // 
            // txtNombre
            // 
            errorProvider1.SetIconPadding(txtNombre, 300);
            txtNombre.Location = new Point(117, 11);
            txtNombre.MaxLength = 18;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(130, 23);
            txtNombre.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(117, 40);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripcion";
            txtDescripcion.Size = new Size(484, 67);
            txtDescripcion.TabIndex = 13;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(253, 11);
            txtPrecio.MaxLength = 18;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 14;
            // 
            // btnPublicar
            // 
            btnPublicar.Cursor = Cursors.Hand;
            btnPublicar.FlatAppearance.BorderSize = 2;
            btnPublicar.FlatStyle = FlatStyle.Flat;
            btnPublicar.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPublicar.Location = new Point(526, 113);
            btnPublicar.Name = "btnPublicar";
            btnPublicar.Size = new Size(75, 23);
            btnPublicar.TabIndex = 15;
            btnPublicar.Text = "Publicar";
            btnPublicar.UseVisualStyleBackColor = true;
            btnPublicar.Click += btnPublicar_Click;
            // 
            // txtEtiquetas
            // 
            txtEtiquetas.Location = new Point(117, 113);
            txtEtiquetas.Name = "txtEtiquetas";
            txtEtiquetas.PlaceholderText = "Etiquetas (3 separadas por ',')";
            txtEtiquetas.Size = new Size(403, 23);
            txtEtiquetas.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnPublicar);
            panel1.Controls.Add(txtEtiquetas);
            panel1.Controls.Add(imgProducto);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(txtNombre);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(611, 146);
            panel1.TabIndex = 17;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 146);
            Controls.Add(imgCerrar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVenta";
            ((System.ComponentModel.ISupportInitialize)imgCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgProducto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imgCerrar;
        private OpenFileDialog openFileDialog1;
        private PictureBox imgProducto;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private Button btnPublicar;
        private TextBox txtEtiquetas;
        private Panel panel1;
        private ErrorProvider errorProvider1;
    }
}