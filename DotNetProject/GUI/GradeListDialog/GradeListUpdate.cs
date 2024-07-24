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
    public partial class GradeListUpdate : Form
    {
        BUS_System BUSSystem = BUS_System.Instance;
        public GradeListUpdate()
        {
            InitializeComponent();
        }

        private void GradeListUpdate_Load(object sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> s = new List<string>();
            s.Add(txtId.Text);
            if (BUSSystem.checkLegal(s))
            {
                float math = float.Parse(txtMath.Text);
                float liter = float.Parse(txtLiter.Text);
                float eng = float.Parse(txtEng.Text);
                float phy = float.Parse(txtPhy.Text);
                float chem = float.Parse(txtChem.Text);
                float his = float.Parse(txtHis.Text);
                float geo = float.Parse(txtGeo.Text);
                float avg = (math + liter + eng + phy + chem + his + geo) / 7.0f;
                bool isSuccess = BUSSystem.updateGradeList(txtId.Text, math, liter, eng, phy, chem, his, geo, avg);
                if (isSuccess)
                {
                    MessageBox.Show("cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("cập nhật thất bại");
                }
            }
            else
            {
                MessageBox.Show("vui lòng chọn thông tin cần sửa");
            }
        }
    }
}
