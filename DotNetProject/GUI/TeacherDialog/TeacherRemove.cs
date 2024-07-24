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
    public partial class TeacherRemove : Form
    {
        BUS_System BUSSystem = BUS_System.Instance;
        public TeacherRemove()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
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

        private void TeacherRemove_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.getElements("TEACHER");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add(txtId.Text);
            if (BUSSystem.checkLegal(list))
            {
                bool isSuccess = BUSSystem.removeElement(txtId.Text, "TEACHER");
                if (isSuccess)
                {
                    MessageBox.Show("xóa thành công");
                }
                else
                {
                    MessageBox.Show("xóa thất bại");
                }
            }
            else
            {
                MessageBox.Show("vui lòng chọn thông tin cần xóa");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.getElements("TEACHER");
        }
    }
}
