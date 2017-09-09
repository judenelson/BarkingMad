using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BarkingMad_Identity.Models
{
    public class Vet
    {
        public int VetId { get; set; }
        public string VetName { get; set; }
        public string PracticeName { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
        public string PhoneNumber { get; set; }


    }
}