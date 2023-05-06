namespace parcialUno
{
    partial class Form1
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
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(78, 134);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 54);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(238, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 105);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(238, 23);
            txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 33);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
    }
}