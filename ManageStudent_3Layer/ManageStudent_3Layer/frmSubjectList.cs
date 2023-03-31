using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageStudent_3Layer
{
    public partial class frmSubjectList : Form
    {
        public frmSubjectList()
        {
            InitializeComponent();
        }




        private string KeyWord = "";
        private void LoadSubjectList()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@KeyWord",
                value = KeyWord
            });
            dgvSubject.DataSource = new Database().SelectData("SelectAllSubject", lstPara);

        }



        private void frmSubjectList_Load(object sender, EventArgs e)
        {
            LoadSubjectList();
        }

        private void dgvSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var SubjectId = dgvSubject.Rows[e.RowIndex].Cells["SubjectId"].Value.ToString();
                new frmSubjectDetails(SubjectId).ShowDialog();
                LoadSubjectList();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            KeyWord = txtSearch.Text;
            LoadSubjectList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmSubjectDetails(null).ShowDialog();
            LoadSubjectList();
        }
    }
}
