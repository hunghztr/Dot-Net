namespace GUI
{
    partial class TeacherForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnDescSalary = new System.Windows.Forms.RadioButton();
            this.rbtnAscSalary = new System.Windows.Forms.RadioButton();
            this.rbtnZAName = new System.Windows.Forms.RadioButton();
            this.rbtnAZName = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(99, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(99, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(270, 180);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(453, 180);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Location = new System.Drawing.Point(617, 180);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(75, 23);
            this.btnReLoad.TabIndex = 4;
            this.btnReLoad.Text = "Làm mới";
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnDescSalary);
            this.groupBox1.Controls.Add(this.rbtnAscSalary);
            this.groupBox1.Controls.Add(this.rbtnZAName);
            this.groupBox1.Controls.Add(this.rbtnAZName);
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 126);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sắp xếp";
            // 
            // rbtnDescSalary
            // 
            this.rbtnDescSalary.AutoSize = true;
            this.rbtnDescSalary.Location = new System.Drawing.Point(166, 85);
            this.rbtnDescSalary.Name = "rbtnDescSalary";
            this.rbtnDescSalary.Size = new System.Drawing.Size(121, 17);
            this.rbtnDescSalary.TabIndex = 3;
            this.rbtnDescSalary.TabStop = true;
            this.rbtnDescSalary.Text = "theo lương giảm dần";
            this.rbtnDescSalary.UseVisualStyleBackColor = true;
            this.rbtnDescSalary.CheckedChanged += new System.EventHandler(this.rbtnDescSalary_CheckedChanged);
            // 
            // rbtnAscSalary
            // 
            this.rbtnAscSalary.AutoSize = true;
            this.rbtnAscSalary.Location = new System.Drawing.Point(6, 85);
            this.rbtnAscSalary.Name = "rbtnAscSalary";
            this.rbtnAscSalary.Size = new System.Drawing.Size(120, 17);
            this.rbtnAscSalary.TabIndex = 2;
            this.rbtnAscSalary.TabStop = true;
            this.rbtnAscSalary.Text = "theo lương tăng dần";
            this.rbtnAscSalary.UseVisualStyleBackColor = true;
            this.rbtnAscSalary.CheckedChanged += new System.EventHandler(this.rbtnAscSalary_CheckedChanged);
            // 
            // rbtnZAName
            // 
            this.rbtnZAName.AutoSize = true;
            this.rbtnZAName.Location = new System.Drawing.Point(166, 29);
            this.rbtnZAName.Name = "rbtnZAName";
            this.rbtnZAName.Size = new System.Drawing.Size(81, 17);
            this.rbtnZAName.TabIndex = 1;
            this.rbtnZAName.TabStop = true;
            this.rbtnZAName.Text = "theo tên z-a";
            this.rbtnZAName.UseVisualStyleBackColor = true;
            this.rbtnZAName.CheckedChanged += new System.EventHandler(this.rbtnZAName_CheckedChanged);
            // 
            // rbtnAZName
            // 
            this.rbtnAZName.AutoSize = true;
            this.rbtnAZName.Location = new System.Drawing.Point(6, 29);
            this.rbtnAZName.Name = "rbtnAZName";
            this.rbtnAZName.Size = new System.Drawing.Size(81, 17);
            this.rbtnAZName.TabIndex = 0;
            this.rbtnAZName.TabStop = true;
            this.rbtnAZName.Text = "theo tên a-z";
            this.rbtnAZName.UseVisualStyleBackColor = true;
            this.rbtnAZName.CheckedChanged += new System.EventHandler(this.rbtnAZName_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm kiếm theo tên";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(471, 51);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(152, 20);
            this.txtFind.TabIndex = 7;
            this.txtFind.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReLoad);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnDescSalary;
        private System.Windows.Forms.RadioButton rbtnAscSalary;
        private System.Windows.Forms.RadioButton rbtnZAName;
        private System.Windows.Forms.RadioButton rbtnAZName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
    }
}