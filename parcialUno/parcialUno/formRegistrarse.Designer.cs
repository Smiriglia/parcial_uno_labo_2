namespace parcialUno
{
    partial class FormRegistrarse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarse));
            btnRegistrar = new Button();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnOcultar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            labelLoguearse = new Label();
            labelLimpiar = new Label();
            panel2 = new Panel();
            txtPassword2 = new TextBox();
            btnOcultar2 = new Button();
            pictureBox5 = new PictureBox();
            panel3 = new Panel();
            txtNombre = new TextBox();
            pictureBox6 = new PictureBox();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Black;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderColor = Color.Black;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(27, 330);
            btnRegistrar.Margin = new Padding(4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(236, 40);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrarse";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Location = new Point(55, 148);
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
            txtPassword.Location = new Point(55, 227);
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
            btnOcultar.Location = new Point(232, 230);
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
            pictureBox3.Location = new Point(27, 146);
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
            panel1.Location = new Point(27, 251);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 9;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.private_lock_icon1;
            pictureBox4.Location = new Point(27, 225);
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
            label3.Location = new Point(56, 89);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(180, 42);
            label3.TabIndex = 10;
            label3.Text = "REGISTRO";
            // 
            // labelLoguearse
            // 
            labelLoguearse.AutoSize = true;
            labelLoguearse.Cursor = Cursors.Hand;
            labelLoguearse.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelLoguearse.ForeColor = Color.FromArgb(64, 64, 64);
            labelLoguearse.Location = new Point(112, 374);
            labelLoguearse.Margin = new Padding(4, 0, 4, 0);
            labelLoguearse.Name = "labelLoguearse";
            labelLoguearse.Size = new Size(62, 23);
            labelLoguearse.TabIndex = 11;
            labelLoguearse.Text = "Log In";
            labelLoguearse.Click += labelLoguearse_Click;
            // 
            // labelLimpiar
            // 
            labelLimpiar.AutoSize = true;
            labelLimpiar.Cursor = Cursors.Hand;
            labelLimpiar.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelLimpiar.ForeColor = Color.FromArgb(64, 64, 64);
            labelLimpiar.Location = new Point(136, 298);
            labelLimpiar.Margin = new Padding(4, 0, 4, 0);
            labelLimpiar.Name = "labelLimpiar";
            labelLimpiar.Size = new Size(128, 19);
            labelLimpiar.TabIndex = 11;
            labelLimpiar.Text = "Limpiar Campos";
            labelLimpiar.Click += labelLimpiar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(27, 172);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            panel2.TabIndex = 9;
            // 
            // txtPassword2
            // 
            txtPassword2.BorderStyle = BorderStyle.None;
            txtPassword2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword2.Location = new Point(55, 262);
            txtPassword2.Margin = new Padding(4);
            txtPassword2.Multiline = true;
            txtPassword2.Name = "txtPassword2";
            txtPassword2.PasswordChar = '•';
            txtPassword2.Size = new Size(208, 24);
            txtPassword2.TabIndex = 2;
            txtPassword2.KeyPress += txtPassword_KeyPress;
            // 
            // btnOcultar2
            // 
            btnOcultar2.BackColor = Color.Transparent;
            btnOcultar2.BackgroundImage = Properties.Resources.mostrar_contrasenia;
            btnOcultar2.BackgroundImageLayout = ImageLayout.Zoom;
            btnOcultar2.Cursor = Cursors.Hand;
            btnOcultar2.FlatAppearance.BorderSize = 0;
            btnOcultar2.FlatStyle = FlatStyle.Flat;
            btnOcultar2.Location = new Point(232, 265);
            btnOcultar2.Margin = new Padding(4);
            btnOcultar2.Name = "btnOcultar2";
            btnOcultar2.Size = new Size(32, 18);
            btnOcultar2.TabIndex = 5;
            btnOcultar2.UseVisualStyleBackColor = false;
            btnOcultar2.Click += btnOcultar_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.private_lock_icon;
            pictureBox5.Location = new Point(27, 260);
            pictureBox5.Margin = new Padding(4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(27, 286);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 1);
            panel3.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(55, 181);
            txtNombre.Margin = new Padding(4);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(208, 24);
            txtNombre.TabIndex = 1;
            txtNombre.KeyPress += txtUsuario_KeyPress;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.nombre_icon;
            pictureBox6.Location = new Point(27, 179);
            pictureBox6.Margin = new Padding(4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(25, 25);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(27, 205);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(236, 1);
            panel4.TabIndex = 9;
            // 
            // FormRegistrarse
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(308, 432);
            Controls.Add(labelLimpiar);
            Controls.Add(labelLoguearse);
            Controls.Add(label3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnOcultar2);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword2);
            Controls.Add(btnOcultar);
            Controls.Add(txtNombre);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(btnRegistrar);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormRegistrarse";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnOcultar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Label label3;
        private Label labelLoguearse;
        private Label labelLimpiar;
        private Panel panel2;
        private TextBox txtPassword2;
        private Button btnOcultar2;
        private PictureBox pictureBox5;
        private Panel panel3;
        private TextBox txtNombre;
        private PictureBox pictureBox6;
        private Panel panel4;
    }
}