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
using GUI.GradeListDialog;
namespace GUI
{
    public partial class GradeListForm : Form
    {
        BUS_System BUSSystem = BUS_System.Instance;
        public GradeListForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GradeListUpdate form = new GradeListUpdate();
            form.ShowDialog();
        }

        private void GradeListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.getElements("GRADELIST");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.getElements("GRADELIST");
            txtFind.Text = "";
            foreach(RadioButton i in groupBox1.Controls)
            {
                i.Checked = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GradeListAdd form = new GradeListAdd();
            form.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            GradeListRemove form = new GradeListRemove();
            form.ShowDialog();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.findElements(txtFind.Text, "AVGGRADE", "GRADELIST");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                string result = radioButton.Text;
                dataGridView1.DataSource = BUSSystem.sort(result, "GRADELIST", "AVGGRADE");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                string result = radioButton.Text;
                dataGridView1.DataSource = BUSSystem.sort(result, "GRADELIST", "AVGGRADE");
            }
        }
    }
}
