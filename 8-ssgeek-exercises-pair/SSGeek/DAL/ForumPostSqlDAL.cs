using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSGeek.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace SSGeek.DAL
{
    public class ForumPostSqlDAL : IForumPostDAL
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["SSGeek"].ConnectionString;
        private string SqlViewPosts = "SELECT * FROM forum_post ORDER BY post_date DESC";
        private string SqlSubmitPost = @"INSERT INTO forum_post VALUES(@username, @subject, @message, @date)";

        public List<ForumPost> GetAllPosts()
        {
            List<ForumPost> allForumPosts = new List<ForumPost>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SqlViewPosts, conn);
                    
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            ForumPost f = new ForumPost();
                            f.Id = Convert.ToInt32(reader["id"]);
                            f.Username = Convert.ToString(reader["username"]);
                            f.Subject = Convert.ToString(reader["subject"]);
                            f.Message = Convert.ToString(reader["message"]);
                            f.PostDate = Convert.ToDateTime(reader["post_date"]);
                            allForumPosts.Add(f);
                        }
                    }
                }
                return allForumPosts;
            }
            catch (SqlException)
            {

                throw;
            }
			throw new NotImplementedException();
        }

        public bool SaveNewPost(ForumPost post)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SqlSubmitPost, conn);
                    cmd.Parameters.AddWithValue("@username", post.Username);
                    cmd.Parameters.AddWithValue("@subject", post.Subject);
                    cmd.Parameters.AddWithValue("@message", post.Message);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return (rowsAffected > 0);

                }
            }

            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}

