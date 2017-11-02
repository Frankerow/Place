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
        bool AddProduct(Product product,TechnicalData technical);
        bool DeleteProduct();
        bool UpdateProduct();
        Product GetOneProduct(string mark, string model);
        List <Product> GetAllProduct();

        bool AddCustomer(Customers customer,CustomersMoreDetail customersMoreDetail);
        bool DeleteCustomer();
        bool UpdateCustomer();
        List<Customers> GetAllCustomers();

        bool AddPurchase(Purchase purchase);
        bool DeletePurchase();
        bool UpdatePurchase();







    }
}
