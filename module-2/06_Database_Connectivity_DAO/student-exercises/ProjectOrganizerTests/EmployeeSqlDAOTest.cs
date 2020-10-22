using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class EmployeeSqlDAOTest
    {
        private TransactionScope transaction { get; set; }
        private string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = EmployeeDB; Integrated Security = True";
        private string employeeCodeToTest = "Fredrick Keppard";

        [TestInitialize]
        public void Initialize()
        {
            transaction = new TransactionScope();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select count(*) From employee:", connection);

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
            public void GetAllEmployeesTest()
            {
            EmployeeSqlDAO employeeSqlDAO = new EmployeeSqlDAO(connectionString);
            List<Employee> employeesList = (List<Employee>)employeeSqlDAO.GetAllEmployees();
            Assert.AreEqual(12, employeesList.Count);
            }
        [TestMethod]
        public void SearchTest()
        {
            EmployeeSqlDAO employeeSqlDAO = new EmployeeSqlDAO(connectionString);
            List<Employee> employeesList = (List<Employee>)employeeSqlDAO.Search("Sid","Goodman");
            Assert.AreEqual(1, employeesList.Count);

        }
        [TestMethod]
        public void GetEmployeesWithoutProjectsTest()
        {
            EmployeeSqlDAO employeeSqlDAO = new EmployeeSqlDAO(connectionString);
            List<Employee> employeesList = (List<Employee>)employeeSqlDAO.GetEmployeesWithoutProjects();
            Assert.AreEqual(2, employeesList.Count);

        }
    }
    }
