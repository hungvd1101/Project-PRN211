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
    public partial class frmViewClass : Form
    {
        public frmViewClass(string TeacherId)
        {
            this.TeacherId = TeacherId;
            InitializeComponent();
        }
        private string TeacherId;

        private void LoadViewClass()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@TeacherId",
                value = TeacherId
            });

            dgvViewClass.DataSource = new Database().SelectData("ViewClass", lstPara);
        }

        private void frmViewClass_Load(object sender, EventArgs e)
        {
            LoadViewClass();
        }

    }
}
