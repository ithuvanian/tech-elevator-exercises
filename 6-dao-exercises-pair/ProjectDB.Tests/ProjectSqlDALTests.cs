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
    public class ProjectSqlDALTests
    {
        private TransactionScope tran;
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Projects;Integrated Security=True";
        private int numberOfProjects = 0;

        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd;

                conn.Open();

                cmd = new SqlCommand("SELECT COUNT(*) FROM project;", conn);
                numberOfProjects = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand("INSERT INTO department (name) VALUES ('Test Project'); SELECT CAST(SCOPE_IDENTITY() as int);", conn);
                cmd.ExecuteNonQuery();
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod]
        public void GetAllProjectsTest()
        {
            ProjectSqlDAL projectSqldal = new ProjectSqlDAL(connectionString);

            List<Project> projects = projectSqldal.GetAllProjects();

            Assert.AreEqual(numberOfProjects, projects.Count);
        }

        [TestMethod]
        public void AssignEmployeeToProjectTest()
        {
            ProjectSqlDAL projectSqldal = new ProjectSqlDAL(connectionString);

            bool didWork = projectSqldal.AssignEmployeeToProject(1, 4);

            Assert.AreEqual(true, didWork);
        }

        [TestMethod]
        public void RemoveEmployeeFromProjectTest()
        {
            ProjectSqlDAL projectSqldal = new ProjectSqlDAL(connectionString);

            bool didRemove = projectSqldal.RemoveEmployeeFromProject(1, 3);

            Assert.AreEqual(true, didRemove);
        }

        [TestMethod]
        public void CreateProjectTest()
        {
            ProjectSqlDAL projectSqldal = new ProjectSqlDAL(connectionString);

            Project project = new Project();
            project.Name = "TestProject";
            project.StartDate = DateTime.Parse("2018/02/21");
            project.EndDate = DateTime.Parse("2018/02/22");

            bool didWork = projectSqldal.CreateProject(project);

            Assert.AreEqual(true, didWork);
        }
    }
}
