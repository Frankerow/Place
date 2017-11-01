using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
   public class CustomersMoreDetail
    {
        public Guid Id { get; set; }
        public int PassportSerius { get; set; }
        public int PassportNumber { get; set; }

        public CustomersMoreDetail()
        {

        }

        public CustomersMoreDetail(Guid id,int serius,int number)
        {
            this.Id = id;
            this.PassportSerius = serius;
            this.PassportNumber = number;
        }
    }
}
