using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
   public class Product
    {
        public Guid Id { get; set; }
        public string Country { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Presense { get; set; }
        public string Price { get; set; }

        public Product()
        {

        }

        public Product(Guid id,string country,string mark,string model,string presense,string price)
        {
            this.Id = id;
            this.Country = country;
            this.Mark = mark;
            this.Model = model;
            this.Presense = presense;
            this.Price = price;
        }

    }
}
