using System;
using System.Collections.Generic;
using System.Data;
using CourseMaintenanceWinFormsApp.Domain;
using Microsoft.Data.SqlClient;

namespace CourseMaintenanceWinFormsApp.DataAccess
{
    // A class that provides data access for a course.
    public static class CourseDA
    {
        /// <summary>
        /// Gets the list of courses from the data store.
        /// </summary>
        /// <returns>The list of courses.</returns>
        public static List<Course> GetCourse()
        {
            var courses = new List<Course>();
            var selectStatement =
                "SELECT CourseCode, DepartmentId, Title, Credits " +
                "FROM Courses " +
                "ORDER BY DepartmentId";

            using var connection = new SqlConnection(MMABooksDA.ConnectionString);
            using var selectCommand = new SqlCommand(selectStatement, connection);

            connection.Open();
            using var dataReader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);

            while (dataReader.Read())
            {
                var course = new Course
                {
                    Code = dataReader["CourseCode"].ToString(),
                    Department = DepartmentDA.GetDepartment(dataReader["DepartmentId"].ToString()),
                    Title = dataReader["Title"].ToString(),
                    Credits = (int)dataReader["Credits"]
                };
                courses.Add(course);
            }
            return courses;
        }

        /// <summary>
        /// Gets the course from the data store with the given course code.
        /// </summary>
        /// <param name="code">The course code of the searched course.</param>
        /// <returns>The course with the given course code.</returns>
        public static Course GetCustomer(string code)
        {
            Course course = null;

            var selectStatement =
                "SELECT CourseCode, DepartmentId, Title, Credits " +
                "FROM Courses " +
                "WHERE CourseCode = @CourseCode";

            using var connection = new SqlConnection(MMABooksDA.ConnectionString);
            using var command = new SqlCommand(selectStatement, connection);

            command.Parameters.AddWithValue("@CourseCode", code);
            connection.Open();

            using var dataReader = command.ExecuteReader(
                CommandBehavior.SingleRow & CommandBehavior.CloseConnection);

            if (dataReader.Read())
            {
                course = new Course
                {
                    Code= dataReader["CourseCode"].ToString(),
                    Department = DepartmentDA.GetDepartment(dataReader["DepartmentId"].ToString()),
                    Title = dataReader["Title"].ToString(),
                    Credits = (int)dataReader["Credits"]
                };
            }
            return course;
        }

        /// <summary>
        /// Adds a new course to the data stored and gets the automatically-generated course code.
        /// </summary>
        /// <param name="course">The course to be added.</param>
        public static void AddCourse(Course course)
        {
            var insertStatement =
                "INSERT INTO Courses (CourseCode, DepartmentId, Title, Credits)" +
                "VALUES (@CourseCode, @DepartmentId, @Title, @Credits)";

            using var connection = new SqlConnection(MMABooksDA.ConnectionString);
            using var command = new SqlCommand(insertStatement, connection);

            command.Parameters.AddWithValue("@CourseCode", course.Code);
            command.Parameters.AddWithValue("@DepartmentId", course.Department.DepartmentCode);
            command.Parameters.AddWithValue("@Title", course.Title);
            command.Parameters.AddWithValue("@Credits", course.Credits);

            connection.Open();
            int rowCount = command.ExecuteNonQuery();

            if (rowCount > 0)
            {
                command.CommandText = "SELECT IDENT_CURRENT('Courses') FROM Courses";
                course.Code = Convert.ToString(command.ExecuteScalar());
            }
        }

        /// <summary>
        /// Updates a course in the data store (optimistic concurrency).
        /// </summary>
        /// <param name="oldCourse">The original course's data.</param>
        /// <param name="newCourse">The modified course's data.</param>
        /// <returns>A success flag indicating whether the course was updated.</returns>
        public static bool UpdateCustomer(Course oldCourse, Course newCourse)
        {
            var updateStatement =
                "UPDATE Courses " +
                "SET CourseCode = @NewCode, DepartmentId = @NewDepartment, " +
                    "Title = @NewTitle, Credits = @NewCredits " +
                "WHERE CourseCode = @OldCode AND DepartmentId = @OldDepartment AND Title = @OldTitle AND " +
                    "Credits = @OldCredits";

            using var connection = new SqlConnection(MMABooksDA.ConnectionString);
            using var command = new SqlCommand(updateStatement, connection);

            command.Parameters.AddWithValue("@NewCode", newCourse.Code);
            command.Parameters.AddWithValue("@NewDepartment", newCourse.Department.DepartmentCode);
            command.Parameters.AddWithValue("@NewTitle", newCourse.Title);
            command.Parameters.AddWithValue("@NewCredits", newCourse.Credits);

            command.Parameters.AddWithValue("@OldCode", oldCourse.Code);
            command.Parameters.AddWithValue("@OldDepartment", oldCourse.Department.DepartmentCode);
            command.Parameters.AddWithValue("@OldTitle", oldCourse.Title);
            command.Parameters.AddWithValue("@OldCredits", oldCourse.Credits);

            connection.Open();
            var rowCount = command.ExecuteNonQuery();
            return rowCount > 0;
        }

        /// <summary>
        /// Deletes a course from the data store (optimistic concurrency).
        /// </summary>
        /// <param name="course">The course to be deleted.</param>
        /// <returns>A success flag indicating whether the course was deleted.</returns>
        public static bool DeleteCustomer(Course course)
        {
            var deleteStatement =
                "DELETE FROM Courses " +
                "WHERE CourseCode = @CourseCode AND DepartmentId = @DepartmentId AND Title = @Title AND " +
                    "Credits = @Credits";

            using var connection = new SqlConnection(MMABooksDA.ConnectionString);
            using var command = new SqlCommand(deleteStatement, connection);

            command.Parameters.AddWithValue("@CourseCode", course.Code);
            command.Parameters.AddWithValue("@DepartmentId", course.Department.DepartmentCode);
            command.Parameters.AddWithValue("@Title", course.Title);
            command.Parameters.AddWithValue("@Credits", course.Credits);

            connection.Open();
            var rowCount = command.ExecuteNonQuery();
            return rowCount > 0;
        }

    }
}
