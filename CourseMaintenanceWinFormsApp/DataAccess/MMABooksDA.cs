/*
 * File: MMABooksDA.cs
 * Author: Antonio F. Huertas 841-##-####
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 05/15/2021
 * Purpose: This class provides data access for the MMABooks database.
 * NOTE: The Data Directory is the folder that contains the application's executable file.
 */

using System.Configuration;

namespace CourseMaintenanceWinFormsApp.DataAccess
{
    /// <summary>
    /// A  class that provides data access for the MMABooks database.
    /// </summary>
    public static class MMABooksDA
    {
        /// <summary>The connection string for the MMABooks database.</summary>
        public static string ConnectionString =>
            ConfigurationManager.ConnectionStrings["UniversityDB"].ConnectionString;
    }
}