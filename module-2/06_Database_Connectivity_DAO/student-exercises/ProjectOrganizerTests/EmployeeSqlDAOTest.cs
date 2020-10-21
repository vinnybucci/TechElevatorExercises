using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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
        { }
        [TestCleanup]
        public void Cleanup()
        {
            transaction.Dispose();
        }
        [TestMethod]
        public void GetAllEmployeesTest()
        {

        }
    }
}
