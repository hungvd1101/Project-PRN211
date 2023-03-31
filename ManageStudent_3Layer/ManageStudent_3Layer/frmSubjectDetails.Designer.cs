namespace ManageStudent_3Layer
{
    partial class frmSubjectDetails
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
            lbSubjectName = new Label();
            txtSubjectName = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lbSubjectName
            // 
            lbSubjectName.AutoSize = true;
            lbSubjectName.Location = new Point(17, 34);
            lbSubjectName.Name = "lbSubjectName";
            lbSubjectName.Size = new Size(98, 20);
            lbSubjectName.TabIndex = 0;
            lbSubjectName.Text = "SubjectName";
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(136, 31);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(173, 27);
            txtSubjectName.TabIndex = 1;
            txtSubjectName.TextChanged += textBox1_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(329, 30);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(448, 31);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(560, 31);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmSubjectDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 104);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtSubjectName);
            Controls.Add(lbSubjectName);
            Name = "frmSubjectDetails";
            Text = "frmSubjectDetails";
            Load += frmSubjectDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSubjectName;
        private TextBox txtSubjectName;
        private Button btnSave;
        private Button btnCancel;
        private Button btnDelete;
    }
}