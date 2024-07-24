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
    public partial class GradeListAdd : Form
    {
        BUS_System BUSSystem = BUS_System.Instance;
        public GradeListAdd()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            clrear();
            dataGridView1.DataSource = BUSSystem.getElements("STUDENT");
        }
        private void clrear()
        {
            txtId.Text = "";
            txtMath.Text = "";
            txtLiter.Text = "";
            txtEng.Text = "";
            txtPhy.Text = "";
            txtChem.Text = "";
            txtHis.Text = "";
            txtGeo.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1){
                var row = dataGridView1.SelectedRows[0];
                txtId.Text = row.Cells[0].Value.ToString();
            }
        }

        private void GradeListAdd_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.getElements("STUDENT");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> s = new List<string>();
            
            s.Add(txtMath.Text);
            s.Add(txtLiter.Text);
            s.Add(txtEng.Text);
            s.Add(txtPhy.Text);
            s.Add(txtChem.Text);
            s.Add(txtHis.Text);
            s.Add(txtGeo.Text);
            if (BUSSystem.checkLegal(s) && BUSSystem.isNums(s))
            {
                
                    float math = float.Parse(txtMath.Text);
                    float liter = float.Parse(txtLiter.Text);
                    float eng = float.Parse(txtEng.Text);
                    float phy = float.Parse(txtPhy.Text);
                    float chem = float.Parse(txtChem.Text);
                    float his = float.Parse(txtHis.Text);
                    float geo = float.Parse(txtGeo.Text);
                    float avg = (float)Math.Round((math + liter + eng + phy + chem + his + geo) / 7,2);
                    bool isSuccess = BUSSystem.addGradeList(txtId.Text, math, liter, eng, phy, chem, his, geo, avg);
                    if (isSuccess)
                    {

                        MessageBox.Show("thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("thêm thất bại");
                    }
                    clrear();
                    dataGridView1.DataSource = BUSSystem.getElements("STUDENT");
                
            }
            else
            {
                MessageBox.Show("bạn chưa nhập đủ thông tin hoặc nhập sai định dạng");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtGeo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHis_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhy_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEng_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLiter_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMath_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
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
