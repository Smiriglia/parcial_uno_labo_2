namespace parcialUno
{
    partial class FormRegistroPublicaciones
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
            btnEliminar = new Button();
            btnModificar = new Button();
            labelId = new Label();
            txtDescripcion = new TextBox();
            dgProductos = new DataGridView();
            txtPrecio = new TextBox();
            txtImagePath = new TextBox();
            txtNombre = new TextBox();
            txtEstado = new TextBox();
            txtIdVendedor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(604, 310);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 27);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(604, 277);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 27);
            btnModificar.TabIndex = 15;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelId.Location = new Point(6, 219);
            labelId.Margin = new Padding(3, 5, 3, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(17, 19);
            labelId.TabIndex = 12;
            labelId.Text = "-";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(3, 244);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripcion";
            txtDescripcion.Size = new Size(595, 93);
            txtDescripcion.TabIndex = 7;
            // 
            // dgProductos
            // 
            dgProductos.AllowUserToAddRows = false;
            dgProductos.AllowUserToResizeColumns = false;
            dgProductos.AllowUserToResizeRows = false;
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgProductos.Location = new Point(3, 12);
            dgProductos.MultiSelect = false;
            dgProductos.Name = "dgProductos";
            dgProductos.ReadOnly = true;
            dgProductos.RowTemplate.Height = 25;
            dgProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProductos.Size = new Size(703, 197);
            dgProductos.TabIndex = 6;
            dgProductos.CellClick += dgProductos_CellClick;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(161, 218);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio";
            txtPrecio.Size = new Size(75, 23);
            txtPrecio.TabIndex = 8;
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(242, 218);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.PlaceholderText = "Image Path";
            txtImagePath.Size = new Size(175, 23);
            txtImagePath.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(29, 218);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(126, 23);
            txtNombre.TabIndex = 10;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(423, 218);
            txtEstado.Name = "txtEstado";
            txtEstado.PlaceholderText = "Estado";
            txtEstado.Size = new Size(88, 23);
            txtEstado.TabIndex = 11;
            // 
            // txtIdVendedor
            // 
            txtIdVendedor.Location = new Point(515, 218);
            txtIdVendedor.Name = "txtIdVendedor";
            txtIdVendedor.PlaceholderText = "Id Vendedor";
            txtIdVendedor.Size = new Size(83, 23);
            txtIdVendedor.TabIndex = 11;
            // 
            // FormRegistroPublicaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(708, 342);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(labelId);
            Controls.Add(txtDescripcion);
            Controls.Add(dgProductos);
            Controls.Add(txtPrecio);
            Controls.Add(txtImagePath);
            Controls.Add(txtNombre);
            Controls.Add(txtIdVendedor);
            Controls.Add(txtEstado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistroPublicaciones";
            Text = "FormRegistroPublicaciones";
            Load += FormRegistroPublicaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnModificar;
        private Label labelId;
        private TextBox txtDescripcion;
        private DataGridView dgProductos;
        private TextBox txtPrecio;
        private TextBox txtImagePath;
        private TextBox txtNombre;
        private TextBox txtEstado;
        private TextBox txtIdVendedor;
    }
}