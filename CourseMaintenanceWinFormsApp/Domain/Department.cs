/*
 * File: Department.cs
 * Author: Miguel Duran
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/15/2021
 * Purpose: This class represent a department.
 */

namespace CourseMaintenanceWinFormsApp.Domain
{
    /// <summary>
    /// A class that represents a department.
    /// </summary>
    public class Department
    {

        /// <summary>The code of the department.</summary>
        public string DepartmentCode { get; set; }

        /// <summary>The name of the department.</summary>
        public string DepartmentName { get; set; }
    }
}
