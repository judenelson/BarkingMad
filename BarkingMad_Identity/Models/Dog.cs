using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BarkingMad_Identity.Models
{
    public class Dog
    {
        public int DogId { get; set; }
        public string DogName { get; set; }
        public DateTime DOB { get; set; }
        public string Breed { get; set; }
        public decimal Weight { get; set; }
        public string Sociability { get; set; }
        public string GeneralHealth { get; set; }
        public string DietaryRestrictions { get; set; }
        public bool IsLeadTrained { get; set; }

    }
}