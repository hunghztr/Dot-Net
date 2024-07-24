using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class SubjectForm : Form
    {
        BUS_System BUSSystem = BUS_System.Instance;
        
        public SubjectForm()
        {
            InitializeComponent();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.getElements("SUBJECTT");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("bạn có chắc muốn thoát","thông báo",MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            string result = "";
            if(rbtnAZ.Checked)
            {
                result += rbtnAZ.Text;
            }
            if(rbtnZA.Checked)
            {
                result += rbtnZA.Text;
            }
            DataTable dt = BUSSystem.sort(result,"SUBJECTT","SUBJECTNAME");
            dataGridView1.DataSource =dt;
        }
    }
}
