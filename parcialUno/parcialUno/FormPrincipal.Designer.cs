namespace parcialUno
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            containerProductos = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            imgCerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCerrar).BeginInit();
            SuspendLayout();
            // 
            // containerProductos
            // 
            containerProductos.Location = new Point(203, 1);
            containerProductos.Name = "containerProductos";
            containerProductos.Size = new Size(580, 440);
            containerProductos.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-13, -6);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(214, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // imgCerrar
            // 
            imgCerrar.Cursor = Cursors.Hand;
            imgCerrar.Image = (Image)resources.GetObject("imgCerrar.Image");
            imgCerrar.Location = new Point(778, 2);
            imgCerrar.Margin = new Padding(4);
            imgCerrar.Name = "imgCerrar";
            imgCerrar.Size = new Size(18, 18);
            imgCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            imgCerrar.TabIndex = 9;
            imgCerrar.TabStop = false;
            imgCerrar.Click += imgCerrar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(imgCerrar);
            Controls.Add(pictureBox2);
            Controls.Add(containerProductos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel containerProductos;
        private PictureBox pictureBox2;
        private PictureBox imgCerrar;
    }
}