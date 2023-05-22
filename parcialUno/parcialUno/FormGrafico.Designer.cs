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
            // FormGrafico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(707, 377);
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
    }
}