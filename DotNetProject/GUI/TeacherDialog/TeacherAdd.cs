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
using DTO;
namespace GUI.TeacherDialog
{
    public partial class TeacherAdd : Form
    {
        BUS_System BUSSystem = BUS_System.Instance;
        
        public TeacherAdd()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TeacherAdd_Load(object sender, EventArgs e)
        {

            DataTable dt = BUSSystem.getElements("TEACHER");
            Person.setId(dt.Rows.Count);
            string curId = Person.getId();
            txtId.Text = curId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> s = new List<string>();
            
            s.Add(txtCccd.Text);
            s.Add(txtName.Text);
            s.Add(txtAddress.Text);
            s.Add(txtPhone.Text);
            s.Add(txtSalary.Text);
            if (BUSSystem.checkLegal(s))
            {
                if (cboSubjectId.SelectedValue == null)
                {
                    MessageBox.Show("vui lòng chọn môn học");
                }
                else
                {
                    DateTime date = dtpBirth.Value;
                    bool isSuccess = BUSSystem.addTeacher(txtId.Text, txtCccd.Text, txtName.Text, date.Date
                        , txtAddress.Text, txtPhone.Text, txtSalary.Text, cboSubjectId.SelectedValue.ToString());
                    if (isSuccess)
                    {
                        MessageBox.Show("thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("thêm thất bại");
                    }
                    clear();
                }
            }
            else
            {
                MessageBox.Show("vui lòng nhập đủ thông tin");
            }
            
        }

        private void cboSubjectId_Click(object sender, EventArgs e)
        {
            ComboBox com = (ComboBox) sender;
            DataTable dt = BUSSystem.getElements("SUBJECTT");
            com.DataSource = dt;
            com.ValueMember = "ID";
            com.DisplayMember = "SUBJECTNAME";        
        }

        private void cboSubjectId_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            DataTable dt = BUSSystem.getElements("TEACHER");
            Person.setId(dt.Rows.Count);
            txtId.Text = Person.getId();
            txtCccd.Text = "";
            txtName.Text = "";
            dtpBirth.Value = DateTime.Now;
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtSalary.Text = "";
        }
        private void btbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
    }
}
