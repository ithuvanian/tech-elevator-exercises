﻿using SSGeek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSGeek.Controllers
{
    public class CalculatorsController : Controller
    {
        // INSTRUCTIONS
        // As a part of each exercise you will need to 
        // - develop a view for AlienAge, AlienWeight, and AlienTravel that displays a form to submit data
        // - develop a model for the forms to bind to when the form request is submitted
        // - create a new action to process the form submission (e.g. AlienAgeResult, AlienWeightResult, etc.)
        // - create a view that displays the submitted form result

        // GET: Calculators/AlienAge
        public ActionResult AlienAge()
        {
            return View("AlienAge");
        }

        public ActionResult AlienAgeResult(string planet, double earthAge)
        {
            AlienAgeModel model = new AlienAgeModel()
            {
                Planet = planet,
                EarthAge = earthAge
            };

            return View("AlienAgeResult", model);
        }

        //TODO: Create an AlienWeight and AlienWeightResult Action
        public ActionResult AlienWeight()
        {
            return View("AlienWeight");
        }

        public ActionResult AlienWeightResult(string planet, double earthWeight)
        {
            AlienWeightModel model = new AlienWeightModel()
            {
                Planet = planet,
                EarthWeight = earthWeight
            };

            return View("AlienWeightResult", model);
        }


        //TODO: Create an AlienTravel and AlienTravelResult Action
        public ActionResult AlienTravel()
        {
            return View("AlienTravel");
        }

        public ActionResult AlienTravelResult(string planet, decimal age, string mode)
        {
            AlienTravelModel model = new AlienTravelModel()
            {
                Planet = planet,
                Age = age,
                Mode = mode
            };

            return View("AlienTravelResult", model);
        }

        private List<SelectListItem> transportationModes = new List<SelectListItem>() 
        {
            new SelectListItem() { Text = "Walking", Value="walking" },
            new SelectListItem() { Text = "Car", Value = "car" },
            new SelectListItem() { Text = "Bullet Train", Value = "bullet train" },
            new SelectListItem() { Text = "Boeing 747", Value = "boeing 747" },
            new SelectListItem() { Text = "Concorde", Value = "concorde" }
        };
    }
}



