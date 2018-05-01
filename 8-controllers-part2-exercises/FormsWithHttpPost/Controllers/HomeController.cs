using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using FormsWithHttpPost.DAL;
using FormsWithHttpPost.Models;


namespace FormsWithHttpPost.Controllers
{
    public class HomeController : Controller
    {
        string connectionString = ConfigurationManager.ConnectionStrings["squirrelReviews"].ConnectionString;


        // GET: Home
        public ActionResult Index()
        {
            ReviewSqlDAL dalA = new ReviewSqlDAL();
            List<Review> allReviews = dalA.GetAllReviews();
            return View(allReviews);
        }

        public ActionResult SubmitReview()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitReview(Review newReview)
        {
            ReviewSqlDAL dalB = new ReviewSqlDAL();
            dalB.SaveReview(newReview);

            return RedirectToAction("Index", "Home");
        }


    }
}