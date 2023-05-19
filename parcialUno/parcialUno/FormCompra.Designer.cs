namespace parcialUno
{
    partial class FormCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompra));
            panel1 = new Panel();
            imgCarrito = new PictureBox();
            btnAgregar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            labelNombre = new Label();
            labelPrecio = new Label();
            labelDescripcion = new Label();
            imgProducto = new PictureBox();
            imgCerrar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgCarrito).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(imgCarrito);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(imgProducto);
            panel1.Controls.Add(imgCerrar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 225);
            panel1.TabIndex = 0;
            // 
            // imgCarrito
            // 
            imgCarrito.Cursor = Cursors.Hand;
            imgCarrito.Image = (Image)resources.GetObject("imgCarrito.Image");
            imgCarrito.Location = new Point(196, 146);
            imgCarrito.Name = "imgCarrito";
            imgCarrito.Size = new Size(40, 35);
            imgCarrito.SizeMode = PictureBoxSizeMode.Zoom;
            imgCarrito.TabIndex = 15;
            imgCarrito.TabStop = false;
            imgCarrito.Click += btnAgregar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackgroundImageLayout = ImageLayout.None;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(190, 141);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(304, 42);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar al carrito";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(labelDescripcion, 0, 1);
            tableLayoutPanel1.Location = new Point(190, 33);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.00971F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.99029F));
            tableLayoutPanel1.Size = new Size(304, 110);
            tableLayoutPanel1.TabIndex = 13;
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
            labelNombre.Size = new Size(96, 18);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Samsung S21";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrecio.Location = new Point(102, 3);
            labelPrecio.Margin = new Padding(3);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(50, 18);
            labelPrecio.TabIndex = 2;
            labelPrecio.Text = "$ 1950";
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Location = new Point(4, 37);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(296, 45);
            labelDescripcion.TabIndex = 5;
            labelDescripcion.Text = "El Samsung Galaxy S21 es un smartphone de alta gama con pantalla de 6,2 pulgadas, cámara de 64 MP, batería de 4000 mAh y procesador Exynos 2100.";
            // 
            // imgProducto
            // 
            imgProducto.BorderStyle = BorderStyle.FixedSingle;
            imgProducto.Image = (Image)resources.GetObject("imgProducto.Image");
            imgProducto.Location = new Point(11, 33);
            imgProducto.Name = "imgProducto";
            imgProducto.Size = new Size(179, 150);
            imgProducto.SizeMode = PictureBoxSizeMode.Zoom;
            imgProducto.TabIndex = 12;
            imgProducto.TabStop = false;
            // 
            // imgCerrar
            // 
            imgCerrar.Cursor = Cursors.Hand;
            imgCerrar.Image = (Image)resources.GetObject("imgCerrar.Image");
            imgCerrar.Location = new Point(504, 4);
            imgCerrar.Margin = new Padding(4);
            imgCerrar.Name = "imgCerrar";
            imgCerrar.Size = new Size(18, 18);
            imgCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            imgCerrar.TabIndex = 11;
            imgCerrar.TabStop = false;
            imgCerrar.Click += imgCerrar_Click;
            // 
            // FormCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(527, 225);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCompra";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgCarrito).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox imgCerrar;
        private PictureBox imgCarrito;
        private Button btnAgregar;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelNombre;
        private Label labelPrecio;
        private Label labelDescripcion;
        private PictureBox imgProducto;
    }
}