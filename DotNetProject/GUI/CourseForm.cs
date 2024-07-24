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
using GUI.CourseDialog;

namespace GUI
{
    public partial class CourseForm : Form
    {
        BUS_System BUSSystem = BUS_System.Instance;
        public CourseForm()
        {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.getElements("COURSE");
        }

        private void rbtnAZ_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                string result = radioButton.Text;
                dataGridView1.DataSource = BUSSystem.sort(result, "COURSE", "COURSENAME");
            }
        }

        private void rbtnZA_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                string result = radioButton.Text;
                dataGridView1.DataSource = BUSSystem.sort(result, "COURSE", "COURSENAME");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CourseAdd form = new CourseAdd();
            form.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CourseUpdate form = new CourseUpdate();
            form.ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.getElements("COURSE");
            txtFind.Text = "";
            foreach(RadioButton i in groupBox1.Controls)
            {
                i.Checked = false;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            CourseRemove form = new CourseRemove();
            form.ShowDialog();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.findElements(txtFind.Text,"COURSENAME", "COURSE");
        }
    }
}
