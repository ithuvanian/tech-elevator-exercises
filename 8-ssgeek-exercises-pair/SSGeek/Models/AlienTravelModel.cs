using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SSGeek.Models
{
    public class AlienTravelModel
    {
        public decimal Age { get; set; }
        public string Planet { get; set; }
        public string Mode { get; set; }

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

        public static List<SelectListItem> ModeList { get; } = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "walking" },
            new SelectListItem() { Text = "car" },
            new SelectListItem() { Text = "bullet train" },
            new SelectListItem() { Text = "Boeing 747" },
            new SelectListItem() { Text = "Concorde" },

        };

        public static Dictionary<string, int> mode = new Dictionary<string, int>
        {
            { "walking", 3 },
            { "car", 100 },
            { "bullet train", 200 },
            { "Boeing 747", 570 },
            { "Concorde", 1350 }
        };

        public static Dictionary<string, decimal> distance = new Dictionary<string, decimal>
        {
            { "Mercury", 56974146 },
            { "Venus", 25724767 },
            { "Mars", 48678219 },
            { "Jupiter", 390674710 },
            { "Saturn", 792248270 },
            { "Uranus", 1692662530 },
            { "Neptune", 2703959960 }
        };

        public decimal getYearsOfTravel()
        {
            decimal daysOfTravel = (distance[this.Planet] / mode[this.Mode]);
            return daysOfTravel / 365.26M;
        }

    }
}