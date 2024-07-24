namespace GUI
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnGradeList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.cboCourseId = new System.Windows.Forms.ComboBox();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTeacher,
            this.mnStudent,
            this.mnCourse,
            this.mnGradeList,
            this.mnSubject,
            this.mnuReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnTeacher
            // 
            this.mnTeacher.Name = "mnTeacher";
            this.mnTeacher.Size = new System.Drawing.Size(135, 24);
            this.mnTeacher.Text = "Quản lí giáo viên";
            this.mnTeacher.Click += new System.EventHandler(this.mnTeacher_Click);
            // 
            // mnStudent
            // 
            this.mnStudent.Name = "mnStudent";
            this.mnStudent.Size = new System.Drawing.Size(128, 24);
            this.mnStudent.Text = "Quản lí học sinh";
            this.mnStudent.Click += new System.EventHandler(this.mnStudent_Click);
            // 
            // mnCourse
            // 
            this.mnCourse.Name = "mnCourse";
            this.mnCourse.Size = new System.Drawing.Size(124, 24);
            this.mnCourse.Text = "Quản lí lớp học";
            this.mnCourse.Click += new System.EventHandler(this.mnCourse_Click);
            // 
            // mnGradeList
            // 
            this.mnGradeList.Name = "mnGradeList";
            this.mnGradeList.Size = new System.Drawing.Size(108, 24);
            this.mnGradeList.Text = "Quản lí điểm";
            this.mnGradeList.Click += new System.EventHandler(this.mnSubject_Click);
            // 
            // mnSubject
            // 
            this.mnSubject.Name = "mnSubject";
            this.mnSubject.Size = new System.Drawing.Size(115, 24);
            this.mnSubject.Text = "Xem môn học";
            this.mnSubject.Click += new System.EventHandler(this.mnGradeList_Click);
            // 
            // mnuReport
            // 
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(84, 24);
            this.mnuReport.Text = "Thống kê";
            this.mnuReport.Click += new System.EventHandler(this.báoCáoToolStripMenuItem_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(125, 294);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.Size = new System.Drawing.Size(820, 220);
            this.dgvStudent.TabIndex = 1;
            // 
            // cboCourseId
            // 
            this.cboCourseId.FormattingEnabled = true;
            this.cboCourseId.Location = new System.Drawing.Point(439, 111);
            this.cboCourseId.Margin = new System.Windows.Forms.Padding(4);
            this.cboCourseId.Name = "cboCourseId";
            this.cboCourseId.Size = new System.Drawing.Size(160, 24);
            this.cboCourseId.TabIndex = 2;
            this.cboCourseId.SelectedIndexChanged += new System.EventHandler(this.cboCourseId_SelectedIndexChanged);
            this.cboCourseId.SelectionChangeCommitted += new System.EventHandler(this.cboCourseId_SelectionChangeCommitted);
            this.cboCourseId.Click += new System.EventHandler(this.cboCourseId_Click);
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Location = new System.Drawing.Point(125, 194);
            this.dgvTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.RowHeadersWidth = 51;
            this.dgvTeacher.Size = new System.Drawing.Size(820, 68);
            this.dgvTeacher.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Giáo viên chủ nhiệm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "danh sách học sinh trong lớp";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTeacher);
            this.Controls.Add(this.cboCourseId);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnTeacher;
        private System.Windows.Forms.ToolStripMenuItem mnStudent;
        private System.Windows.Forms.ToolStripMenuItem mnCourse;
        private System.Windows.Forms.ToolStripMenuItem mnGradeList;
        private System.Windows.Forms.ToolStripMenuItem mnSubject;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.ComboBox cboCourseId;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
    }
}