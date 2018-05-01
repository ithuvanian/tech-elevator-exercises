using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSGeek.Models
{
    public class AlienAgeModel
    {

        public string Planet { get; set; }
        public double EarthAge { get; set; }

        public static List<SelectListItem> Planets { get; } = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Mercury" },
            new SelectListItem() { Text = "Venus" },
            new SelectListItem() { Text = "Mars" },
            new SelectListItem() { Text = "Jupiter" },
            new SelectListItem() { Text = "Saturn" },
            new SelectListItem() { Text = "Neptune" },
            new SelectListItem() { Text = "Uranus" }
        };

        public Dictionary<string, double> planetRatios = new Dictionary<string, double>
        {
            {"Mercury", 365.26 / 87.96 },
            {"Venus", 365.26 / 224.68 },
            {"Mars", 365.26 / 686.98 },
            {"Jupiter", 1 / 11.862 },
            {"Saturn", 1 / 29.456 },
            {"Neptune", 1 / 164.81 },
            {"Uranus", 1 / 84.07 }

        };

        public double CalculateAge()
        {
            foreach (KeyValuePair<string, double> kvp in planetRatios)
            {
                if (kvp.Key == this.Planet)
                {
                    return EarthAge * kvp.Value;
                }
            }
            return EarthAge;
        }
    }




}