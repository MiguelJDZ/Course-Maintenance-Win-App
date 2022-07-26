/*
 * File: AlterCourseForm.cs
 * Author: Miguel Duran
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/15/2021
 * Purpose: Form that can be used to add or modify a course.
 */

using CourseMaintenanceWinFormsApp.DataAccess;
using CourseMaintenanceWinFormsApp.Domain;
using CourseMaintenanceWinFormsApp.Presentation;
using System;
using System.Windows.Forms;

namespace CourseMaintenanceWinFormsApp
{
    /// <summary>
    /// A form used to add or modify courses.
    /// </summary>
    public partial class AlterCourseForm : Form
    {
        /// <summary>The course that is added or modified.</summary>
        private Course course;

        /// <summary>
        /// Creates the form by initializing its components.
        /// </summary>
        public AlterCourseForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displays the form's associated course when the form loads.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void AlterCourseForm_Load(object sender, EventArgs e)
        {
            this.LoadStateComboBox();

            if (this.Tag == null)
            {
                this.Text = this.Text;
                txtCode.Text = "CIS415";
                cboDepartment.SelectedIndex = 0;
            }
            else
            {
                this.Text = "Modify Course";
                course = (Course)this.Tag;

                txtCode.Text = course.Code.ToString();
                txtCode.Enabled = false;
                cboDepartment.Text = course.Department.DepartmentName;
                txtTitle.Text = course.Title;
                txtCredits.Text = course.Credits.ToString();
            }
        }

        /// <summary>
        /// Reads and populates the state combo box.
        /// </summary>
        private void LoadStateComboBox()
        {
            try
            {
                cboDepartment.DataSource = DepartmentDA.GetDepartment();
                cboDepartment.DisplayMember = "DepartmentName";
                cboDepartment.ValueMember = "DepartmentCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Accepts and saves the course's data if it is valid.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                course = new Course
                {
                    Code = txtCode.Text,
                    Department = DepartmentDA.GetDepartment(cboDepartment.SelectedValue.ToString()),
                    Title = txtTitle.Text,
                    Credits = Convert.ToInt32(txtCredits.Text),
                };

                this.Tag = course;
                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Determines whether the form has valid data.
        /// </summary>
        /// <returns>true if the data is valid; false otherwise.</returns>
        private bool IsValidData()
        {
            return
                FormValidator.IsPresent(txtCode) &&
                FormValidator.MatchesPattern(txtCode, @"^[A-Z]{3}[0-9]{3}$") &&

                FormValidator.IsPresent(txtTitle) &&
                FormValidator.MatchesPattern(txtTitle, @"^[A-Z][A-Za-z_-]{5,50}$") &&

                FormValidator.IsPresent(txtCredits) &&
                FormValidator.MatchesPattern(txtCredits, @"^[1-5]$") &&

                FormValidator.IsSelected(cboDepartment);
        }

        /// <summary>
        /// Closes the form when Cancel button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
