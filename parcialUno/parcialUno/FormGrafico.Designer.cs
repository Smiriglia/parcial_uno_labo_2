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
            btnExportar = new Button();
            saveFileDialog1 = new SaveFileDialog();
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
            // btnExportar
            // 
            btnExportar.Cursor = Cursors.Hand;
            btnExportar.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportar.Location = new Point(499, 338);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(122, 27);
            btnExportar.TabIndex = 23;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "JSON (*.json)|*.json|CSV (*.csv)|*.csv";
            // 
            // FormGrafico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(707, 377);
            Controls.Add(btnExportar);
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
        private SaveFileDialog saveFileDialog1;
    }
}