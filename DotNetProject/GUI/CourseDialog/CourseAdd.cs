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
namespace GUI.CourseDialog
{
    public partial class CourseAdd : Form
    {
        BUS_System BUSSystem = BUS_System.Instance;
        public CourseAdd()
        {
            InitializeComponent();
        }

        private void btbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            DataTable dt = BUSSystem.getElements("COURSE");
            Course.setId(dt.Rows.Count);
            txtId.Text = Course.getId();
            txtName.Text = "";
        }
        private void CourseAdd_Load(object sender, EventArgs e)
        {
            DataTable dt = BUSSystem.getElements("COURSE");
            Course.setId(dt.Rows.Count);
            txtId.Text = Course.getId();
        }

        private void cboTeacherId_Click(object sender, EventArgs e)
        {
            ComboBox com = (ComboBox)sender;
            com.DataSource = BUSSystem.getElements("TEACHER");
            
            com.DisplayMember = "FULLNAME";
            com.ValueMember = "ID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            
            list.Add(txtName.Text);
            if (BUSSystem.checkLegal(list))
            {
                if (cboTeacherId.SelectedValue == null)
                {
                    MessageBox.Show("vui lòng chọn giáo viên chủ nhiệm");
                }
                else
                {
                    bool isSuccess = BUSSystem.addCourse(txtId.Text, txtName.Text, cboTeacherId.SelectedValue.ToString());
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

        private void cboTeacherId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
