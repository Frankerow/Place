using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
   public class Purchase
    {
        public Guid Id { get; set; }
        public Guid IdCustomer { get; set; }
        public Guid IdProduct { get; set; }
        public string Shipping { get; set; }
        public string PaymentType { get; set; }

        public Purchase()
        {

        }

        public Purchase(Guid id,Guid idcustomer,Guid idproduct,string shipping,string paymenttype)
        {
            this.Id = id;
            this.IdCustomer = idcustomer;
            this.IdProduct = idproduct;
            this.Shipping = shipping;
            this.PaymentType = paymenttype;
        }
    }
}
