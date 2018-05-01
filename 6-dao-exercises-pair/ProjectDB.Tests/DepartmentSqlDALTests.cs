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
    public class DepartmentSqlDALTests
    {
        private TransactionScope tran;
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Projects;Integrated Security=True";
        private int numberOfDepartments = 0;

        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd;

                conn.Open();

                cmd = new SqlCommand("SELECT COUNT(*) FROM department;", conn);
                numberOfDepartments = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand("INSERT INTO department (name) VALUES ('Test Department');", conn);
                cmd.ExecuteNonQuery();
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod]
        public void CreateDepartmentTest()
        {
            DepartmentSqlDAL departmentSqldal = new DepartmentSqlDAL(connectionString);

            Department department = new Department
            {
                Name = "Test Department 2"
            };

            bool didWork = departmentSqldal.CreateDepartment(department);

            Assert.AreEqual(true, didWork);
        }

        [TestMethod]
        public void GetDepartmentTest()
        {
            DepartmentSqlDAL departmentSqldal = new DepartmentSqlDAL(connectionString);

            List<Department> departments = departmentSqldal.GetDepartments();

            Assert.AreEqual(numberOfDepartments + 1, departments.Count);
        }

        [TestMethod]
        public void UpdateDepartmentTest()
        {
            DepartmentSqlDAL departmentSqldal = new DepartmentSqlDAL(connectionString);

            List<Department> departments = departmentSqldal.GetDepartments();

            //int testDepartmentID = 0;
            Department testDepartment = new Department();

            foreach(Department thisDepartment in departments)
            {
                if (thisDepartment.Name == "Test Department")
                {
                    testDepartment = thisDepartment;
                }
            }

            testDepartment.Name = "Altered Name";

            bool didUpdate = departmentSqldal.UpdateDepartment(testDepartment);

            Assert.AreEqual(true, didUpdate);

        }
    }
}