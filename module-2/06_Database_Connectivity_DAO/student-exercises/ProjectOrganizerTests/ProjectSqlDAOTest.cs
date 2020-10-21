using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace ProjectOrganizerTests
{
    [TestClass]

    public class ProjectSqlDAOTest
    {
        private TransactionScope transaction { get; set; }
        private string connectionString = @"Data Source =.\SQLEXPRESS; Initial Catalog = EmployeeDB; Integrated Security = True";
        private string departmentCodeToTest = "Store Support";

        [TestInitialize]
        public void Initialize()
        { }
        [TestCleanup]
        public void Cleanup()
        {
            transaction.Dispose();
        }
        [TestMethod]
        public void GetAllProjectsTest()
        {

        }
    }
}
