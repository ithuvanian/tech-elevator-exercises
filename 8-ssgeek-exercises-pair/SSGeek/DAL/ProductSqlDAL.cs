using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSGeek.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace SSGeek.DAL
{
    public class ProductSqlDAL : IProductDAL
    {

        public string connectionString = ConfigurationManager.ConnectionStrings["SSGeek"].ConnectionString;
        private string SqlViewProducts = "SELECT * FROM products";
        private string SqlViewProduct = "SELECT * FROM products WHERE product_id = @product_id";

        public List<Product> GetProducts()
        {
            List<Product> allProducts = new List<Product>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SqlViewProducts, conn);

                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Product p = new Product();
                            p.ProductId = Convert.ToInt32(reader["product_id"]);
                            p.Name = Convert.ToString(reader["name"]);
                            p.Description = Convert.ToString(reader["description"]);
                            p.Price = Convert.ToDouble(reader["price"]);
                            p.ImageName = Convert.ToString(reader["image_name"]);

                            allProducts.Add(p);
                        }
                    }
                }
                return allProducts;
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public Product GetProduct(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    Product p = new Product();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SqlViewProduct, conn);
                    cmd.Parameters.AddWithValue("@product_id", id);

                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            p.ProductId = Convert.ToInt32(reader["product_id"]);
                            p.Name = Convert.ToString(reader["name"]);
                            p.Description = Convert.ToString(reader["description"]);
                            p.Price = Convert.ToDouble(reader["price"]);
                            p.ImageName = Convert.ToString(reader["image_name"]);
                        }
                    }
                    return p;
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }


    }
}