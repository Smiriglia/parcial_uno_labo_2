namespace parcialUno
{
    partial class FormCarrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarrito));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            contenedorCarrito = new FlowLayoutPanel();
            imgCerrar = new PictureBox();
            btnComprar = new Button();
            labelTotal = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCerrar).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 16);
            label1.Name = "label1";
            label1.Size = new Size(54, 18);
            label1.TabIndex = 0;
            label1.Text = "Carrito";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.carrito;
            pictureBox1.Location = new Point(8, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // contenedorCarrito
            // 
            contenedorCarrito.AutoScroll = true;
            contenedorCarrito.Location = new Point(12, 45);
            contenedorCarrito.Name = "contenedorCarrito";
            contenedorCarrito.Size = new Size(295, 315);
            contenedorCarrito.TabIndex = 2;
            // 
            // imgCerrar
            // 
            imgCerrar.Cursor = Cursors.Hand;
            imgCerrar.Image = (Image)resources.GetObject("imgCerrar.Image");
            imgCerrar.Location = new Point(289, 3);
            imgCerrar.Margin = new Padding(4);
            imgCerrar.Name = "imgCerrar";
            imgCerrar.Size = new Size(18, 18);
            imgCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            imgCerrar.TabIndex = 10;
            imgCerrar.TabStop = false;
            imgCerrar.Click += imgCerrar_Click;
            // 
            // btnComprar
            // 
            btnComprar.FlatAppearance.BorderSize = 2;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnComprar.Location = new Point(12, 394);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(273, 40);
            btnComprar.TabIndex = 11;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotal.Location = new Point(183, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(87, 18);
            labelTotal.TabIndex = 12;
            labelTotal.Text = "Total: $3500";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelTotal);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(12, 366);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(273, 22);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // FormCarrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnComprar);
            Controls.Add(imgCerrar);
            Controls.Add(contenedorCarrito);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCarrito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCarrito";
            Load += FormCarrito_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCerrar).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel contenedorCarrito;
        private PictureBox imgCerrar;
        private Button btnComprar;
        private Label labelTotal;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}