using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using SSGeek.DAL;
using SSGeek.Models;


namespace SSGeek.Controllers
{
    public class HomeController : Controller
    {
        //private string DatabaseConnection = ConfigurationManager.ConnectionStrings["SSGeek"].ConnectionString;

        // GET: Home
        public ActionResult Index()
        {
            if (Session["Shopping_Cart"] == null)
            {
                List<Product> shoppingCart = new List<Product>();
                Session["Shopping_Cart"] = shoppingCart;
            }

            return RedirectToAction("Index", "Planets"); //<-- if user goes to .com/ this redirects to .com/planets/index
        }

        public ActionResult ForumView()
        {
            ForumPostSqlDAL dal = new ForumPostSqlDAL();
            List<ForumPost> allPosts = dal.GetAllPosts();
            return View(allPosts);
        }

        public ActionResult ForumSubmit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ForumView(ForumPost forumPost)
        {
            ForumPostSqlDAL dal = new ForumPostSqlDAL();
            dal.SaveNewPost(forumPost);
            ForumPostSqlDAL newdal = new ForumPostSqlDAL();
            List<ForumPost> allPosts = newdal.GetAllPosts();
            return View("ForumView", allPosts);
        }

        public ActionResult ProductList()
        {
            ProductSqlDAL dal = new ProductSqlDAL();
            List<Product> allProducts = dal.GetProducts();
            return View(allProducts);
        }

        public ActionResult ProductDetail(int id)
        {
            ProductSqlDAL dal = new ProductSqlDAL();
            Product p = dal.GetProduct(id);
            return View(p);
        }

        public ActionResult ShoppingCart()
        {
            List<Product> shoppingCart = Session["Shopping_Cart"] as List<Product>;
            return View(shoppingCart);
        }

        [HttpPost]
        public ActionResult ShoppingCart(Product p)
        {
            List<Product> shoppingCart = Session["Shopping_Cart"] as List<Product>;
            if (p.Qty > 0)
            {
                shoppingCart.Add(p);
                Session["Shopping_Cart"] = shoppingCart;
            }

            return View(shoppingCart);
        }

    }
}