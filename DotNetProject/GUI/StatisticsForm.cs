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
using Microsoft.Reporting.WinForms;

namespace GUI
{
    public partial class StatisticsForm : Form
    {
        BUS_System busSystem= BUS_System.Instance;
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {

            this.reportViewer.RefreshReport();

            this.reportViewer.RefreshReport();
        }

        private void cbbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

          

        }

        private void cbbClass_Click(object sender, EventArgs e)
        {
            DataTable dt = busSystem.getElements("COURSE");
            cbbClass.DataSource = dt;
            cbbClass.DisplayMember = "COURSENAME";
            cbbClass.ValueMember = "ID";
        }

        private void cbbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {

            ShowReport(cbbClass.SelectedValue.ToString());

        }

        void ShowReport(string classId)
        {
            StudentContext studentContext = new StudentContext();
            List<STUDENT> listStudent = studentContext.STUDENTs.ToList();
            List<StudentReport> listReport = new List<StudentReport>();
            foreach (STUDENT std in listStudent)
            {
                StudentReport temp = new StudentReport();
                temp.id = std.ID;
                temp.fullName = std.FULLNAME;
                temp.birth = std.BIRTH.ToString();
                temp.address = std.ADDRESSS;
                temp.avgGrade = std.GRADELIST?.AVGGRADE.ToString();
                double avg = double.Parse(std.GRADELIST?.AVGGRADE.ToString());
                temp.classification = CheckClassification(avg);
                if (std.COURSE.ID.ToString() == classId)
                {
                    listReport.Add(temp);
                }

            }
            reportViewer.LocalReport.ReportPath = "Report1.rdlc";
            var source = new ReportDataSource("DataSet1", listReport);
            var source1 = new ReportDataSource("DataSet2", ShowQuanity(listReport));
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(source);
            reportViewer.LocalReport.DataSources.Add(source1);
            this.reportViewer.RefreshReport();
        }
        string CheckClassification(double avgGrade)
        {
            string classification = "";
            if (avgGrade >= 8.5 && avgGrade <= 10)
            {
                classification += "Giỏi";
            }
            else if (avgGrade >= 6.5)
            {
                classification += "Khá";
            }
            else if (avgGrade >= 5)
            {
                classification += "Trung bình";
            }
            else if (avgGrade < 5 && avgGrade >= 0)
            {
                classification += "Yếu";
            }
            else
            {
                classification += "Điểm vớ vẩn :)";
            }

            return classification;

        }

        List<CountStudentReport> ShowQuanity(List<StudentReport> listReport)
        {
            List<CountStudentReport> countStudentReport = new List<CountStudentReport>();
            List<string> name = new List<string> { "Giỏi", "Khá", "Trung bình", "Yếu" };

            Count countG = new Count(0, "Giỏi");
            Count countK = new Count(0, "Khá");
            Count countTB = new Count(0, "Trung bình");
            Count countY = new Count(0, "Yếu");

            foreach (var std in listReport)
            {
                if (std.classification == countG.name)
                {
                    countG.value++;
                }
                else if (std.classification == countK.name)
                {
                    countK.value++;
                }
                else if (std.classification == countTB.name)
                {
                    countTB.value++;
                }
                else if (std.classification == countY.name)
                {
                    countY.value++;
                }
            }
            List<Count> countList = new List<Count> { countG, countK, countTB, countY };

            foreach (var count in countList)
            {
                CountStudentReport temp = new CountStudentReport();
                temp.classificationName = count.name;
                temp.studentQuantity = count.value;
                countStudentReport.Add(temp);
            }

            return countStudentReport;
            

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public class Count
    {
        public int value;
        public string name;
        public Count(int v, string n)
        {
            value = v;
            name = n;
        }
    }

}
