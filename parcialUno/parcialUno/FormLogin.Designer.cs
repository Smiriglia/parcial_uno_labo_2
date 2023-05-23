namespace parcialUno
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnOcultar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            labelRegistrate = new Label();
            labelLimpiar = new Label();
            panel2 = new Panel();
            checkBoxGuardar = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Black;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderColor = Color.Black;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(26, 348);
            btnIngresar.Margin = new Padding(4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(236, 40);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Log In";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Location = new Point(54, 192);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(208, 24);
            txtUsuario.TabIndex = 1;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(54, 261);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(208, 24);
            txtPassword.TabIndex = 2;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // btnOcultar
            // 
            btnOcultar.BackColor = Color.Transparent;
            btnOcultar.BackgroundImage = Properties.Resources.mostrar_contrasenia;
            btnOcultar.BackgroundImageLayout = ImageLayout.Zoom;
            btnOcultar.Cursor = Cursors.Hand;
            btnOcultar.FlatAppearance.BorderSize = 0;
            btnOcultar.FlatStyle = FlatStyle.Flat;
            btnOcultar.Location = new Point(231, 264);
            btnOcultar.Margin = new Padding(4);
            btnOcultar.Name = "btnOcultar";
            btnOcultar.Size = new Size(32, 18);
            btnOcultar.TabIndex = 5;
            btnOcultar.UseVisualStyleBackColor = false;
            btnOcultar.Click += btnOcultar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(286, 4);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(-22, -18);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(214, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user_icon;
            pictureBox3.Location = new Point(26, 190);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(26, 285);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 9;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.private_lock_icon;
            pictureBox4.Location = new Point(26, 259);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(59, 117);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(164, 42);
            label3.TabIndex = 10;
            label3.Text = "INGRESO";
            // 
            // labelRegistrate
            // 
            labelRegistrate.AutoSize = true;
            labelRegistrate.Cursor = Cursors.Hand;
            labelRegistrate.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelRegistrate.ForeColor = Color.FromArgb(64, 64, 64);
            labelRegistrate.Location = new Point(96, 391);
            labelRegistrate.Margin = new Padding(4, 0, 4, 0);
            labelRegistrate.Name = "labelRegistrate";
            labelRegistrate.Size = new Size(97, 23);
            labelRegistrate.TabIndex = 11;
            labelRegistrate.Text = "Registrate";
            labelRegistrate.Click += labelRegistrate_Click;
            // 
            // labelLimpiar
            // 
            labelLimpiar.AutoSize = true;
            labelLimpiar.Cursor = Cursors.Hand;
            labelLimpiar.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelLimpiar.ForeColor = Color.FromArgb(64, 64, 64);
            labelLimpiar.Location = new Point(168, 294);
            labelLimpiar.Margin = new Padding(4, 0, 4, 0);
            labelLimpiar.Name = "labelLimpiar";
            labelLimpiar.Size = new Size(94, 14);
            labelLimpiar.TabIndex = 11;
            labelLimpiar.Text = "Limpiar Campos";
            labelLimpiar.Click += labelLimpiar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(26, 216);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            panel2.TabIndex = 9;
            // 
            // checkBoxGuardar
            // 
            checkBoxGuardar.AutoSize = true;
            checkBoxGuardar.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxGuardar.Location = new Point(26, 294);
            checkBoxGuardar.Name = "checkBoxGuardar";
            checkBoxGuardar.Size = new Size(99, 17);
            checkBoxGuardar.TabIndex = 12;
            checkBoxGuardar.Text = "Guardar Datos";
            checkBoxGuardar.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(308, 486);
            Controls.Add(labelLimpiar);
            Controls.Add(labelRegistrate);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnOcultar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(checkBoxGuardar);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnOcultar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Label label3;
        private Label labelRegistrate;
        private Label labelLimpiar;
        private Panel panel2;
        private CheckBox checkBoxGuardar;
    }
}