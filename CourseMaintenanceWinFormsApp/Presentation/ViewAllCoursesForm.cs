/*
 * File: ViewAllCoursesForm.cs
 * Author: Miguel Duran
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/15/2021
 * Purpose: Form to see all courses.
 */

using CourseMaintenanceWinFormsApp.DataAccess;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseMaintenanceWinFormsApp.Presentation
{
    /// <summary>
    /// A form that displays courses.
    /// </summary>
    public partial class ViewAllCoursesForm : Form
    {
        /// <summary>
        /// Creates the form by initializing its components.
        /// </summary>
        public ViewAllCoursesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Retrieves and displays all courses in a list view when the form is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewAllCoursesForm_Load(object sender, EventArgs e)
        {
            int index = 0;
            var courses = CourseDA.GetCourse();

            foreach (var course in courses)
            {
                string[] fields =
                {
                    course.Department.DepartmentName, course.Code, course.Title,
                    course.Credits.ToString()
                };
                var item = new ListViewItem(fields);

                if (index++ % 2 == 0)
                {
                    item.BackColor = Color.AliceBlue;
                    item.UseItemStyleForSubItems = true;
                }
                lstCourses.Items.Add(item);
            }

            if (lstCourses.Items.Count > 0)
            {
                lstCourses.Items[0].Selected = true;
                lblAmount.Text = string.Format("There are {0} courses.",
                    lstCourses.Items.Count);
            }
        }

        /// <summary>
        /// Searches for an item with the given text.
        /// </summary>
        /// <param name="sender">The control that raised this event.</param>
        /// <param name="e">The event data.</param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (FormValidator.IsPresent(txtSearch))
            {
                ListViewItem foundItem = lstCourses.FindItemWithText(txtSearch.Text, true, 0, true);

                if (foundItem == null)
                {
                    MessageBox.Show("No course was found with this value.", "Course Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSearch.SelectAll();
                    txtSearch.Focus();
                }
                else
                {
                    lstCourses.TopItem = foundItem;
                    lstCourses.Items[foundItem.Index].Selected = true;
                }
            }
            this.DialogResult = DialogResult.None;
        }

        /// <summary>
        /// Sets the form's tag to the selected course when the select button is clicked.
        /// </summary>
        /// <param name="sender">The control that raised this event.</param>
        /// <param name="e">The event data.</param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstCourses.SelectedIndices.Count > 0)
                this.Tag = lstCourses.SelectedItems[0].SubItems[1].Text;  // CourseID

            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
