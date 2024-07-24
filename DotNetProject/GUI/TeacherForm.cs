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
using GUI.TeacherDialog;
namespace GUI
{
    public partial class TeacherForm : Form
    {
        BUS_System BUSSystem = BUS_System.Instance;
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.getElements("TEACHER");
            
        }

        private void rbtnAZName_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if(radioButton.Checked)
            {
                string result = radioButton.Text;
                dataGridView1.DataSource = BUSSystem.sort(result,"TEACHER","FULLNAME");
            }
        }

        private void rbtnZAName_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                string result = radioButton.Text;
                dataGridView1.DataSource = BUSSystem.sort(result, "TEACHER", "FULLNAME");
            }
        }

        private void rbtnAscSalary_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                string result = radioButton.Text;
                dataGridView1.DataSource = BUSSystem.sort(result, "TEACHER", "SALARY");
            }
        }

        private void rbtnDescSalary_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                string result = radioButton.Text;
                dataGridView1.DataSource = BUSSystem.sort(result, "TEACHER", "SALARY");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TeacherAdd form = new TeacherAdd();
            form.ShowDialog();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.getElements("TEACHER");
            txtFind.Text = "";
            foreach(RadioButton i in groupBox1.Controls)
            {
                i.Checked = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TeacherUpdate form = new TeacherUpdate();
            form.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            TeacherRemove form = new TeacherRemove();
            form.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.findElements(txtFind.Text,"FULLNAME","TEACHER");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }
    }
}
