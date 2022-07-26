
namespace CourseMaintenanceWinFormsApp
{
    partial class CourseMaintenanceForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCourse = new System.Windows.Forms.GroupBox();
            this.btnViewCourses = new System.Windows.Forms.Button();
            this.btnGetCourse = new System.Windows.Forms.Button();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCourse
            // 
            this.grpCourse.Controls.Add(this.btnViewCourses);
            this.grpCourse.Controls.Add(this.btnGetCourse);
            this.grpCourse.Controls.Add(this.txtCredits);
            this.grpCourse.Controls.Add(this.txtTitle);
            this.grpCourse.Controls.Add(this.cboDepartment);
            this.grpCourse.Controls.Add(this.txtCode);
            this.grpCourse.Controls.Add(this.lblTitle);
            this.grpCourse.Controls.Add(this.lblCredits);
            this.grpCourse.Controls.Add(this.lblDepartment);
            this.grpCourse.Controls.Add(this.lblCode);
            this.grpCourse.Location = new System.Drawing.Point(12, 12);
            this.grpCourse.Name = "grpCourse";
            this.grpCourse.Size = new System.Drawing.Size(431, 172);
            this.grpCourse.TabIndex = 0;
            this.grpCourse.TabStop = false;
            this.grpCourse.Text = "Course";
            // 
            // btnViewCourses
            // 
            this.btnViewCourses.Location = new System.Drawing.Point(298, 37);
            this.btnViewCourses.Name = "btnViewCourses";
            this.btnViewCourses.Size = new System.Drawing.Size(127, 23);
            this.btnViewCourses.TabIndex = 3;
            this.btnViewCourses.Text = "View All Courses...";
            this.btnViewCourses.UseVisualStyleBackColor = true;
            this.btnViewCourses.Click += new System.EventHandler(this.btnViewCourses_Click);
            // 
            // btnGetCourse
            // 
            this.btnGetCourse.Location = new System.Drawing.Point(217, 38);
            this.btnGetCourse.Name = "btnGetCourse";
            this.btnGetCourse.Size = new System.Drawing.Size(75, 23);
            this.btnGetCourse.TabIndex = 2;
            this.btnGetCourse.Text = "Get Course";
            this.btnGetCourse.UseVisualStyleBackColor = true;
            this.btnGetCourse.Click += new System.EventHandler(this.btnGetCourse_Click);
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(111, 137);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(33, 23);
            this.txtCredits.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(111, 102);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(212, 23);
            this.txtTitle.TabIndex = 0;
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(111, 69);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(148, 23);
            this.cboDepartment.TabIndex = 0;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(111, 38);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 23);
            this.txtCode.TabIndex = 1;
            this.txtCode.Tag = "Course code";
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(32, 105);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(32, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(32, 140);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(47, 15);
            this.lblCredits.TabIndex = 0;
            this.lblCredits.Text = "Credits:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(32, 72);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(73, 15);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Department:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(32, 41);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(38, 15);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 216);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add New...";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(103, 216);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Modify...";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(196, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete...";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(368, 216);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CourseMaintenanceForm
            // 
            this.AcceptButton = this.btnViewCourses;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(455, 251);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpCourse);
            this.Name = "CourseMaintenanceForm";
            this.Text = "Course Maintenance";
            this.Load += new System.EventHandler(this.CourseMaintenanceForm_Load);
            this.grpCourse.ResumeLayout(false);
            this.grpCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCourse;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnViewCourses;
        private System.Windows.Forms.Button btnGetCourse;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}

