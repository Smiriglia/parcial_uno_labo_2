using System.Windows.Forms;

namespace parcialUno
{
    partial class FormCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompras));
            imgCerrar = new PictureBox();
            imgMenu = new PictureBox();
            containerCompra = new FlowLayoutPanel();
            contenedorPrincipal = new Panel();
            ((System.ComponentModel.ISupportInitialize)imgCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgMenu).BeginInit();
            SuspendLayout();
            // 
            // imgCerrar
            // 
            imgCerrar.Cursor = Cursors.Hand;
            imgCerrar.Image = (Image)resources.GetObject("imgCerrar.Image");
            imgCerrar.Location = new Point(776, 4);
            imgCerrar.Margin = new Padding(4);
            imgCerrar.Name = "imgCerrar";
            imgCerrar.Size = new Size(18, 18);
            imgCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            imgCerrar.TabIndex = 10;
            imgCerrar.TabStop = false;
            imgCerrar.Click += imgCerrar_Click;
            // 
            // imgMenu
            // 
            imgMenu.Cursor = Cursors.Hand;
            imgMenu.Image = (Image)resources.GetObject("imgMenu.Image");
            imgMenu.Location = new Point(-10, -12);
            imgMenu.Name = "imgMenu";
            imgMenu.Size = new Size(199, 77);
            imgMenu.SizeMode = PictureBoxSizeMode.Zoom;
            imgMenu.TabIndex = 11;
            imgMenu.TabStop = false;
            imgMenu.Click += imgMenu_Click;
            // 
            // containerCompra
            // 
            containerCompra.AutoScroll = true;
            containerCompra.Location = new Point(2, 65);
            containerCompra.Margin = new Padding(0);
            containerCompra.Name = "containerCompra";
            containerCompra.Size = new Size(206, 386);
            containerCompra.TabIndex = 12;
            // 
            // contenedorPrincipal
            // 
            contenedorPrincipal.Location = new Point(209, 1);
            contenedorPrincipal.Name = "contenedorPrincipal";
            contenedorPrincipal.Size = new Size(592, 450);
            contenedorPrincipal.TabIndex = 14;
            // 
            // FormCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(containerCompra);
            Controls.Add(imgMenu);
            Controls.Add(imgCerrar);
            Controls.Add(contenedorPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCompras";
            Load += FormCompras_Load;
            ((System.ComponentModel.ISupportInitialize)imgCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imgCerrar;
        private PictureBox imgMenu;
        private FlowLayoutPanel containerCompra;
        private Panel contenedorPrincipal;
    }
}