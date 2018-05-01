using ProjectDB.Models;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ProjectDB.DAL
{
    public class DepartmentSqlDAL
    {
        private string connectionString;



        /// Single Parameter Constructor
        public DepartmentSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }


        public List<Department> GetDepartments()
        {
            List<Department> output = new List<Department>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM department", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Department d = new Department();
                        d.Id = Convert.ToInt32(reader["department_id"]);
                        d.Name = Convert.ToString(reader["name"]);

                        output.Add(d);
                    }
                }
            }

            catch(Exception ex)
            {
                throw new NotImplementedException();
            }
            return output;
        }


        public bool CreateDepartment(Department newDepartment)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT into department (name) VALUES (@departmentName);", conn);
                    cmd.Parameters.AddWithValue("@departmentName", newDepartment.Name);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }


        public bool UpdateDepartment(Department updatedDepartment)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($"UPDATE department SET name = '{updatedDepartment.Name}' WHERE department_id = {updatedDepartment.Id};", conn);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
