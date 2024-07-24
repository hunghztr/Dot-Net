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
namespace GUI
{
    public partial class HomeForm : Form
    {
        BUS_System BUSSystem = BUS_System.Instance;
        public HomeForm()
        {
            InitializeComponent();
        }

        private void mnTeacher_Click(object sender, EventArgs e)
        {
            TeacherForm form = new TeacherForm();
            form.ShowDialog();
        }

        private void mnStudent_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm();
            form.ShowDialog();
        }

        private void mnCourse_Click(object sender, EventArgs e)
        {
            CourseForm form = new CourseForm();
            form.ShowDialog();
        }

        private void mnSubject_Click(object sender, EventArgs e)
        {
            GradeListForm form = new GradeListForm();
            form.ShowDialog();
        }

        private void mnGradeList_Click(object sender, EventArgs e)
        {
            SubjectForm form = new SubjectForm();
            form.ShowDialog();
        }

        private void cboCourseId_Click(object sender, EventArgs e)
        {
            ComboBox com = (ComboBox)sender;
            com.DataSource = BUSSystem.getElements("COURSE");
            com.DisplayMember = "COURSENAME";
            com.ValueMember = "ID";
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void cboCourseId_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboCourseId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox com = (ComboBox)sender;
            string courseId = com.SelectedValue.ToString();
            DataTable teacherId = BUSSystem.getTeacherIdFromCourse(courseId);
            string teacherIdString = teacherId.Rows[0][0].ToString();
            dgvTeacher.DataSource = BUSSystem.getElementsById(teacherIdString, "TEACHER", "ID");
            dgvStudent.DataSource = BUSSystem.getElementsById(courseId, "STUDENT", "COURSEID");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsForm form = new StatisticsForm();
            form.ShowDialog();
        }
    }
}
