namespace ManageStudent_3Layer
{
    partial class frmSubjectList
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
            lbSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            dgvSubject = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).BeginInit();
            SuspendLayout();
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(37, 74);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(53, 20);
            lbSearch.TabIndex = 1;
            lbSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(121, 71);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(37, 152);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(152, 152);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvSubject
            // 
            dgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubject.Location = new Point(307, 28);
            dgvSubject.Name = "dgvSubject";
            dgvSubject.RowHeadersWidth = 51;
            dgvSubject.RowTemplate.Height = 29;
            dgvSubject.Size = new Size(577, 296);
            dgvSubject.TabIndex = 5;
            dgvSubject.CellContentClick += dgvSubject_CellContentClick;
            // 
            // frmSubjectList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 450);
            Controls.Add(dgvSubject);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lbSearch);
            Name = "frmSubjectList";
            Text = "frmSubjectList";
            Load += frmSubjectList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAdd;
        private DataGridView dgvSubject;
    }
}