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
namespace GUI.StudentDialog
{
    public partial class StudentUpdate : Form
    {
        BUS_System BUSSystem = BUS_System.Instance;
        public StudentUpdate()
        {
            InitializeComponent();
        }

        private void StudentUpdate_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.getElements("STUDENT");
        }

        private void cboCourseId_Click(object sender, EventArgs e)
        {
            ComboBox com = (ComboBox)sender;
            com.DataSource = BUSSystem.getElements("COURSE");
            com.DisplayMember = "COURSENAME";
            com.ValueMember = "ID";
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.getElements("STUDENT");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                var row = dataGridView1.SelectedRows[0];
                txtId.Text = row.Cells[0].Value.ToString();
                txtCccd.Text = row.Cells[1].Value.ToString();
                txtName.Text = row.Cells[2].Value.ToString();
                dtpBirth.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                txtAddress.Text = row.Cells[4].Value.ToString();
                txtPhone.Text = row.Cells[5].Value.ToString();
                txtSchoolYear.Text = row.Cells[6].Value.ToString();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> s = new List<string>();
            s.Add(txtId.Text);
            if (BUSSystem.checkLegal(s))
            {
                if (cboCourseId.SelectedValue == null)
                {
                    MessageBox.Show("hãy chọn lớp học");
                }
                else
                {
                    DateTime date = dtpBirth.Value;
                    bool isSuccess = BUSSystem.updateStudent(txtId.Text, txtCccd.Text, txtName.Text, date.Date, txtAddress.Text,
                        txtPhone.Text, txtSchoolYear.Text, cboCourseId.SelectedValue.ToString());
                    if (isSuccess)
                    {
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("vui lòng chọn thông tin cần sửa");
            }
        }
    }
}
