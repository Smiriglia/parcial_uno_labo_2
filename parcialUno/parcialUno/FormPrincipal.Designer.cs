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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            containerProductos = new FlowLayoutPanel();
            imgCerrar = new PictureBox();
            contenedorMenu = new TableLayoutPanel();
            imgMenu1 = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelDinero = new Label();
            labelNombre = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            timerMenu = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)imgCerrar).BeginInit();
            contenedorMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgMenu1).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // containerProductos
            // 
            containerProductos.Location = new Point(214, 3);
            containerProductos.Name = "containerProductos";
            containerProductos.Size = new Size(549, 450);
            containerProductos.TabIndex = 0;
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
            // contenedorMenu
            // 
            contenedorMenu.BackColor = SystemColors.ActiveBorder;
            contenedorMenu.ColumnCount = 1;
            contenedorMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contenedorMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contenedorMenu.Controls.Add(imgMenu1, 0, 0);
            contenedorMenu.Controls.Add(flowLayoutPanel2, 0, 1);
            contenedorMenu.Location = new Point(3, 3);
            contenedorMenu.MaximumSize = new Size(205, 459);
            contenedorMenu.MinimumSize = new Size(85, 459);
            contenedorMenu.Name = "contenedorMenu";
            contenedorMenu.RowCount = 4;
            contenedorMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 57.1428566F));
            contenedorMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 42.8571434F));
            contenedorMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            contenedorMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 185F));
            contenedorMenu.Size = new Size(205, 459);
            contenedorMenu.TabIndex = 0;
            contenedorMenu.MouseEnter += contenedorMenu_MouseEnter;
            contenedorMenu.MouseLeave += contenedorMenu_MouseLeave;
            // 
            // imgMenu1
            // 
            imgMenu1.Cursor = Cursors.Hand;
            imgMenu1.Image = (Image)resources.GetObject("imgMenu1.Image");
            imgMenu1.Location = new Point(3, 3);
            imgMenu1.Name = "imgMenu1";
            imgMenu1.Size = new Size(199, 85);
            imgMenu1.SizeMode = PictureBoxSizeMode.Zoom;
            imgMenu1.TabIndex = 0;
            imgMenu1.TabStop = false;
            imgMenu1.Click += imgMenu_Click;
            imgMenu1.MouseEnter += contenedorMenu_MouseEnter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(pictureBox1);
            flowLayoutPanel2.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel2.Location = new Point(3, 116);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(199, 79);
            flowLayoutPanel2.TabIndex = 9;
            flowLayoutPanel2.MouseEnter += contenedorMenu_MouseEnter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += contenedorMenu_MouseEnter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelDinero, 0, 2);
            tableLayoutPanel1.Controls.Add(labelNombre, 0, 1);
            tableLayoutPanel1.Location = new Point(85, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.Size = new Size(107, 68);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.MouseEnter += contenedorMenu_MouseEnter;
            // 
            // labelDinero
            // 
            labelDinero.AutoSize = true;
            labelDinero.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelDinero.Location = new Point(3, 33);
            labelDinero.Name = "labelDinero";
            labelDinero.Size = new Size(75, 19);
            labelDinero.TabIndex = 2;
            labelDinero.Text = "$ 1200.00";
            labelDinero.MouseEnter += contenedorMenu_MouseEnter;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.Location = new Point(3, 8);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(68, 23);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Fausto";
            labelNombre.MouseEnter += contenedorMenu_MouseEnter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(contenedorMenu);
            flowLayoutPanel1.Controls.Add(containerProductos);
            flowLayoutPanel1.Location = new Point(-3, -5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(774, 462);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // timerMenu
            // 
            timerMenu.Interval = 10;
            timerMenu.Tick += timerMenu_Tick;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(imgCerrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)imgCerrar).EndInit();
            contenedorMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgMenu1).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel containerProductos;
        private PictureBox imgCerrar;
        private TableLayoutPanel contenedorMenu;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelNombre;
        private Label labelDinero;
        private System.Windows.Forms.Timer timerMenu;
        private FlowLayoutPanel flowLayoutPanel3;
        private PictureBox imgMenu;
        private PictureBox imgMenu1;
    }
}