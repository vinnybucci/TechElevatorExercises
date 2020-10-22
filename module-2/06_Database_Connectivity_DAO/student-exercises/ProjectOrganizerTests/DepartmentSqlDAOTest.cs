using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Bson;
using ProjectOrganizer.DAL;
using ProjectOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Transactions;

namespace ProjectOrganizerTests
{
    [TestClass]
    public class DepartmentSqlDAOTest
    {
        private TransactionScope transaction { get; set; }
        private string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = EmployeeDB; Integrated Security = True";

        [TestInitialize]
        public void Initialize()
        {
            transaction = new TransactionScope();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select count(*) From department:", connection);

                cmd = new SqlCommand("INSERT INTO department (name) VALUES ('Test 1');", connection);
                cmd.ExecuteNonQuery();
            }
        }
        [TestCleanup]
        public void Cleanup()
        {
            transaction.Dispose();
        }


        [TestMethod]
        public void GetDepartmentTest()
        {
            DepartmentSqlDAO departmentSqlDAO = new DepartmentSqlDAO(connectionString);

            List<Department> departments = (List<Department>)departmentSqlDAO.GetDepartments();
            Assert.AreEqual(7, departments.Count);
        }
        [TestMethod]
        public void CreateDepartmentTest()
        {
            DepartmentSqlDAO departmentSqlDAO = new DepartmentSqlDAO(connectionString);
            Department department = new Department();
            {
                department.Name = "Test 1";
            };
            Assert.AreEqual("Test 1", department.Name);

        }
        [TestMethod]
        public void UpdateDepartmentTest()
        {
            DepartmentSqlDAO departmentSqlDAO = new DepartmentSqlDAO(connectionString);
            Department department = new Department();
            department.Id = 1;
            department.Name = "Update";
            Assert.AreEqual("Update", department.Name);
        }

    }
}

