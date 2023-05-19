namespace parcialUno.userControls
{
    partial class ProductoCarritoUC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoCarritoUC));
            imgProducto = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelNombre = new Label();
            labelPrecio = new Label();
            imgBasura = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgProducto).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgBasura).BeginInit();
            SuspendLayout();
            // 
            // imgProducto
            // 
            imgProducto.Image = (Image)resources.GetObject("imgProducto.Image");
            imgProducto.Location = new Point(3, 4);
            imgProducto.Name = "imgProducto";
            imgProducto.Size = new Size(53, 50);
            imgProducto.SizeMode = PictureBoxSizeMode.Zoom;
            imgProducto.TabIndex = 0;
            imgProducto.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelNombre, 0, 0);
            tableLayoutPanel1.Controls.Add(labelPrecio, 0, 1);
            tableLayoutPanel1.Location = new Point(62, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.9433975F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.0566025F));
            tableLayoutPanel1.Size = new Size(155, 50);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.Location = new Point(3, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(104, 19);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Samsung S21";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrecio.Location = new Point(3, 25);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(59, 16);
            labelPrecio.TabIndex = 1;
            labelPrecio.Text = "$ 1950.50";
            // 
            // imgBasura
            // 
            imgBasura.Image = Properties.Resources.basura_cerrada;
            imgBasura.Location = new Point(227, 8);
            imgBasura.Name = "imgBasura";
            imgBasura.Size = new Size(31, 41);
            imgBasura.SizeMode = PictureBoxSizeMode.Zoom;
            imgBasura.TabIndex = 2;
            imgBasura.TabStop = false;
            imgBasura.Click += imgBasura_Click;
            imgBasura.MouseEnter += imgBasura_MouseEnter;
            imgBasura.MouseLeave += imgBasura_MouseLeave;
            // 
            // ProductoCarritoUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(imgBasura);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(imgProducto);
            Name = "ProductoCarritoUC";
            Size = new Size(268, 55);
            ((System.ComponentModel.ISupportInitialize)imgProducto).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgBasura).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imgProducto;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelNombre;
        private Label labelPrecio;
        private PictureBox imgBasura;
    }
}
