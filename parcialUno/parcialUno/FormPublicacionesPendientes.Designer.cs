namespace parcialUno
{
    partial class FormPublicacionesPendientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPublicacionesPendientes));
            imgCarrito = new PictureBox();
            btnAgregar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            labelNombre = new Label();
            labelPrecio = new Label();
            labelDescripcion = new Label();
            imgProducto = new PictureBox();
            labelNombreUsuario = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnAceptar = new Button();
            btnRechazar = new Button();
            ((System.ComponentModel.ISupportInitialize)imgCarrito).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imgCarrito
            // 
            imgCarrito.BackColor = Color.White;
            imgCarrito.Cursor = Cursors.Hand;
            imgCarrito.Image = (Image)resources.GetObject("imgCarrito.Image");
            imgCarrito.Location = new Point(279, 204);
            imgCarrito.Name = "imgCarrito";
            imgCarrito.Size = new Size(40, 35);
            imgCarrito.SizeMode = PictureBoxSizeMode.Zoom;
            imgCarrito.TabIndex = 19;
            imgCarrito.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.White;
            btnAgregar.BackgroundImageLayout = ImageLayout.None;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(273, 199);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(304, 42);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar al carrito";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(labelDescripcion, 0, 1);
            tableLayoutPanel1.Location = new Point(273, 91);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.00971F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.99029F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(304, 110);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelNombre);
            flowLayoutPanel1.Controls.Add(labelPrecio);
            flowLayoutPanel1.Location = new Point(4, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(296, 28);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.Location = new Point(0, 3);
            labelNombre.Margin = new Padding(0, 3, 3, 3);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(157, 18);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "No hay mas productos";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrecio.Location = new Point(163, 3);
            labelPrecio.Margin = new Padding(3);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(28, 18);
            labelPrecio.TabIndex = 2;
            labelPrecio.Text = "$ -";
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Location = new Point(4, 37);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(12, 15);
            labelDescripcion.TabIndex = 5;
            labelDescripcion.Text = "-";
            // 
            // imgProducto
            // 
            imgProducto.BackColor = Color.White;
            imgProducto.BorderStyle = BorderStyle.FixedSingle;
            imgProducto.Image = (Image)resources.GetObject("imgProducto.Image");
            imgProducto.Location = new Point(94, 91);
            imgProducto.Name = "imgProducto";
            imgProducto.Size = new Size(179, 150);
            imgProducto.SizeMode = PictureBoxSizeMode.Zoom;
            imgProducto.TabIndex = 16;
            imgProducto.TabStop = false;
            // 
            // labelNombreUsuario
            // 
            labelNombreUsuario.AutoSize = true;
            labelNombreUsuario.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombreUsuario.Location = new Point(168, 17);
            labelNombreUsuario.Name = "labelNombreUsuario";
            labelNombreUsuario.Size = new Size(68, 23);
            labelNombreUsuario.TabIndex = 21;
            labelNombreUsuario.Text = "Fausto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(94, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(168, 40);
            label2.Name = "label2";
            label2.Size = new Size(153, 23);
            label2.TabIndex = 21;
            label2.Text = "Publicaciones: 10";
            // 
            // btnAceptar
            // 
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.Location = new Point(413, 247);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(164, 34);
            btnAceptar.TabIndex = 22;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnRechazar
            // 
            btnRechazar.Cursor = Cursors.Hand;
            btnRechazar.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            btnRechazar.FlatStyle = FlatStyle.Flat;
            btnRechazar.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRechazar.Location = new Point(243, 247);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(164, 34);
            btnRechazar.TabIndex = 22;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = true;
            btnRechazar.Click += btnRechazar_Click;
            // 
            // FormPublicacionesPendientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(708, 342);
            Controls.Add(btnRechazar);
            Controls.Add(btnAceptar);
            Controls.Add(label2);
            Controls.Add(labelNombreUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(imgCarrito);
            Controls.Add(btnAgregar);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(imgProducto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPublicacionesPendientes";
            Text = "FormPublicacionesPendientes";
            Load += FormPublicacionesPendientes_Load;
            ((System.ComponentModel.ISupportInitialize)imgCarrito).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox imgCarrito;
        private Button btnAgregar;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelNombre;
        private Label labelPrecio;
        private Label labelDescripcion;
        private PictureBox imgProducto;
        private Label labelNombreUsuario;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnAceptar;
        private Button btnRechazar;
    }
}