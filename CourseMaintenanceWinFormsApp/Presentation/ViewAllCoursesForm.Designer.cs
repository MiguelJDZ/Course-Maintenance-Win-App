
namespace CourseMaintenanceWinFormsApp.Presentation
{
    partial class ViewAllCoursesForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpCourses = new System.Windows.Forms.GroupBox();
            this.lstCourses = new System.Windows.Forms.ListView();
            this.colDepartment = new System.Windows.Forms.ColumnHeader();
            this.colCode = new System.Windows.Forms.ColumnHeader();
            this.colTitle = new System.Windows.Forms.ColumnHeader();
            this.colCredits = new System.Windows.Forms.ColumnHeader();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.grpCourses.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(434, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(137, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(591, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpCourses
            // 
            this.grpCourses.Controls.Add(this.lstCourses);
            this.grpCourses.Location = new System.Drawing.Point(26, 77);
            this.grpCourses.Name = "grpCourses";
            this.grpCourses.Size = new System.Drawing.Size(640, 339);
            this.grpCourses.TabIndex = 0;
            this.grpCourses.TabStop = false;
            this.grpCourses.Text = "Courses";
            // 
            // lstCourses
            // 
            this.lstCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDepartment,
            this.colCode,
            this.colTitle,
            this.colCredits});
            this.lstCourses.FullRowSelect = true;
            this.lstCourses.GridLines = true;
            this.lstCourses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstCourses.HideSelection = false;
            this.lstCourses.Location = new System.Drawing.Point(6, 22);
            this.lstCourses.MultiSelect = false;
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(628, 311);
            this.lstCourses.TabIndex = 0;
            this.lstCourses.UseCompatibleStateImageBehavior = false;
            this.lstCourses.View = System.Windows.Forms.View.Details;
            // 
            // colDepartment
            // 
            this.colDepartment.Text = "Department";
            this.colDepartment.Width = 180;
            // 
            // colCode
            // 
            this.colCode.Text = "Code";
            this.colCode.Width = 150;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Title";
            this.colTitle.Width = 210;
            // 
            // colCredits
            // 
            this.colCredits.Text = "Credits";
            this.colCredits.Width = 80;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(32, 439);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(110, 15);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "There are 0 courses.";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(585, 435);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(496, 435);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // ViewAllCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 480);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.grpCourses);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "ViewAllCoursesForm";
            this.Text = "View All Courses";
            this.Load += new System.EventHandler(this.ViewAllCoursesForm_Load);
            this.grpCourses.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpCourses;
        private System.Windows.Forms.ListView lstCourses;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ColumnHeader colDepartment;
        private System.Windows.Forms.ColumnHeader colCode;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colCredits;
    }
}