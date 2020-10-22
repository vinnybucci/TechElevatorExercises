using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Transactions;

namespace ProjectOrganizerTests
{
    [TestClass]

    public class ProjectSqlDAOTest
    {
        private TransactionScope transaction { get; set; }
        private string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = EmployeeDB; Integrated Security = True";
        private string projectCodeToTest = "Store Support";

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
        public void GetAllProjectsTest()
        {

        }
        [TestMethod]
        public void AssignEmployeeToProjectTest()
        {

        }
        [TestMethod]
        public void RemoveEmployeeFromProjectTest()
        {

        }
        [TestMethod]
        public void CreateProjectTest()
        {

        }
    }
}
