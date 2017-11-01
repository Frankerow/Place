using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    public class Customers
    {
        public Guid Id { get; set; }
        public string TheName { get; set; }
        public string Adress { get; set; }
        public int Phone { get; set; }

        public Customers()
        {

        }

        public Customers(Guid id,string thename,string adress,int phone)
        {
            this.Id = id;
            this.TheName = thename;
            this.Adress = adress;
            this.Phone = phone;
        }
    }
}
