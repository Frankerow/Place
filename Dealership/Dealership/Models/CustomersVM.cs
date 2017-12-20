using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dealership.Models
{
    public class CustomersVM
    {
        public Guid Id { get; set; }
        public string TheName { get; set; }
        public string Adress { get; set; }
        public int Phone { get; set; }
    }
}