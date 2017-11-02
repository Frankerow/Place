using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public interface IDAL 
    {
        bool AddProduct(Guid id,string country,string mark,string model,string presence,double price, string bodytype, int numberofdoors, int numberofplaces, string euginetype, string euginelocation, string euginevolume);
        bool DeleteProduct();
        bool UpdateProduct();
        Product GetOneProduct(Guid id, string country, string mark, string model, string presence, double price);
        List <Product> GetAllProduct();

        bool AddCustomer(Guid id, string thename, string adress, int phone, int serius, int number);
        bool DeleteCustomer();
        bool UpdateCustomer();
        List<Customers> GetAllCustomers();







    }
}
