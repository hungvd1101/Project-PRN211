namespace ManageStudent_3Layer
{
    partial class frmClassDetails
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
            lbTeacherName = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            cmbSubject = new ComboBox();
            cmbTeacher = new ComboBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lbSubjectName
            // 
            lbSubjectName.AutoSize = true;
            lbSubjectName.Location = new Point(44, 74);
            lbSubjectName.Name = "lbSubjectName";
            lbSubjectName.Size = new Size(98, 20);
            lbSubjectName.TabIndex = 0;
            lbSubjectName.Text = "SubjectName";
            // 
            // lbTeacherName
            // 
            lbTeacherName.AutoSize = true;
            lbTeacherName.Location = new Point(44, 131);
            lbTeacherName.Name = "lbTeacherName";
            lbTeacherName.Size = new Size(100, 20);
            lbTeacherName.TabIndex = 1;
            lbTeacherName.Text = "TeacherName";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(179, 204);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(323, 204);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(181, 71);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(151, 28);
            cmbSubject.TabIndex = 6;
            // 
            // cmbTeacher
            // 
            cmbTeacher.FormattingEnabled = true;
            cmbTeacher.Location = new Point(181, 128);
            cmbTeacher.Name = "cmbTeacher";
            cmbTeacher.Size = new Size(151, 28);
            cmbTeacher.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(46, 204);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmClassDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 312);
            Controls.Add(btnDelete);
            Controls.Add(cmbTeacher);
            Controls.Add(cmbSubject);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lbTeacherName);
            Controls.Add(lbSubjectName);
            Name = "frmClassDetails";
            Text = "ClassDetails";
            Load += ClassDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSubjectName;
        private Label lbTeacherName;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cmbSubject;
        private ComboBox cmbTeacher;
        private Button btnDelete;
    }
}