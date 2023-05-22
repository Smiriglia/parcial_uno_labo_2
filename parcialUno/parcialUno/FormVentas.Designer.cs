namespace parcialUno
{
    partial class FormVentas
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
            dgVentas = new DataGridView();
            btnEntregar = new Button();
            labelId = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgVentas).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 45);
            label1.TabIndex = 0;
            label1.Text = "Ventas";
            // 
            // dgVentas
            // 
            dgVentas.AllowUserToAddRows = false;
            dgVentas.AllowUserToResizeColumns = false;
            dgVentas.AllowUserToResizeRows = false;
            dgVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVentas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgVentas.Location = new Point(12, 57);
            dgVentas.MultiSelect = false;
            dgVentas.Name = "dgVentas";
            dgVentas.ReadOnly = true;
            dgVentas.RowTemplate.Height = 25;
            dgVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgVentas.Size = new Size(683, 224);
            dgVentas.TabIndex = 2;
            dgVentas.CellClick += dgVentas_CellClick;
            // 
            // btnEntregar
            // 
            btnEntregar.Cursor = Cursors.Hand;
            btnEntregar.FlatStyle = FlatStyle.Flat;
            btnEntregar.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntregar.Location = new Point(590, 287);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(105, 38);
            btnEntregar.TabIndex = 5;
            btnEntregar.Text = "Entregar";
            btnEntregar.UseVisualStyleBackColor = true;
            btnEntregar.Click += btnEntregar_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(237, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(104, 15);
            labelId.TabIndex = 6;
            labelId.Text = "Id Seleccionado:  -";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelId);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(240, 296);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(344, 28);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(707, 377);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnEntregar);
            Controls.Add(dgVentas);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVentas";
            Text = "FormVentas";
            Load += FormVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgVentas).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgVentas;
        private Button btnEntregar;
        private Label labelId;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}