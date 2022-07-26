/*
 * File: CourseMaintenanceForm.cs
 * Author: Miguel Duran
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/15/2021
 * Purpose: Main form to pick from various options such as
 *          View All, Add, Modify, Delete.
 */

using CourseMaintenanceWinFormsApp.Presentation;
using CourseMaintenanceWinFormsApp.DataAccess;
using CourseMaintenanceWinFormsApp.Domain;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace CourseMaintenanceWinFormsApp
{
    /// <summary>
    /// A form used to maintain courses.
    /// </summary>
    public partial class CourseMaintenanceForm : Form
    {
        /// <summary>The course that is maintained.</summary>
        private Course course;

        /// <summary>
        /// Creates the form by initializing its components.
        /// </summary>
        public CourseMaintenanceForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Disables the Modify and Delete buttons when the form is loaded.
        /// </summary>
        /// <param name="sender">The control that raised this event.</param>
        /// <param name="e">The event data.</param>
        private void CourseMaintenanceForm_Load(object sender, EventArgs e)
        {
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            txtCredits.Enabled = false;
            txtTitle.Enabled = false;
            cboDepartment.Enabled = false;
        }

        /// <summary>
        /// Clears the course's data when the course code changes.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            this.ClearCustomerData();
        }

        /// <summary>
        /// Clears all controls associated with a courses.
        /// </summary>
        private void ClearCustomerData()
        {
            cboDepartment.ResetText();
            txtTitle.Clear();
            txtCredits.Clear();

            btnModify.Enabled = false;
            btnDelete.Enabled = false;
        }

        /// <summary>
        /// Displays a course based on the course code when the get course button is clicked.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnGetCourse_Click(object sender, EventArgs e)
        {
            if (FormValidator.IsPresent(txtCode))
            {
                var code = Convert.ToString(txtCode.Text);

                try
                {
                    course = CourseDA.GetCustomer(code);

                    if (course == null)
                    {
                        MessageBox.Show("No customer was found with this course code.", "Customer Not Found",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.ClearCustomerData();

                        txtCode.SelectAll();
                        txtCode.Focus();
                    }
                    else
                        this.DisplayCourseData();
                }
                catch (SqlException ex)
                {
                    this.HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    this.HandleGeneralError(ex);
                }
            }
        }

        /// <summary>
        /// Displays the courses's data.
        /// </summary>
        private void DisplayCourseData()
        {
            cboDepartment.Text = course.Department.DepartmentName;
            txtTitle.Text = course.Title;
            txtCredits.Text = course.Credits.ToString();

            btnModify.Enabled = true;
            btnDelete.Enabled = true;
        }

        /// <summary>
        /// Displays all courses when the view-all button is clicked.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnViewCourses_Click(object sender, EventArgs e)
        {
            var frmViewAllCourses = new ViewAllCoursesForm();
            var result = frmViewAllCourses.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtCode.Text = (string)frmViewAllCourses.Tag;
                btnGetCourse_Click(sender, e);
            }
        }

        /// <summary>
        /// Adds a new course when the add new button is clicked.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmAddNewCourse = new AlterCourseForm();
            var result = frmAddNewCourse.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    course = (Course)frmAddNewCourse.Tag;
                    CourseDA.AddCourse(course);

                    txtCode.Text = course.Code.ToString();
                    this.DisplayCourseData();
                }
                catch (SqlException ex)
                {
                    this.HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    this.HandleGeneralError(ex);
                }
            }
        }

        /// <summary>
        /// Modifies a new course when the modify button is clicked.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            var oldCourse = this.CloneCourse();

            var frmModifyCustomer = new AlterCourseForm();
            frmModifyCustomer.Tag = oldCourse;
            var result = frmModifyCustomer.ShowDialog();

            if (result == DialogResult.OK)
            {
                course = (Course)frmModifyCustomer.Tag;

                try
                {
                    bool success = CourseDA.UpdateCustomer(oldCourse, course);

                    if (success)
                        this.DisplayCourseData();
                    else
                        this.HandleConcurrencyConflict();
                }
                catch (SqlException ex)
                {
                    this.HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    this.HandleGeneralError(ex);
                }
            }
        }

        /// <summary>
        /// Clones the current course.
        /// </summary>
        /// <returns>A new course with the same data as the current course.</returns>
        private Course CloneCourse() =>
            new Course
            {
                Code = course.Code,
                Department = course.Department,
                Title = course.Title,
                Credits = course.Credits
            };

        /// <summary>
        /// Deletes a new course when the delete button is clicked.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Are you sure you want to delete {course.Title}?",
                "Delete Course", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.OK)
            {
                try
                {
                    var success = CourseDA.DeleteCustomer(course);

                    if (success)
                    {
                        txtCode.Clear();
                        this.ClearCustomerData();
                    }
                    else
                        this.HandleConcurrencyConflict();
                }
                catch (SqlException ex)
                {
                    this.HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    this.HandleGeneralError(ex);
                }
            }
        }

        /// <summary>
        /// Handles a concurrency conflict.
        /// </summary>
        private void HandleConcurrencyConflict()
        {
            course = CourseDA.GetCustomer(course.Code);

            if (course == null)
            {
                MessageBox.Show("Another user has deleted that course.", "Concurrency Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCode.Clear();
                this.ClearCustomerData();
            }
            else
            {
                MessageBox.Show("Another user has updated that course.\n" +
                    "The current database values will be displayed.", "Concurrency Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DisplayCourseData();
            }
        }

        /// <summary>
        /// Handles a database error.
        /// </summary>
        /// <param name="ex">The exception to be handled.</param>
        private void HandleDatabaseError(SqlException ex)
        {
            // Normally, a database error should be logged.
            MessageBox.Show(ex.Message, ex.GetType().ToString(),
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Handles a general error.
        /// </summary>
        /// <param name="ex">The exception to be handled.</param>
        private void HandleGeneralError(Exception ex) =>
            MessageBox.Show(ex.Message, ex.GetType().ToString(),
                MessageBoxButtons.OK, MessageBoxIcon.Error);

        /// <summary>
        /// Closes the form when the exit button is clicked.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}
