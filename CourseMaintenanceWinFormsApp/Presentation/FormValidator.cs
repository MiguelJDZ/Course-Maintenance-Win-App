/*
 * File: FormValidator.cs
 * Author: Miguel Duran
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/15/2021
 * Purpose: This utility class contains validation methods.
 */

using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CourseMaintenanceWinFormsApp.Presentation
{
    /// <summary>
    /// A validation utility class for form controls.
    /// </summary>
    public static class FormValidator
    {
        /// <summary>The title of the validation message box.</summary>
        public static string Title { get; set; } = "Entry Error";

        /// <summary>
        /// Determines whether the given textbox contains data.
        /// </summary>
        /// <param name="textBox">The textbox to be validated.</param>
        /// <returns>true if the textbox contains data; false otherwise.</returns>
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show($"{textBox.Tag} is required.", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Determines whether the given textbox contains a valid integer.
        /// </summary>
        /// <param name="textBox">The textbox to be validated.</param>
        /// <returns>true if the textbox contains an integer; false otherwise.</returns>
        public static bool IsInt32(TextBox textBox)
        {
            if (!int.TryParse(textBox.Text.Trim(), out _))
            {
                MessageBox.Show($"{textBox.Tag} should be an integer.", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Determines whether the given textbox contains a string that matches the
        /// given pattern (a regurlar expression).
        /// </summary>
        /// <param name="textBox">The textbox to be validated.</param>
        /// <param name="pattern">The pattern with the regular expression.</param>
        /// <returns>true if the textbox contains a string matching the pattern; false otherwise.</returns>
        public static bool MatchesPattern(TextBox textBox, string pattern)
        {
            if (!Regex.IsMatch(textBox.Text.Trim(), pattern))
            {
                MessageBox.Show($"{textBox.Tag} has an invalid format.", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Determines whether the given combobox has selected data.
        /// </summary>
        /// <param name="comboBox">The combobox to be validated.</param>
        /// <returns>true if the combobox has selected data; false otherwise.</returns>
        public static bool IsSelected(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show($"{comboBox.Tag} should be selected.", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox.Focus();
                return false;
            }
            return true;
        }

    }
}
