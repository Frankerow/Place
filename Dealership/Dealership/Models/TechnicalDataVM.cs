using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dealership.Models
{
    public class TechnicalDataVM
    {

        public Guid Id { get; set; }
        public string BodyType { get; set; }
        public int Numbersofdoors { get; set; }
        public int Numbersofplaces { get; set; }
        public string EugineType { get; set; }
        public string EugineLocation { get; set; }
        public string EugineVolume { get; set; }
    }
}