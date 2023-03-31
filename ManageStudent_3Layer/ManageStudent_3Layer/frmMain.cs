namespace ManageStudent_3Layer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private string Account;
        private string AccountType;
        private void frmMain_Load(object sender, EventArgs e)
        {
            var fn = new frmLogin();
            fn.ShowDialog(); // load lai form login 

            // sau khi frmlogin close, lay tk va mk
            Account = fn.UserName;
            AccountType = fn.AccountType;

            if (AccountType.Equals("Admin"))
            {
                
                viewClassToolStripMenuItem.Visible = false;
            }
            else
            {             
                managementToolStripMenuItem.Visible = false;
            }

            frmWelcome f = new frmWelcome();
            AddForm(f);

        }

        private void AddForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            f.FormBorderStyle = FormBorderStyle.None;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to Log Out this account?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //this.Hide();
                //frmLogin f = new frmLogin();
                //f.ShowDialog();
                Close();
            }
        }
        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubjectList f = new frmSubjectList();
            AddForm(f);
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherList f = new frmTeacherList();
            AddForm(f);
        }

        private void ClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClassList f = new frmClassList();
            AddForm(f);
        }


        private void viewClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmViewClass(Account);
            AddForm(f);
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmStudentList();
            AddForm(f);
        }
    }
}