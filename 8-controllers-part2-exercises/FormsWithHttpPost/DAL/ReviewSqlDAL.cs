using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using FormsWithHttpPost.Models;

namespace FormsWithHttpPost.DAL
{
    public class ReviewSqlDAL : IReviewDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["squirrelReviews"].ConnectionString;

        string SqlViewReviews = "SELECT * FROM reviews ORDER BY review_date DESC";

        public List<Review> GetAllReviews()
        {
            List<Review> allReviews = new List<Review>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SqlViewReviews, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Review r = new Review();
                        r.Id = Convert.ToInt32(reader["review_id"]);
                        r.Username = Convert.ToString(reader["username"]);
                        r.Rating = Convert.ToInt32(reader["rating"]);
                        r.Title = Convert.ToString(reader["review_title"]);
                        r.Message = Convert.ToString(reader["review_text"]);
                        r.ReviewDate = Convert.ToDateTime(reader["review_date"]);

                        allReviews.Add(r);
                    }

                }
            }
            catch
            {
                throw new NotImplementedException();
            }
            return allReviews;
        }


        string SqlPostReview = "INSERT INTO reviews VALUES (@username, @rating, @review_title, @review_text, @date)";

        public bool SaveReview(Review newReview)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SqlPostReview, conn);
                    cmd.Parameters.AddWithValue("@username", newReview.Username);
                    cmd.Parameters.AddWithValue("@rating",newReview.Rating);
                    cmd.Parameters.AddWithValue("@review_title", newReview.Title);
                    cmd.Parameters.AddWithValue("@review_text", newReview.Message);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);

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