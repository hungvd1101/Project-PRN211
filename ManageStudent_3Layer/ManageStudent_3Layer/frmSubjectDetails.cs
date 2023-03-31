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
    public partial class frmSubjectDetails : Form
    {
        public frmSubjectDetails(string SubjectId)
        {
            this.SubjectId = SubjectId;
            InitializeComponent();
        }

        private string SubjectId;
        private string executor = "admin";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSubjectDetails_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SubjectId))
            {
                this.Text = "Add new Subject";
                btnDelete.Enabled = false;
            }
            else
            {
                this.Text = "Update Subject";
                var r = new Database().Select("exec SelectSubject'" + SubjectId + "'");
                txtSubjectName.Text = r["SubjectName"].ToString();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(SubjectId))
            {
                sql = "InsertSubject";
                lstPara.Add(new CustomParameter()
                {
                    key = "@Creator",
                    value = executor

                });
            }
            else
            {
                sql = "UpdateSubject";
                lstPara.Add(new CustomParameter()
                {
                    key = "@SubjectId",
                    value = SubjectId

                });

            }
            lstPara.Add(new CustomParameter()
            {
                key = "SubjectName",
                value = txtSubjectName.Text

            });
            var rs = new Database().Execute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(SubjectId))
                {
                    MessageBox.Show("Add new Subject successfully");
                }
                else
                {
                    MessageBox.Show("Update Subject successfully");

                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Implement fail");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var r = new Database().Select("SelectTeacher '" + SubjectId + "'");
            string sql = "";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            sql = "DeleteSubject";
            lstPara.Add(new CustomParameter()
            {
                key = "@SubjectId",
                value = SubjectId,

            });
            var rs = new Database().Execute(sql, lstPara);
            if (rs == 1)
            {
                MessageBox.Show("Delete Subject successfully");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Implement fail");
            }
        }
    }

}
