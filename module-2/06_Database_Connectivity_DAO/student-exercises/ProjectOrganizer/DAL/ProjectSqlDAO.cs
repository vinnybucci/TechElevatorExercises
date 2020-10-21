using ProjectOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrganizer.DAL
{
    public class ProjectSqlDAO : IProjectDAO
    {
        private string connectionString;

        // Single Parameter Constructor
        public ProjectSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        /// <summary>
        /// Returns all projects.
        /// </summary>
        /// <returns></returns>
        public IList<Project> GetAllProjects()
        {
            List<Project> projects = new List<Project>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * from project", conn);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Project project = new Project();
                        project.ProjectId = Convert.ToInt32(reader["project_id"]);
                        project.Name = Convert.ToString(reader["name"]);
                        project.StartDate = Convert.ToDateTime(reader["from_date"]);
                        project.EndDate = Convert.ToDateTime(reader["to_date"]);

                        projects.Add(project);
                    }
                }
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
            return projects;
        }


        /// <summary>
        /// Assigns an employee to a project using their IDs.
        /// </summary>
        /// <param name="projectId">The project's id.</param>
        /// <param name="employeeId">The employee's id.</param>
        /// <returns>If it was successful.</returns>
        public bool AssignEmployeeToProject(int projectId, int employeeId)
        {
            List<Project> projects = new List<Project>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand(@"Insert into project_employee(project_id, employee_id) VALUES (@projectId, @employeeId);", conn);
                    sqlCommand.Parameters.AddWithValue("@projectid", projectId);
                    sqlCommand.Parameters.AddWithValue("@employeeid", employeeId);
                    int impactedRow = sqlCommand.ExecuteNonQuery();
                    return impactedRow > 0;

                }

            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }

        }

        /// <summary>
        /// Removes an employee from a project.
        /// </summary>
        /// <param name="projectId">The project's id.</param>
        /// <param name="employeeId">The employee's id.</param>
        /// <returns>If it was successful.</returns>
        public bool RemoveEmployeeFromProject(int projectId, int employeeId)
        {
            List<Project> projects = new List<Project>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand($"Delete FROM project_employee WHERE project_id = {projectId} and employee_id = {employeeId};", conn);
                    sqlCommand.Parameters.AddWithValue("@projectid", projectId);
                    sqlCommand.Parameters.AddWithValue("@employeeid", employeeId);
                    int impactedRow = sqlCommand.ExecuteNonQuery();
                    return impactedRow > 0;

                }

            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }

        }


        /// <summary>
        /// Creates a new project.
        /// </summary>
        /// <param name="newProject">The new project object.</param>
        /// <returns>The new id of the project.</returns>
        public int CreateProject(Project newProject)
        {
            List<Project> projects = new List<Project>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand(@"Insert into project (name, from_date, to_date) VALUES (@name, @fromDate, @toDate);", conn);
                    sqlCommand.Parameters.AddWithValue("@name", newProject.Name);
                    sqlCommand.Parameters.AddWithValue("@fromDate", newProject.StartDate);
                    sqlCommand.Parameters.AddWithValue("@toDate", newProject.EndDate);

                    int impactedRow = sqlCommand.ExecuteNonQuery();
                    return impactedRow;

                }

            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }

    }
}


    


