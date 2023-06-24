namespace parcialUno
{
    partial class FormGrafico
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
            label2 = new Label();
            comboBoxExtension = new ComboBox();
            btnExportar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(227, 9);
            label2.Name = "label2";
            label2.Size = new Size(228, 29);
            label2.TabIndex = 0;
            label2.Text = "Ventas por producto";
            // 
            // comboBoxExtension
            // 
            comboBoxExtension.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxExtension.FormattingEnabled = true;
            comboBoxExtension.Items.AddRange(new object[] { "json", "csv" });
            comboBoxExtension.Location = new Point(382, 343);
            comboBoxExtension.Name = "comboBoxExtension";
            comboBoxExtension.Size = new Size(121, 23);
            comboBoxExtension.TabIndex = 1;
            comboBoxExtension.SelectedIndex = 0;
            // 
            // btnExportar
            // 
            btnExportar.Cursor = Cursors.Hand;
            btnExportar.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportar.Location = new Point(509, 340);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(122, 27);
            btnExportar.TabIndex = 23;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(331, 345);
            label1.Name = "label1";
            label1.Size = new Size(48, 18);
            label1.TabIndex = 24;
            label1.Text = "formato";
            // 
            // FormGrafico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(707, 377);
            Controls.Add(label1);
            Controls.Add(btnExportar);
            Controls.Add(comboBoxExtension);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGrafico";
            Text = "FormDashboard";
            Load += FormGrafico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox comboBoxExtension;
        private Button btnExportar;
        private Label label1;
    }
}