
namespace CourseMaintenanceWinFormsApp
{
    partial class AlterCourseForm
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
            this.grpCourse = new System.Windows.Forms.GroupBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.grpCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCourse
            // 
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
            this.grpCourse.Size = new System.Drawing.Size(382, 172);
            this.grpCourse.TabIndex = 0;
            this.grpCourse.TabStop = false;
            this.grpCourse.Text = "Course";
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(111, 137);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(33, 23);
            this.txtCredits.TabIndex = 4;
            this.txtCredits.Tag = "Credits";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(111, 102);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(212, 23);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.Tag = "Title";
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(111, 69);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(148, 23);
            this.cboDepartment.TabIndex = 2;
            this.cboDepartment.Tag = "Department";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(111, 38);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 23);
            this.txtCode.TabIndex = 1;
            this.txtCode.Tag = "Course code";
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(319, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(226, 213);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "A&ccept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // AlterCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(416, 255);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpCourse);
            this.Name = "AlterCourseForm";
            this.Text = "Add Course";
            this.Load += new System.EventHandler(this.AlterCourseForm_Load);
            this.grpCourse.ResumeLayout(false);
            this.grpCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCourse;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.GroupBox gp;
    }
}