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

namespace GUI.TeacherDialog
{
    public partial class TeacherUpdate : Form
    {
        BUS_System BUSSystem = BUS_System.Instance;
        public TeacherUpdate()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.RowIndex != -1) {
                var row = dataGridView1.SelectedRows[0];
                txtId.Text = row.Cells[0].Value.ToString();
                txtCccd.Text = row.Cells[1].Value.ToString();
                txtName.Text = row.Cells[2].Value.ToString();
                dtpBirth.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                txtAddress.Text = row.Cells[4].Value.ToString();
                txtPhone.Text = row.Cells[5].Value.ToString();
                txtSalary.Text = row.Cells[6].Value.ToString();
                
            }
        }

        private void TeacherUpdate_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.getElements("TEACHER");
        }

        private void cboSubjectId_Click(object sender, EventArgs e)
        {
            DataTable dt = BUSSystem.getElements("SUBJECTT");
            cboSubjectId.DataSource = dt;
            cboSubjectId.DisplayMember = "SUBJECTNAME";
            cboSubjectId.ValueMember = "ID";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> s = new List<string>();
            s.Add(txtId.Text);
            if (BUSSystem.checkLegal(s))
            {
                if (cboSubjectId.SelectedValue == null)
                {
                    MessageBox.Show("vui lòng chọn môn học");
                }
                else
                {
                    DateTime date = dtpBirth.Value;
                    bool isSuccess = BUSSystem.updateTeacher(txtId.Text, txtCccd.Text, txtName.Text, date.Date
                        , txtAddress.Text, txtPhone.Text, txtSalary.Text, cboSubjectId.SelectedValue.ToString());
                    if (isSuccess)
                    {
                        MessageBox.Show("sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("sửa thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("vui lòng chọn thông tin cần sửa");
            }
        }

        private void cboSubjectId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCccd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtpBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.getElements("TEACHER");
        }
    }
}
