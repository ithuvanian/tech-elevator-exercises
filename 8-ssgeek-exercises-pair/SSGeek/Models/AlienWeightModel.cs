using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SSGeek.Models
{
    public class AlienWeightModel
    {
        public string Planet { get; set; }
        public double EarthWeight { get; set; }

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
            {"Mercury", .37 },
            {"Venus", .9 },
            {"Mars", .38 },
            {"Jupiter", 2.65 },
            {"Saturn", 1.13 },
            {"Neptune", 1.43 },
            {"Uranus", 1.09 },

        };

        public double CalculateWeight()
        {
            foreach (KeyValuePair<string, double> kvp in planetRatios)
            {
                if (kvp.Key == this.Planet)
                {
                    return EarthWeight * kvp.Value;
                }
            }
            return EarthWeight;
        }
    }
}