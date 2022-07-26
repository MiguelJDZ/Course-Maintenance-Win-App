/*
 * File: Course.cs
 * Author: Miguel Duran
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/15/2021
 * Purpose: This class represent a course.
 */

namespace CourseMaintenanceWinFormsApp.Domain
{

    /// <summary>
    /// A class that represents a course.
    /// </summary>
    public class Course
    {

        /// <summary>The code of the course.</summary>
        public string Code { get; set; }

        /// <summary>The department of the course.</summary>
        public Department Department { get; set; }

        /// <summary>The title of the course.</summary>
        public string Title { get; set; }

        /// <summary>The credits of the course.</summary>
        public int Credits { get; set; }
    }
}
