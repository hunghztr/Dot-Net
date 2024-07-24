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
namespace GUI.StudentDialog
{
    public partial class StudentAdd : Form
    {
        BUS_System BUSSystem = BUS_System.Instance;
        public StudentAdd()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            var dt = BUSSystem.getElements("STUDENT");
            Person.setId(dt.Rows.Count);
            txtId.Text = Person.getId();
            txtName.Text = "";
            txtCccd.Text = "";
            dtpBirth.Value = DateTime.Now;
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtSchoolYear.Text = "";
        }
        private void btbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void StudentAdd_Load(object sender, EventArgs e)
        {
            var dt = BUSSystem.getElements("STUDENT");
            Person.setId(dt.Rows.Count);
            txtId.Text = Person.getId();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> s = new List<string>();
            
            s.Add(txtCccd.Text);
            s.Add(txtName.Text);
            s.Add(txtAddress.Text);
            s.Add(txtPhone.Text);
            s.Add(txtSchoolYear.Text);
            if (BUSSystem.checkLegal(s))
            {
                if (cboCourseId.SelectedValue == null)
                {
                    MessageBox.Show("vui lòng chọn lớp cho học sinh");
                }
                else
                {
                    DateTime date = dtpBirth.Value;
                    bool isSuccess = BUSSystem.addStudent(txtId.Text, txtCccd.Text, txtName.Text, date.Date, txtAddress.Text
                        , txtPhone.Text, txtSchoolYear.Text, cboCourseId.SelectedValue.ToString());
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

        private void cboCourseId_Click(object sender, EventArgs e)
        {
            ComboBox com = (ComboBox)sender;
            com.DataSource = BUSSystem.getElements("COURSE");
            com.DisplayMember = "COURSENAME";
            com.ValueMember = "ID";
        }
    }
}
