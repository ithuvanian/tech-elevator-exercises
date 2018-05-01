using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercises.Web.Models;

namespace Exercises.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult XOrderedName()
        {
            return View();
        }

        public ActionResult XOrderedResult(string firstName, string middleInitial, string lastName, int order)
        {
            XOrderedModel model = new XOrderedModel()
            {
                FirstName = firstName,
                MiddleInitial = middleInitial,
                LastName = lastName,
                Order = order
            };

            return View("XOrderedResult", model);
        }

        public ActionResult ColorizedName()
        {
            return View();
        }

        public ActionResult ColorizedResult(string firstName, string lastName, bool red, bool blue, bool green)
        {
            ColorizedModel model = new ColorizedModel()
            {
                FirstName = firstName,
                LastName = lastName,
                Red = red,
                Blue = blue,
                Green = green
            };

            return View("ColorizedResult", model);
        }

        public ActionResult FizzBuzzRevisited()
        {
            return View();
        }

        public ActionResult FizzBuzzRevResult(int divA, int divB, string altFizz, string altBuzz, int intA, int intB, int intC, int intD, int intE)
        {
            FizzBuzzRevModel model = new FizzBuzzRevModel()
            {
                DivA = divA,
                DivB = divB,
                AltFizz = altFizz,
                AltBuzz = altBuzz,
                IntA = intA,
                IntB = intB,
                IntC = intC,
                IntD = intD,
                IntE = intE
            };

            return View("FizzBuzzRevResult", model);
        }

        public ActionResult LastTwo()
        {
            return View();
        }

        public ActionResult LastTwoResult(string wordA, string wordB, string wordC, string wordD, string wordE, string wordF, string wordG, string wordH, string wordI, string wordJ)
        {
            LastTwoModel model = new LastTwoModel()
            {
                WordA = wordA,
                WordB = wordB,
                WordC = wordC,
                WordD = wordD,
                WordE = wordE,
                WordF = wordF,
                WordG = wordG,
                WordH = wordH,
                WordI = wordI,
                WordJ = wordJ
            };

            return View("LastTwoResult", model);
        }

        public ActionResult BabyLotto()
        {
            return View();
        }
    
        public ActionResult BabyLottoResult(string ticketA, string ticketB, string ticketC, string ticketD, string ticketE)
        {
            BabyLottoModel model = new BabyLottoModel()
            {
                TicketA = ticketA,
                TicketB = ticketB,
                TicketC = ticketC,
                TicketD = ticketD,
                TicketE = ticketE
            }; 

            return View("BabyLottoResult", model);
        }

        public ActionResult SquirrelCigarParty()
        {
            return View();
        }

        public ActionResult SquirrelResult()
        {
            return View();
        }
    }
}