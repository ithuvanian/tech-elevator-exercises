using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercises.Web.Models
{
    public class XOrderedModel
    {
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public int Order { get; set; }

        public string OrderName()
        {
            switch (Order)
            {
                case 1:
                    return $"{FirstName} {MiddleInitial} {LastName}";
                case 2:
                    return $"{FirstName} {LastName}";
                case 3:
                    return $"{LastName}, {FirstName} {MiddleInitial}";
                case 4:
                    return $"{LastName}, {FirstName}";
                default:
                    return "";
            }
            
        }

    }
}