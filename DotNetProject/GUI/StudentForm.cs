using BUS;
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
using GUI.StudentDialog;
namespace GUI
{
    public partial class StudentForm : Form
    {
        BUS_System BUSSystem = BUS_System.Instance;
        public StudentForm()
        {
            InitializeComponent();
        }

        private void rbtnAZ_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                string result = radioButton.Text;
                dataGridView1.DataSource = BUSSystem.sort(result, "STUDENT", "FULLNAME");
            }
        }

        private void rbtnZA_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                string result = radioButton.Text;
                dataGridView1.DataSource = BUSSystem.sort(result, "STUDENT", "FULLNAME");
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.getElements("STUDENT");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.getElements("STUDENT");
            txtFind.Text = "";
            foreach(RadioButton i in groupBox1.Controls)
            {
                i.Checked = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentAdd form = new StudentAdd();
            form.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StudentUpdate form = new StudentUpdate();
            form.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            StudentRemove form = new StudentRemove();
            form.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSSystem.findElements(txtFind.Text,"FULLNAME", "STUDENT");
        }
    }
}
