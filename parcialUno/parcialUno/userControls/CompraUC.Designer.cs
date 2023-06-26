namespace parcialUno.userControls
{
    partial class CompraUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompraUC));
            imgProducto = new PictureBox();
            labelNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)imgProducto).BeginInit();
            SuspendLayout();
            // 
            // imgProducto
            // 
            imgProducto.Image = (Image)resources.GetObject("imgProducto.Image");
            imgProducto.Location = new Point(3, 3);
            imgProducto.Name = "imgProducto";
            imgProducto.Size = new Size(42, 41);
            imgProducto.SizeMode = PictureBoxSizeMode.Zoom;
            imgProducto.TabIndex = 1;
            imgProducto.TabStop = false;
            imgProducto.Click += CompraUC_Click;
            imgProducto.MouseEnter += CompraUC_MouseEnter;
            imgProducto.MouseLeave += CompraUC_MouseLeave;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.Location = new Point(46, 16);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(83, 16);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Samsung S21";
            labelNombre.Click += CompraUC_Click;
            labelNombre.MouseEnter += CompraUC_MouseEnter;
            labelNombre.MouseLeave += CompraUC_MouseLeave;
            // 
            // CompraUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(imgProducto);
            Controls.Add(labelNombre);
            Margin = new Padding(0);
            Name = "CompraUC";
            Size = new Size(175, 47);
            Click += CompraUC_Click;
            MouseEnter += CompraUC_MouseEnter;
            MouseLeave += CompraUC_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)imgProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgProducto;
        private Label labelNombre;
    }
}
