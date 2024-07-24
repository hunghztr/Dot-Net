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
namespace GUI.GradeListDialog
{
    public partial class GradeListRemove : Form
    {
        BUS_System BUSSystem = BUS_System.Instance;
        public GradeListRemove()
        {
            InitializeComponent();
        }

        private void GradeListRemove_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.getElements("GRADELIST");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.getElements("GRADELIST");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                var row = dataGridView1.SelectedRows[0];
                txtId.Text = row.Cells[0].Value.ToString();
                txtMath.Text = row.Cells[1].Value.ToString();
                txtLiter.Text = row.Cells[2].Value.ToString();
                txtEng.Text = row.Cells[3].Value.ToString();
                txtPhy.Text = row.Cells[4].Value.ToString();
                txtChem.Text = row.Cells[5].Value.ToString();
                txtHis.Text = row.Cells[6].Value.ToString();
                txtGeo.Text = row.Cells[7].Value.ToString();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            List<string> s = new List<string>();
            s.Add(txtId.Text);
            if (BUSSystem.checkLegal(s))
            {
                bool isSuccess = BUSSystem.removeElement(txtId.Text, "GRADELIST");
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
    }
}
