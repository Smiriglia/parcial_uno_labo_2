namespace parcialUno
{
    partial class FormLog
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
            dgLog = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgLog).BeginInit();
            SuspendLayout();
            // 
            // dgLog
            // 
            dgLog.AllowUserToAddRows = false;
            dgLog.AllowUserToResizeColumns = false;
            dgLog.AllowUserToResizeRows = false;
            dgLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLog.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgLog.Location = new Point(12, 52);
            dgLog.MultiSelect = false;
            dgLog.Name = "dgLog";
            dgLog.ReadOnly = true;
            dgLog.RowTemplate.Height = 25;
            dgLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLog.Size = new Size(683, 313);
            dgLog.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 4);
            label2.Name = "label2";
            label2.Size = new Size(63, 45);
            label2.TabIndex = 3;
            label2.Text = "Log";
            // 
            // FormLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(707, 377);
            Controls.Add(dgLog);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLog";
            Text = "FormLog";
            Load += FormLog_Load;
            ((System.ComponentModel.ISupportInitialize)dgLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgLog;
        private Label label2;
    }
}