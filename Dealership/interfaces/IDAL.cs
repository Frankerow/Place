using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public interface IDAL 
    {
        bool AddProduct(Guid id,string country,string mark,string model,string presence,double price);
        bool DeleteProduct();
        bool UpdateProduct();
    }
}
