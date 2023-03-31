namespace ManageStudent_3Layer
{
    partial class frmStudentDetails
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
            lbStudentName = new Label();
            lbDOB = new Label();
            lbSex = new Label();
            lbPhoneNumber = new Label();
            lbEmail = new Label();
            txtStudentName = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            mtbDOB = new MaskedTextBox();
            rdMale = new RadioButton();
            rdFemale = new RadioButton();
            btnSave = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lbStudentName
            // 
            lbStudentName.AutoSize = true;
            lbStudentName.Location = new Point(94, 45);
            lbStudentName.Name = "lbStudentName";
            lbStudentName.Size = new Size(104, 20);
            lbStudentName.TabIndex = 0;
            lbStudentName.Text = "Student Name";
            // 
            // lbDOB
            // 
            lbDOB.AutoSize = true;
            lbDOB.Location = new Point(94, 103);
            lbDOB.Name = "lbDOB";
            lbDOB.Size = new Size(40, 20);
            lbDOB.TabIndex = 1;
            lbDOB.Text = "DOB";
            // 
            // lbSex
            // 
            lbSex.AutoSize = true;
            lbSex.Location = new Point(94, 159);
            lbSex.Name = "lbSex";
            lbSex.Size = new Size(32, 20);
            lbSex.TabIndex = 2;
            lbSex.Text = "Sex";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(94, 217);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(108, 20);
            lbPhoneNumber.TabIndex = 3;
            lbPhoneNumber.Text = "Phone Number";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(94, 285);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 4;
            lbEmail.Text = "Email";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(261, 42);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(125, 27);
            txtStudentName.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(261, 217);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(125, 27);
            txtPhoneNumber.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(261, 278);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 7;
            // 
            // mtbDOB
            // 
            mtbDOB.Location = new Point(261, 103);
            mtbDOB.Mask = "00/00/0000";
            mtbDOB.Name = "mtbDOB";
            mtbDOB.Size = new Size(125, 27);
            mtbDOB.TabIndex = 8;
            mtbDOB.ValidatingType = typeof(DateTime);
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(261, 157);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(63, 24);
            rdMale.TabIndex = 9;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(357, 157);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(78, 24);
            rdFemale.TabIndex = 10;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(194, 352);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(341, 352);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(46, 352);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmStudentDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(rdFemale);
            Controls.Add(rdMale);
            Controls.Add(mtbDOB);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtStudentName);
            Controls.Add(lbEmail);
            Controls.Add(lbPhoneNumber);
            Controls.Add(lbSex);
            Controls.Add(lbDOB);
            Controls.Add(lbStudentName);
            Name = "frmStudentDetails";
            Text = "frmStudentDetails";
            Load += frmStudentDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbStudentName;
        private Label lbDOB;
        private Label lbSex;
        private Label lbPhoneNumber;
        private Label lbEmail;
        private TextBox txtStudentName;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private MaskedTextBox mtbDOB;
        private RadioButton rdMale;
        private RadioButton rdFemale;
        private Button btnSave;
        private Button btnCancel;
        private Button btnDelete;
    }
}