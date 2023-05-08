namespace parcialUno.userControls
{
    partial class ProductoUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoUC));
            imgProducto = new PictureBox();
            labelNombre = new Label();
            labelPrecio = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)imgProducto).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // imgProducto
            // 
            imgProducto.Image = (Image)resources.GetObject("imgProducto.Image");
            imgProducto.Location = new Point(0, 0);
            imgProducto.Name = "imgProducto";
            imgProducto.Size = new Size(179, 150);
            imgProducto.SizeMode = PictureBoxSizeMode.Zoom;
            imgProducto.TabIndex = 0;
            imgProducto.TabStop = false;
            imgProducto.MouseEnter += ProductoUC_MouseEnter;
            imgProducto.MouseLeave += ProductoUC_MouseLeave;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Bahnschrift", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.Location = new Point(3, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(208, 39);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Samsung S21";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrecio.Location = new Point(3, 51);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(79, 29);
            labelPrecio.TabIndex = 2;
            labelPrecio.Text = "$ 1950";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelPrecio, 0, 1);
            tableLayoutPanel1.Controls.Add(labelNombre, 0, 0);
            tableLayoutPanel1.Location = new Point(185, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(304, 102);
            tableLayoutPanel1.TabIndex = 4;
            tableLayoutPanel1.MouseEnter += ProductoUC_MouseEnter;
            tableLayoutPanel1.MouseLeave += ProductoUC_MouseLeave;
            // 
            // ProductoUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(imgProducto);
            Cursor = Cursors.Hand;
            Name = "ProductoUC";
            Size = new Size(492, 148);
            MouseEnter += ProductoUC_MouseEnter;
            MouseLeave += ProductoUC_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)imgProducto).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imgProducto;
        private Label labelNombre;
        private Label labelPrecio;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
