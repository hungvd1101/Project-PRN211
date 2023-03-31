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
    public partial class frmClassList : Form
    {
        public frmClassList()
        {
            InitializeComponent();
        }

        private void frmClassList_Load(object sender, EventArgs e)
        {
            LoaddClassList();
        }
        private string KeyWord = "";
        private void LoaddClassList()
        {
            string sql = "AllClass";
            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@KeyWord",
                    value = KeyWord
                }
            };
            dgvClass.DataSource = new Database().SelectData(sql, lstPara);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            KeyWord = txtSearch.Text;
            LoaddClassList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmClassDetails(null).ShowDialog();
            LoaddClassList();
        }

        private void dgvClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) 
            {
                new frmClassDetails(dgvClass.Rows[e.RowIndex].Cells["ClassId"].Value.ToString()).ShowDialog();
                LoaddClassList();

            }
        }
    }
}
