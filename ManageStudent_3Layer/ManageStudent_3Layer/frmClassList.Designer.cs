namespace ManageStudent_3Layer
{
    partial class frmClassList
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
            dgvClass = new DataGridView();
            lbKeyWord = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClass).BeginInit();
            SuspendLayout();
            // 
            // dgvClass
            // 
            dgvClass.AllowUserToAddRows = false;
            dgvClass.AllowUserToDeleteRows = false;
            dgvClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClass.Location = new Point(305, 30);
            dgvClass.Name = "dgvClass";
            dgvClass.ReadOnly = true;
            dgvClass.RowHeadersWidth = 51;
            dgvClass.RowTemplate.Height = 29;
            dgvClass.Size = new Size(624, 390);
            dgvClass.TabIndex = 0;
            dgvClass.CellContentClick += dgvClass_CellContentClick;
            // 
            // lbKeyWord
            // 
            lbKeyWord.AutoSize = true;
            lbKeyWord.Location = new Point(40, 74);
            lbKeyWord.Name = "lbKeyWord";
            lbKeyWord.Size = new Size(69, 20);
            lbKeyWord.TabIndex = 1;
            lbKeyWord.Text = "KeyWord";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(129, 71);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(40, 150);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(160, 150);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmClassList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 450);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lbKeyWord);
            Controls.Add(dgvClass);
            Name = "frmClassList";
            Text = "frmClassList";
            Load += frmClassList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClass;
        private Label lbKeyWord;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAdd;
    }
}