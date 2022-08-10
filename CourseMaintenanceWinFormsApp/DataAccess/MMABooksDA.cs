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
