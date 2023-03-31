namespace ManageStudent_3Layer
{
    partial class frmTeacherDetails
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
            lbTeacherName = new Label();
            lbSex = new Label();
            lbDOB = new Label();
            lbPhoneNumber = new Label();
            lbEmail = new Label();
            txtTeacherName = new TextBox();
            rdMale = new RadioButton();
            rdFemale = new RadioButton();
            mtbDOB = new MaskedTextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lbTeacherName
            // 
            lbTeacherName.AutoSize = true;
            lbTeacherName.Location = new Point(79, 56);
            lbTeacherName.Name = "lbTeacherName";
            lbTeacherName.Size = new Size(104, 20);
            lbTeacherName.TabIndex = 0;
            lbTeacherName.Text = "Teacher Name";
            // 
            // lbSex
            // 
            lbSex.AutoSize = true;
            lbSex.Location = new Point(79, 106);
            lbSex.Name = "lbSex";
            lbSex.Size = new Size(32, 20);
            lbSex.TabIndex = 1;
            lbSex.Text = "Sex";
            // 
            // lbDOB
            // 
            lbDOB.AutoSize = true;
            lbDOB.Location = new Point(79, 158);
            lbDOB.Name = "lbDOB";
            lbDOB.Size = new Size(40, 20);
            lbDOB.TabIndex = 2;
            lbDOB.Text = "DOB";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(86, 209);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(108, 20);
            lbPhoneNumber.TabIndex = 3;
            lbPhoneNumber.Text = "Phone Number";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(84, 266);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 4;
            lbEmail.Text = "Email";
            // 
            // txtTeacherName
            // 
            txtTeacherName.Location = new Point(246, 58);
            txtTeacherName.Name = "txtTeacherName";
            txtTeacherName.Size = new Size(125, 27);
            txtTeacherName.TabIndex = 5;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(214, 108);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(63, 24);
            rdMale.TabIndex = 6;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(371, 106);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(78, 24);
            rdFemale.TabIndex = 7;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // mtbDOB
            // 
            mtbDOB.Location = new Point(246, 151);
            mtbDOB.Mask = "00/00/0000";
            mtbDOB.Name = "mtbDOB";
            mtbDOB.Size = new Size(125, 27);
            mtbDOB.TabIndex = 8;
            mtbDOB.ValidatingType = typeof(DateTime);
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(246, 209);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(125, 27);
            txtPhoneNumber.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(246, 266);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(214, 343);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(355, 343);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(64, 343);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmTeacherDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(mtbDOB);
            Controls.Add(rdFemale);
            Controls.Add(rdMale);
            Controls.Add(txtTeacherName);
            Controls.Add(lbEmail);
            Controls.Add(lbPhoneNumber);
            Controls.Add(lbDOB);
            Controls.Add(lbSex);
            Controls.Add(lbTeacherName);
            Name = "frmTeacherDetails";
            Text = "frmTeacherDetails";
            Load += frmTeacherDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTeacherName;
        private Label lbSex;
        private Label lbDOB;
        private Label lbPhoneNumber;
        private Label lbEmail;
        private TextBox txtTeacherName;
        private RadioButton rdMale;
        private RadioButton rdFemale;
        private MaskedTextBox mtbDOB;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private Button btnSave;
        private Button btnCancel;
        private Button btnDelete;
    }
}