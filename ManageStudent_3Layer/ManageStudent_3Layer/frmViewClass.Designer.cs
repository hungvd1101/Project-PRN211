namespace ManageStudent_3Layer
{
    partial class frmViewClass
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
            dgvViewClass = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvViewClass).BeginInit();
            SuspendLayout();
            // 
            // dgvViewClass
            // 
            dgvViewClass.AllowUserToAddRows = false;
            dgvViewClass.AllowUserToDeleteRows = false;
            dgvViewClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewClass.Location = new Point(28, 99);
            dgvViewClass.Name = "dgvViewClass";
            dgvViewClass.ReadOnly = true;
            dgvViewClass.RowHeadersWidth = 51;
            dgvViewClass.RowTemplate.Height = 29;
            dgvViewClass.Size = new Size(670, 126);
            dgvViewClass.TabIndex = 0;
            // 
            // frmViewClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 328);
            Controls.Add(dgvViewClass);
            Name = "frmViewClass";
            Text = "frmViewClass";
            Load += frmViewClass_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViewClass).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvViewClass;
    }
}