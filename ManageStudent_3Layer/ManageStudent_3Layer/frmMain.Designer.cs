namespace ManageStudent_3Layer
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            systemToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            managementToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            subjectToolStripMenuItem = new ToolStripMenuItem();
            teacherToolStripMenuItem = new ToolStripMenuItem();
            ClassToolStripMenuItem = new ToolStripMenuItem();
            viewClassToolStripMenuItem = new ToolStripMenuItem();
            pnlContent = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { systemToolStripMenuItem, managementToolStripMenuItem, viewClassToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1059, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changePasswordToolStripMenuItem, exitToolStripMenuItem });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(70, 24);
            systemToolStripMenuItem.Text = "System";
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(209, 26);
            changePasswordToolStripMenuItem.Text = "Change password";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(209, 26);
            exitToolStripMenuItem.Text = "Exit ";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // managementToolStripMenuItem
            // 
            managementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentToolStripMenuItem, subjectToolStripMenuItem, teacherToolStripMenuItem, ClassToolStripMenuItem });
            managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            managementToolStripMenuItem.Size = new Size(111, 24);
            managementToolStripMenuItem.Text = "Management";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(224, 26);
            studentToolStripMenuItem.Text = "Student";
            studentToolStripMenuItem.Click += studentToolStripMenuItem_Click;
            // 
            // subjectToolStripMenuItem
            // 
            subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            subjectToolStripMenuItem.Size = new Size(224, 26);
            subjectToolStripMenuItem.Text = "Subject";
            subjectToolStripMenuItem.Click += subjectToolStripMenuItem_Click;
            // 
            // teacherToolStripMenuItem
            // 
            teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            teacherToolStripMenuItem.Size = new Size(224, 26);
            teacherToolStripMenuItem.Text = "Teacher";
            teacherToolStripMenuItem.Click += teacherToolStripMenuItem_Click;
            // 
            // ClassToolStripMenuItem
            // 
            ClassToolStripMenuItem.Name = "ClassToolStripMenuItem";
            ClassToolStripMenuItem.Size = new Size(224, 26);
            ClassToolStripMenuItem.Text = "Class";
            ClassToolStripMenuItem.Click += ClassToolStripMenuItem_Click;
            // 
            // viewClassToolStripMenuItem
            // 
            viewClassToolStripMenuItem.Name = "viewClassToolStripMenuItem";
            viewClassToolStripMenuItem.Size = new Size(92, 24);
            viewClassToolStripMenuItem.Text = "View Class";
            viewClassToolStripMenuItem.Click += viewClassToolStripMenuItem_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 28);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1059, 422);
            pnlContent.TabIndex = 3;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1059, 450);
            Controls.Add(pnlContent);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Main Form";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem managementToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem subjectToolStripMenuItem;
        private ToolStripMenuItem teacherToolStripMenuItem;
        private ToolStripMenuItem ClassToolStripMenuItem;
        private Panel pnlContent;
        private ToolStripMenuItem viewClassToolStripMenuItem;
    }
}