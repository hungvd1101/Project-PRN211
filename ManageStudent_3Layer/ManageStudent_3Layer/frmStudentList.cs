using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageStudent_3Layer
{
    public partial class frmStudentList : Form
    {
        public frmStudentList()
        {
            InitializeComponent();
        }

        private string StudentName;

        private string KeyWord = "";
        private void frmStudentList_Load(object sender, EventArgs e)
        {
            LoadStudentList();
        }

        private void LoadStudentList()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@KeyWord",
                value = KeyWord
            });

            dgvStudent.DataSource = new Database().SelectData("SelectAllStudent", lstPara);

        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var StudentId = dgvStudent.Rows[e.RowIndex].Cells["StudentId"].Value.ToString();
                var StudentName = dgvStudent.Rows[e.ColumnIndex].Cells["StudentName"].Value.ToString();

                new frmStudentDetails(StudentId, StudentName).ShowDialog();
                LoadStudentList();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmStudentDetails(null, null).ShowDialog();
            LoadStudentList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            KeyWord = txtSearch.Text;
            LoadStudentList();
        }

    }
}
