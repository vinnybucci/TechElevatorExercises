using ProjectOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrganizer.DAL
{
    public class DepartmentSqlDAO : IDepartmentDAO
    {
        private string connectionString;

        // Single Parameter Constructor
        public DepartmentSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        /// <summary>
        /// Returns a list of all of the departments.
        /// </summary>
        /// <returns></returns>
        public IList<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();
                try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * from department", conn);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                        {
                        Department department = new Department();
                        department.Id = Convert.ToInt32(reader["department_id"]);
                        department.Name = Convert.ToString(reader["name"]);

                        departments.Add(department);
                    }
                }
            }
            catch (Exception e)
            { 
            throw new NotImplementedException();
            }
            return departments;
        }

        /// <summary>
        /// Creates a new department.
        /// </summary>
        /// <param name="newDepartment">The department object.</param>
        /// <returns>The id of the new department (if successful).</returns>
        public int CreateDepartment(Department newDepartment)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand("Insert into department (name) VALUES (@departmentName);", conn);
                    sqlCommand.Parameters.AddWithValue("@departmentName", newDepartment.Name);

                    int createdDepartment = sqlCommand.ExecuteNonQuery();
                    
                        return createdDepartment;
                    
                }
            }catch (Exception e)
              
            {
                throw new NotImplementedException();

            }
        }
        
        /// <summary>
        /// Updates an existing department.
        /// </summary>
        /// <param name="updatedDepartment">The department object.</param>
        /// <returns>True, if successful.</returns>
        public bool UpdateDepartment(Department updatedDepartment)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand($"UPDATE department SET name = '{updatedDepartment.Name}' WHERE department_id = {updatedDepartment.Id};" , conn);

                    int impactedRows = sqlCommand.ExecuteNonQuery();
                        return (impactedRows>0);

                }
            }
            catch (Exception e)

            {
                throw new NotImplementedException();

            }
        }

    }
}
