namespace ManageStudent_3Layer
{
    partial class frmTeacherList
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
            dgvTeacher = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).BeginInit();
            SuspendLayout();
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(25, 106);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(53, 20);
            lbSearch.TabIndex = 0;
            lbSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(114, 103);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(25, 181);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(145, 181);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvTeacher
            // 
            dgvTeacher.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeacher.Location = new Point(287, 30);
            dgvTeacher.Name = "dgvTeacher";
            dgvTeacher.RowHeadersWidth = 51;
            dgvTeacher.RowTemplate.Height = 29;
            dgvTeacher.Size = new Size(814, 373);
            dgvTeacher.TabIndex = 4;
            dgvTeacher.CellContentClick += dgvTeacher_CellContentClick;
            // 
            // frmTeacherList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 450);
            Controls.Add(dgvTeacher);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lbSearch);
            Name = "frmTeacherList";
            Text = "frmTeacherList";
            Load += frmTeacherList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAdd;
        private DataGridView dgvTeacher;
    }
}