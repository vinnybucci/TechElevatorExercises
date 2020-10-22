using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectOrganizer.DAL;
using ProjectOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;
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
            ProjectSqlDAO projectSqlDAO = new ProjectSqlDAO(connectionString);
            List<Project> projectsTest = (List<Project>)projectSqlDAO.GetAllProjects();
            Assert.AreEqual(7, projectsTest.Count);
        }
        [TestMethod]
        public void AssignEmployeeToProjectTest()
        {
            ProjectSqlDAO projectSqlDAO = new ProjectSqlDAO(connectionString);
            bool result = projectSqlDAO.AssignEmployeeToProject(2,1);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void RemoveEmployeeFromProjectTest()
        {
            ProjectSqlDAO projectSqlDAO = new ProjectSqlDAO(connectionString);
            bool result = projectSqlDAO.RemoveEmployeeFromProject(1, 1);
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void CreateProjectTest()
        {
            ProjectSqlDAO projectSqlDAO = new ProjectSqlDAO(connectionString);

            Project project = new Project();
            project.Name = "test";
            project.StartDate = DateTime.Parse("2010-03-19");
            project.EndDate = DateTime.Parse("2011-03-19");
            Assert.AreEqual("test", project.Name);
            Assert.AreEqual(DateTime.Parse("2010-03-19"), project.StartDate);
            Assert.AreEqual(DateTime.Parse("2011-03-19"), project.EndDate);


        }
    }
}
