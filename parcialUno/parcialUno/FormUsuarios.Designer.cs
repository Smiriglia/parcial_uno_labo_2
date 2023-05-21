namespace parcialUno
{
    partial class FormUsuarios
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
            dgUsuarios = new DataGridView();
            txtUsername = new TextBox();
            labelId = new Label();
            txtPassword = new TextBox();
            txtDinero = new TextBox();
            txtNombre = new TextBox();
            txtSector = new TextBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            buttonAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(4, 19);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(124, 45);
            label1.TabIndex = 0;
            label1.Text = "Usuarios";
            // 
            // dgUsuarios
            // 
            dgUsuarios.AllowUserToAddRows = false;
            dgUsuarios.AllowUserToResizeColumns = false;
            dgUsuarios.AllowUserToResizeRows = false;
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuarios.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgUsuarios.Location = new Point(12, 67);
            dgUsuarios.MultiSelect = false;
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.ReadOnly = true;
            dgUsuarios.RowTemplate.Height = 25;
            dgUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsuarios.Size = new Size(683, 224);
            dgUsuarios.TabIndex = 1;
            dgUsuarios.CellClick += dgUsuarios_CellClick;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(170, 297);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 2;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelId.Location = new Point(147, 299);
            labelId.Margin = new Padding(3, 5, 3, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(17, 19);
            labelId.TabIndex = 3;
            labelId.Text = "-";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(276, 297);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtDinero
            // 
            txtDinero.Location = new Point(382, 297);
            txtDinero.Name = "txtDinero";
            txtDinero.PlaceholderText = "Dinero";
            txtDinero.Size = new Size(100, 23);
            txtDinero.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(488, 297);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtSector
            // 
            txtSector.Location = new Point(594, 297);
            txtSector.Name = "txtSector";
            txtSector.PlaceholderText = "Sector";
            txtSector.Size = new Size(100, 23);
            txtSector.TabIndex = 2;
            // 
            // btnModificar
            // 
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(536, 326);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 27);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(455, 326);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 27);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Cursor = Cursors.Hand;
            buttonAgregar.FlatStyle = FlatStyle.Flat;
            buttonAgregar.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregar.Location = new Point(617, 326);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(77, 27);
            buttonAgregar.TabIndex = 4;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(707, 377);
            Controls.Add(btnEliminar);
            Controls.Add(buttonAgregar);
            Controls.Add(btnModificar);
            Controls.Add(labelId);
            Controls.Add(txtUsername);
            Controls.Add(dgUsuarios);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtDinero);
            Controls.Add(txtNombre);
            Controls.Add(txtSector);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            Load += FormUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgUsuarios;
        private TextBox txtUsername;
        private Label labelId;
        private TextBox txtPassword;
        private TextBox txtDinero;
        private TextBox txtNombre;
        private TextBox txtSector;
        private Button btnModificar;
        private Button btnEliminar;
        private Button buttonAgregar;
    }
}