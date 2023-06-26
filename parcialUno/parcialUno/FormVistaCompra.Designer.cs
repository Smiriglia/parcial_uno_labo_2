namespace parcialUno
{
    partial class FormVistaCompra
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            labelNombre = new Label();
            labelPrecio = new Label();
            labelEstado = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelNombre);
            flowLayoutPanel1.Controls.Add(labelPrecio);
            flowLayoutPanel1.Controls.Add(labelEstado);
            flowLayoutPanel1.Location = new Point(2, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(574, 29);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.Location = new Point(0, 3);
            labelNombre.Margin = new Padding(0, 3, 3, 3);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(96, 18);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Samsung S21";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrecio.Location = new Point(102, 3);
            labelPrecio.Margin = new Padding(3);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(50, 18);
            labelPrecio.TabIndex = 2;
            labelPrecio.Text = "$ 1950";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelEstado.Location = new Point(158, 3);
            labelEstado.Margin = new Padding(3);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(73, 18);
            labelEstado.TabIndex = 2;
            labelEstado.Text = "Pendiente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 330);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 23);
            textBox1.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(415, 330);
            button1.Name = "button1";
            button1.Size = new Size(68, 23);
            button1.TabIndex = 16;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(100, 35);
            label1.Name = "label1";
            label1.Size = new Size(142, 19);
            label1.TabIndex = 17;
            label1.Text = "Chat con El vendedor";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Location = new Point(100, 57);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(383, 267);
            flowLayoutPanel2.TabIndex = 18;
            // 
            // FormVistaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(576, 411);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVistaCompra";
            Text = "FormVistaCompra";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelNombre;
        private Label labelPrecio;
        private Label labelEstado;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}