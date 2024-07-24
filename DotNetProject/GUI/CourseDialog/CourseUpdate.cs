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
namespace GUI.CourseDialog
{
    public partial class CourseUpdate : Form
    {
        BUS_System BUSSystem = BUS_System.Instance;
        public CourseUpdate()
        {
            InitializeComponent();
        }

        private void CourseUpdate_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.getElements("COURSE");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> s = new List<string>();
            s.Add(txtId.Text);
            if (BUSSystem.checkLegal(s))
            {
                if (cboTeacherId.SelectedValue == null)
                {
                    MessageBox.Show("vui lòng chọn giáo viên chủ nhiệm");
                }
                else
                {
                    bool isSuccess = BUSSystem.updateCourse(txtId.Text, txtName.Text, cboTeacherId.SelectedValue.ToString());
                    if (isSuccess)
                    {
                        MessageBox.Show("cập nhật thành công");
                    }
                    else
                    {
                        MessageBox.Show("cập nhật thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("vui lòng chọn thông tin cần sửa");
            }
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
                txtName.Text = row.Cells[1].Value.ToString();
                
            }
        }

        private void cboTeacherId_Click(object sender, EventArgs e)
        {
            ComboBox com = (ComboBox)sender;
            com.DataSource = BUSSystem.getElements("TEACHER");
            com.DisplayMember = "FULLNAME";
            com.ValueMember = "ID";
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.getElements("COURSE");
        }
    }
}
