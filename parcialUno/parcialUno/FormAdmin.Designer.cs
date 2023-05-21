namespace parcialUno
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            imgCerrar = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            imgGrafico = new PictureBox();
            imgUsuarios = new PictureBox();
            imgVentas = new PictureBox();
            imgPublicaciones = new PictureBox();
            pictureBox1 = new PictureBox();
            contenedorPrincipal = new Panel();
            ((System.ComponentModel.ISupportInitialize)imgCerrar).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgGrafico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPublicaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imgCerrar
            // 
            imgCerrar.BackColor = Color.White;
            imgCerrar.Cursor = Cursors.Hand;
            imgCerrar.Image = (Image)resources.GetObject("imgCerrar.Image");
            imgCerrar.Location = new Point(776, 3);
            imgCerrar.Margin = new Padding(4);
            imgCerrar.Name = "imgCerrar";
            imgCerrar.Size = new Size(18, 18);
            imgCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            imgCerrar.TabIndex = 10;
            imgCerrar.TabStop = false;
            imgCerrar.Click += imgCerrar_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(imgGrafico);
            flowLayoutPanel1.Controls.Add(imgUsuarios);
            flowLayoutPanel1.Controls.Add(imgVentas);
            flowLayoutPanel1.Controls.Add(imgPublicaciones);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 135);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(64, 209);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // imgGrafico
            // 
            imgGrafico.BackColor = Color.Gray;
            imgGrafico.Cursor = Cursors.Hand;
            imgGrafico.Image = (Image)resources.GetObject("imgGrafico.Image");
            imgGrafico.Location = new Point(0, 0);
            imgGrafico.Margin = new Padding(0);
            imgGrafico.Name = "imgGrafico";
            imgGrafico.Size = new Size(64, 50);
            imgGrafico.SizeMode = PictureBoxSizeMode.Zoom;
            imgGrafico.TabIndex = 0;
            imgGrafico.TabStop = false;
            imgGrafico.Click += imgGrafico_Click;
            imgGrafico.MouseEnter += imgDashboard_MouseEnter;
            imgGrafico.MouseLeave += imgDashboard_MouseLeave;
            // 
            // imgUsuarios
            // 
            imgUsuarios.BackColor = Color.Gray;
            imgUsuarios.Cursor = Cursors.Hand;
            imgUsuarios.Image = (Image)resources.GetObject("imgUsuarios.Image");
            imgUsuarios.Location = new Point(0, 50);
            imgUsuarios.Margin = new Padding(0);
            imgUsuarios.Name = "imgUsuarios";
            imgUsuarios.Size = new Size(64, 50);
            imgUsuarios.SizeMode = PictureBoxSizeMode.Zoom;
            imgUsuarios.TabIndex = 0;
            imgUsuarios.TabStop = false;
            imgUsuarios.Click += imgUsuarios_Click;
            imgUsuarios.MouseEnter += imgDashboard_MouseEnter;
            imgUsuarios.MouseLeave += imgDashboard_MouseLeave;
            // 
            // imgVentas
            // 
            imgVentas.BackColor = Color.Gray;
            imgVentas.Cursor = Cursors.Hand;
            imgVentas.Image = (Image)resources.GetObject("imgVentas.Image");
            imgVentas.Location = new Point(0, 100);
            imgVentas.Margin = new Padding(0);
            imgVentas.Name = "imgVentas";
            imgVentas.Size = new Size(64, 50);
            imgVentas.SizeMode = PictureBoxSizeMode.Zoom;
            imgVentas.TabIndex = 0;
            imgVentas.TabStop = false;
            imgVentas.Click += imgVentas_Click;
            imgVentas.MouseEnter += imgDashboard_MouseEnter;
            imgVentas.MouseLeave += imgDashboard_MouseLeave;
            // 
            // imgPublicaciones
            // 
            imgPublicaciones.BackColor = Color.Gray;
            imgPublicaciones.Cursor = Cursors.Hand;
            imgPublicaciones.Image = (Image)resources.GetObject("imgPublicaciones.Image");
            imgPublicaciones.Location = new Point(0, 150);
            imgPublicaciones.Margin = new Padding(0);
            imgPublicaciones.Name = "imgPublicaciones";
            imgPublicaciones.Size = new Size(64, 50);
            imgPublicaciones.SizeMode = PictureBoxSizeMode.Zoom;
            imgPublicaciones.TabIndex = 0;
            imgPublicaciones.TabStop = false;
            imgPublicaciones.Click += imgPublicaciones_Click;
            imgPublicaciones.MouseEnter += imgDashboard_MouseEnter;
            imgPublicaciones.MouseLeave += imgDashboard_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-10, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // contenedorPrincipal
            // 
            contenedorPrincipal.Location = new Point(64, 47);
            contenedorPrincipal.Name = "contenedorPrincipal";
            contenedorPrincipal.Size = new Size(707, 377);
            contenedorPrincipal.TabIndex = 13;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(contenedorPrincipal);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(imgCerrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)imgCerrar).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgGrafico).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPublicaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imgCerrar;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox imgGrafico;
        private PictureBox pictureBox1;
        private Panel contenedorPrincipal;
        private PictureBox imgUsuarios;
        private PictureBox imgVentas;
        private PictureBox imgPublicaciones;
    }
}