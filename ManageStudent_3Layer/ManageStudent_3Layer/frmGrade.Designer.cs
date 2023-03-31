namespace ManageStudent_3Layer
{
    partial class frmGrade
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
            lbKeyWord = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            lbSubjectName = new Label();
            cmbSubjectName = new ComboBox();
            dgvGrade = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvGrade).BeginInit();
            SuspendLayout();
            // 
            // lbKeyWord
            // 
            lbKeyWord.AutoSize = true;
            lbKeyWord.Location = new Point(43, 170);
            lbKeyWord.Name = "lbKeyWord";
            lbKeyWord.Size = new Size(69, 20);
            lbKeyWord.TabIndex = 0;
            lbKeyWord.Text = "KeyWord";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(156, 167);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(151, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(43, 227);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(213, 227);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // lbSubjectName
            // 
            lbSubjectName.AutoSize = true;
            lbSubjectName.Location = new Point(43, 112);
            lbSubjectName.Name = "lbSubjectName";
            lbSubjectName.Size = new Size(98, 20);
            lbSubjectName.TabIndex = 4;
            lbSubjectName.Text = "SubjectName";
            // 
            // cmbSubjectName
            // 
            cmbSubjectName.FormattingEnabled = true;
            cmbSubjectName.Location = new Point(156, 109);
            cmbSubjectName.Name = "cmbSubjectName";
            cmbSubjectName.Size = new Size(151, 28);
            cmbSubjectName.TabIndex = 5;
            // 
            // dgvGrade
            // 
            dgvGrade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrade.Location = new Point(365, 30);
            dgvGrade.Name = "dgvGrade";
            dgvGrade.RowHeadersWidth = 51;
            dgvGrade.RowTemplate.Height = 29;
            dgvGrade.Size = new Size(464, 386);
            dgvGrade.TabIndex = 6;
            // 
            // frmGrade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(859, 450);
            Controls.Add(dgvGrade);
            Controls.Add(cmbSubjectName);
            Controls.Add(lbSubjectName);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lbKeyWord);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmGrade";
            Text = "Grade";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvGrade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbKeyWord;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAdd;
        private Label lbSubjectName;
        private ComboBox cmbSubjectName;
        private DataGridView dgvGrade;
    }
}