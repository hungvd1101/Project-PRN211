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
    public partial class frmTeacherList : Form
    {
        public frmTeacherList()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            KeyWord = txtSearch.Text;
            LoadTeacherList();
        }
        private string KeyWord = "";
        private void LoadTeacherList()
        {
            string sql = "SelectAllTeacher";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "KeyWord",
                value = KeyWord
            });
            dgvTeacher.DataSource = new Database().SelectData(sql, lstPara);
        }

        private void frmTeacherList_Load(object sender, EventArgs e)
        {
            LoadTeacherList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmTeacherDetails(null).ShowDialog();
            LoadTeacherList();
        }

        private void dgvTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var TeacherId = dgvTeacher.Rows[e.RowIndex].Cells["TeacherId"].Value.ToString();
                new frmTeacherDetails(TeacherId).ShowDialog();
                LoadTeacherList();
            }
        }
    }
}
