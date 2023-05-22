namespace parcialUno
{
    partial class FormPublicaciones
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
            label1 = new Label();
            btnRegistro = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnPendientes = new Button();
            contenedorPrincipal = new Panel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-7, -7);
            label1.Name = "label1";
            label1.Size = new Size(205, 42);
            label1.TabIndex = 0;
            label1.Text = "Publicaciones";
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.Silver;
            btnRegistro.Cursor = Cursors.Hand;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistro.Location = new Point(112, 0);
            btnRegistro.Margin = new Padding(0);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(108, 31);
            btnRegistro.TabIndex = 1;
            btnRegistro.Text = "Registro";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnPendientes);
            flowLayoutPanel1.Controls.Add(btnRegistro);
            flowLayoutPanel1.Location = new Point(244, 1);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 33);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnPendientes
            // 
            btnPendientes.BackColor = Color.Silver;
            btnPendientes.Cursor = Cursors.Hand;
            btnPendientes.FlatStyle = FlatStyle.Flat;
            btnPendientes.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPendientes.Location = new Point(0, 0);
            btnPendientes.Margin = new Padding(0);
            btnPendientes.Name = "btnPendientes";
            btnPendientes.Size = new Size(112, 31);
            btnPendientes.TabIndex = 1;
            btnPendientes.Text = "Revision";
            btnPendientes.UseVisualStyleBackColor = false;
            btnPendientes.Click += btnPendientes_Click;
            // 
            // contenedorPrincipal
            // 
            contenedorPrincipal.Location = new Point(0, 35);
            contenedorPrincipal.Name = "contenedorPrincipal";
            contenedorPrincipal.Size = new Size(708, 342);
            contenedorPrincipal.TabIndex = 14;
            // 
            // FormPublicaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(707, 377);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(contenedorPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPublicaciones";
            Text = "FormPublicaciones";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegistro;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnPendientes;
        private Panel contenedorPrincipal;
    }
}