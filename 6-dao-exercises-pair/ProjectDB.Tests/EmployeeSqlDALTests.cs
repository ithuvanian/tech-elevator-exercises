using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.Transactions;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;
using ProjectDB.Models;


namespace ProjectDB.DAL.Tests
{
    [TestClass()]
    public class EmployeeSqlDALTests
    {
        private TransactionScope tran;
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Projects;Integrated Security=True";
        private int numberOfEmployees = 0;

        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd;

                conn.Open();

                cmd = new SqlCommand("SELECT COUNT(*) FROM employee;", conn);
                numberOfEmployees = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand("INSERT INTO department (name) VALUES ('Test Employee'); SELECT CAST(SCOPE_IDENTITY() as int);", conn);
                cmd.ExecuteNonQuery();
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod]
        public void GetAllEmployeesTest()
        {
            EmployeeSqlDAL employeeSqldal = new EmployeeSqlDAL(connectionString);

            List<Employee> employees = employeeSqldal.GetAllEmployees();

            Assert.AreEqual(numberOfEmployees, employees.Count);
        }

        [TestMethod]
        public void SearchTest()
        {
            EmployeeSqlDAL employeeSqldal = new EmployeeSqlDAL(connectionString);

            List<Employee> employees = employeeSqldal.Search("Flo", "Henderson");

            Assert.AreEqual(1, employees.Count);
        }

        [TestMethod]
        public void GetEmployeesWithoutProjectsTest()
        {
            EmployeeSqlDAL employeeSqlDAL = new EmployeeSqlDAL(connectionString);

            List<Employee> employees = employeeSqlDAL.GetEmployeesWithoutProjects();

            Assert.AreEqual(2, employees.Count);
        }
    }
}
