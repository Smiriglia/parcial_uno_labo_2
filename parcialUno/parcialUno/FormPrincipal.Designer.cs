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
            flowLayoutPanel4 = new FlowLayoutPanel();
            contenedorVender = new FlowLayoutPanel();
            imgVender = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelVender = new Label();
            contenedorCarrito = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            contenedorAdmin = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label2 = new Label();
            contenedorSalir = new FlowLayoutPanel();
            imgSalir = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            labelSalir = new Label();
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
            flowLayoutPanel4.SuspendLayout();
            contenedorVender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgVender).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            contenedorCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            contenedorAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            contenedorSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgSalir).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgMenu1).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // containerProductos
            // 
            containerProductos.AutoScroll = true;
            containerProductos.Location = new Point(208, 3);
            containerProductos.Name = "containerProductos";
            containerProductos.Size = new Size(528, 450);
            containerProductos.TabIndex = 0;
            containerProductos.Paint += containerProductos_Paint;
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
            contenedorMenu.Controls.Add(flowLayoutPanel4, 0, 2);
            contenedorMenu.Controls.Add(imgMenu1, 0, 0);
            contenedorMenu.Controls.Add(flowLayoutPanel2, 0, 1);
            contenedorMenu.Location = new Point(0, 0);
            contenedorMenu.Margin = new Padding(0);
            contenedorMenu.MaximumSize = new Size(205, 459);
            contenedorMenu.MinimumSize = new Size(85, 459);
            contenedorMenu.Name = "contenedorMenu";
            contenedorMenu.RowCount = 3;
            contenedorMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contenedorMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            contenedorMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 259F));
            contenedorMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            contenedorMenu.Size = new Size(205, 459);
            contenedorMenu.TabIndex = 0;
            contenedorMenu.MouseEnter += contenedorMenu_MouseEnter;
            contenedorMenu.MouseLeave += contenedorMenu_MouseLeave;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(contenedorVender);
            flowLayoutPanel4.Controls.Add(contenedorCarrito);
            flowLayoutPanel4.Controls.Add(contenedorAdmin);
            flowLayoutPanel4.Controls.Add(contenedorSalir);
            flowLayoutPanel4.Location = new Point(0, 200);
            flowLayoutPanel4.Margin = new Padding(0);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(202, 259);
            flowLayoutPanel4.TabIndex = 10;
            flowLayoutPanel4.MouseEnter += contenedorMenu_MouseEnter;
            flowLayoutPanel4.MouseLeave += contenedorMenu_MouseLeave;
            // 
            // contenedorVender
            // 
            contenedorVender.BackColor = Color.Transparent;
            contenedorVender.Controls.Add(imgVender);
            contenedorVender.Controls.Add(tableLayoutPanel2);
            contenedorVender.Cursor = Cursors.Hand;
            contenedorVender.ForeColor = Color.Black;
            contenedorVender.Location = new Point(3, 0);
            contenedorVender.Margin = new Padding(3, 0, 0, 0);
            contenedorVender.Name = "contenedorVender";
            contenedorVender.Size = new Size(199, 57);
            contenedorVender.TabIndex = 0;
            contenedorVender.Click += contenedorVender_Click;
            contenedorVender.MouseEnter += contenedorVender_MouseEnter;
            contenedorVender.MouseLeave += contenedorVender_MouseLeave;
            // 
            // imgVender
            // 
            imgVender.BackColor = Color.Transparent;
            imgVender.BackgroundImageLayout = ImageLayout.None;
            imgVender.Image = (Image)resources.GetObject("imgVender.Image");
            imgVender.Location = new Point(3, 3);
            imgVender.Name = "imgVender";
            imgVender.Size = new Size(71, 48);
            imgVender.SizeMode = PictureBoxSizeMode.Zoom;
            imgVender.TabIndex = 12;
            imgVender.TabStop = false;
            imgVender.Click += contenedorVender_Click;
            imgVender.MouseEnter += contenedorVender_MouseEnter;
            imgVender.MouseLeave += contenedorVender_MouseLeave;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(labelVender, 0, 1);
            tableLayoutPanel2.Location = new Point(80, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 29.166666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70.8333359F));
            tableLayoutPanel2.Size = new Size(112, 48);
            tableLayoutPanel2.TabIndex = 13;
            tableLayoutPanel2.Click += contenedorVender_Click;
            tableLayoutPanel2.MouseEnter += contenedorVender_MouseEnter;
            tableLayoutPanel2.MouseLeave += contenedorVender_MouseLeave;
            // 
            // labelVender
            // 
            labelVender.AutoSize = true;
            labelVender.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelVender.Location = new Point(3, 14);
            labelVender.Name = "labelVender";
            labelVender.Size = new Size(54, 18);
            labelVender.TabIndex = 13;
            labelVender.Text = "Vender";
            labelVender.Click += contenedorVender_Click;
            labelVender.MouseEnter += contenedorVender_MouseEnter;
            labelVender.MouseLeave += contenedorVender_MouseLeave;
            // 
            // contenedorCarrito
            // 
            contenedorCarrito.BackColor = Color.Transparent;
            contenedorCarrito.Controls.Add(pictureBox2);
            contenedorCarrito.Controls.Add(tableLayoutPanel4);
            contenedorCarrito.Cursor = Cursors.Hand;
            contenedorCarrito.ForeColor = Color.Black;
            contenedorCarrito.Location = new Point(3, 57);
            contenedorCarrito.Margin = new Padding(3, 0, 3, 0);
            contenedorCarrito.MinimumSize = new Size(79, 57);
            contenedorCarrito.Name = "contenedorCarrito";
            contenedorCarrito.Size = new Size(198, 57);
            contenedorCarrito.TabIndex = 0;
            contenedorCarrito.Click += contenedorCarrito_Click;
            contenedorCarrito.MouseEnter += contenedorVender_MouseEnter;
            contenedorCarrito.MouseLeave += contenedorVender_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 3);
            pictureBox2.Margin = new Padding(0, 3, 3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += contenedorCarrito_Click;
            pictureBox2.MouseEnter += contenedorVender_MouseEnter;
            pictureBox2.MouseLeave += contenedorVender_MouseLeave;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label1, 0, 1);
            tableLayoutPanel4.Location = new Point(80, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 29.166666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 70.8333359F));
            tableLayoutPanel4.Size = new Size(113, 48);
            tableLayoutPanel4.TabIndex = 13;
            tableLayoutPanel4.Click += contenedorCarrito_Click;
            tableLayoutPanel4.MouseEnter += contenedorVender_MouseEnter;
            tableLayoutPanel4.MouseLeave += contenedorVender_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(54, 18);
            label1.TabIndex = 13;
            label1.Text = "Carrito";
            label1.Click += contenedorCarrito_Click;
            label1.MouseEnter += contenedorVender_MouseEnter;
            label1.MouseLeave += contenedorVender_MouseLeave;
            // 
            // contenedorAdmin
            // 
            contenedorAdmin.BackColor = Color.Transparent;
            contenedorAdmin.Controls.Add(pictureBox3);
            contenedorAdmin.Controls.Add(tableLayoutPanel5);
            contenedorAdmin.Cursor = Cursors.Hand;
            contenedorAdmin.ForeColor = Color.Black;
            contenedorAdmin.Location = new Point(3, 114);
            contenedorAdmin.Margin = new Padding(3, 0, 0, 0);
            contenedorAdmin.Name = "contenedorAdmin";
            contenedorAdmin.Size = new Size(199, 55);
            contenedorAdmin.TabIndex = 0;
            contenedorAdmin.Click += contenedorVender_Click;
            contenedorAdmin.MouseEnter += contenedorVender_MouseEnter;
            contenedorAdmin.MouseLeave += contenedorVender_MouseLeave;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(8, 3);
            pictureBox3.Margin = new Padding(8, 3, 3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.Click += contenedorVender_Click;
            pictureBox3.MouseEnter += contenedorVender_MouseEnter;
            pictureBox3.MouseLeave += contenedorVender_MouseLeave;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label2, 0, 1);
            tableLayoutPanel5.Location = new Point(80, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 29.166666F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 70.8333359F));
            tableLayoutPanel5.Size = new Size(110, 48);
            tableLayoutPanel5.TabIndex = 13;
            tableLayoutPanel5.Click += contenedorVender_Click;
            tableLayoutPanel5.MouseEnter += contenedorVender_MouseEnter;
            tableLayoutPanel5.MouseLeave += contenedorVender_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 14);
            label2.Name = "label2";
            label2.Size = new Size(91, 18);
            label2.TabIndex = 13;
            label2.Text = "Admin Menu";
            label2.Click += contenedorVender_Click;
            label2.MouseEnter += contenedorVender_MouseEnter;
            label2.MouseLeave += contenedorVender_MouseLeave;
            // 
            // contenedorSalir
            // 
            contenedorSalir.BackColor = Color.Transparent;
            contenedorSalir.Controls.Add(imgSalir);
            contenedorSalir.Controls.Add(tableLayoutPanel3);
            contenedorSalir.Cursor = Cursors.Hand;
            contenedorSalir.ForeColor = Color.Black;
            contenedorSalir.Location = new Point(3, 169);
            contenedorSalir.Margin = new Padding(3, 0, 3, 0);
            contenedorSalir.Name = "contenedorSalir";
            contenedorSalir.Size = new Size(198, 56);
            contenedorSalir.TabIndex = 0;
            contenedorSalir.Click += contenedorSalir_Click;
            contenedorSalir.MouseEnter += contenedorVender_MouseEnter;
            contenedorSalir.MouseLeave += contenedorVender_MouseLeave;
            // 
            // imgSalir
            // 
            imgSalir.BackColor = Color.Transparent;
            imgSalir.BackgroundImageLayout = ImageLayout.None;
            imgSalir.Image = (Image)resources.GetObject("imgSalir.Image");
            imgSalir.Location = new Point(13, 3);
            imgSalir.Margin = new Padding(13, 3, 3, 3);
            imgSalir.Name = "imgSalir";
            imgSalir.Size = new Size(61, 48);
            imgSalir.SizeMode = PictureBoxSizeMode.Zoom;
            imgSalir.TabIndex = 12;
            imgSalir.TabStop = false;
            imgSalir.Click += contenedorSalir_Click;
            imgSalir.MouseEnter += contenedorVender_MouseEnter;
            imgSalir.MouseLeave += contenedorMenu_MouseLeave;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(labelSalir, 0, 1);
            tableLayoutPanel3.Location = new Point(80, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 29.166666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 70.8333359F));
            tableLayoutPanel3.Size = new Size(107, 48);
            tableLayoutPanel3.TabIndex = 13;
            tableLayoutPanel3.Click += contenedorSalir_Click;
            tableLayoutPanel3.MouseEnter += contenedorVender_MouseEnter;
            tableLayoutPanel3.MouseLeave += contenedorMenu_MouseLeave;
            // 
            // labelSalir
            // 
            labelSalir.AutoSize = true;
            labelSalir.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSalir.Location = new Point(3, 14);
            labelSalir.Name = "labelSalir";
            labelSalir.Size = new Size(100, 18);
            labelSalir.TabIndex = 13;
            labelSalir.Text = "Cerrar Sesion";
            labelSalir.Click += contenedorSalir_Click;
            labelSalir.MouseEnter += contenedorVender_MouseEnter;
            labelSalir.MouseLeave += contenedorMenu_MouseLeave;
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
            flowLayoutPanel2.Controls.Add(pictureBox1);
            flowLayoutPanel2.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel2.Location = new Point(3, 103);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(199, 78);
            flowLayoutPanel2.TabIndex = 9;
            flowLayoutPanel2.MouseEnter += contenedorMenu_MouseEnter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 68);
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
            tableLayoutPanel1.Location = new Point(80, 3);
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
            flowLayoutPanel4.ResumeLayout(false);
            contenedorVender.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgVender).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            contenedorCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            contenedorAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            contenedorSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgSalir).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
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
        private PictureBox imgVender;
        private FlowLayoutPanel contenedorVender;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelVender;
        private FlowLayoutPanel contenedorSalir;
        private PictureBox imgSalir;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelSalir;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel contenedorCarrito;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private FlowLayoutPanel contenedorAdmin;
        private PictureBox pictureBox3;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label2;
    }
}