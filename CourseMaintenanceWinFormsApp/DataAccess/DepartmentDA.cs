/*
 * File: DepartmentDA.cs
 * Author: Miguel Duran
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/15/2021
 * Purpose: This class provides data access for a department in the university.
 */

using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using CourseMaintenanceWinFormsApp.Domain;

namespace CourseMaintenanceWinFormsApp.DataAccess
{
    /// <summary>
    /// A class that provides data access for a department in the university.
    /// </summary>
    public static class DepartmentDA
    {
        /// <summary>
        /// Gets the list of departments from the data store.
        /// </summary>
        /// <returns>The list of departments.</returns>
        public static List<Department> GetDepartment()
        {
            var departments = new List<Department>();
            var selectStatement =
                "SELECT DepartmentId, Name " +
                "FROM Departments " +
                "ORDER BY DepartmentId";

            using var connection = new SqlConnection(MMABooksDA.ConnectionString);
            using var command = new SqlCommand(selectStatement, connection);

            connection.Open();
            using var dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);

            while (dataReader.Read())
            {
                var department = new Department
                {
                    DepartmentCode = dataReader["DepartmentId"].ToString(),
                    DepartmentName = dataReader["Name"].ToString()
                };
                departments.Add(department);
            }
            return departments;
        }

        /// <summary>
        /// Gets the department from the data store with the given id.
        /// </summary>
        /// <param name="departmentCode">The id of the searched department.</param>
        /// <returns>The course with the given ID.</returns>
        public static Department GetDepartment(string departmentCode)
        {
            Department department = null;

            var selectStatement =
                "SELECT DepartmentId, Name " +
                "FROM Departments " +
                "WHERE DepartmentId = @DepartmentId";

            using var connection = new SqlConnection(MMABooksDA.ConnectionString);
            using var command = new SqlCommand(selectStatement, connection);

            command.Parameters.AddWithValue("@DepartmentId", departmentCode);
            connection.Open();

            using var dataReader = command.ExecuteReader(
                CommandBehavior.SingleRow & CommandBehavior.CloseConnection);

            if (dataReader.Read())
            {
                department = new Department
                {
                    DepartmentCode = dataReader["DepartmentId"].ToString(),
                    DepartmentName = dataReader["Name"].ToString()
                };
            }
            return department;
        }
    }
}
