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
        bool AddProduct(Product product);
        bool DeleteProduct(Guid id);
        bool DeleteTechnicalData(Guid id);
        bool UpdateProduct();
        Product GetOneProduct(string mark, string model);
        IEnumerable<Product> GetAllProduct();

        bool AddCustomer(Customers customer);
        bool AddCustomersMoreDetail(CustomersMoreDetail customersMoreDetail);
        bool DeleteCustomer(Guid id);
        bool DeleteCustomerMoreDetail(Guid id);
        bool UpdateCustomer();
        List<Customers> GetAllCustomers();

        bool AddPurchase(Purchase purchase);
        bool DeletePurchase();
        bool UpdatePurchase();
        bool AddTechnicalData(TechnicalData technicalData);
        TechnicalData GetTechnicalDataById(Guid id);







    }
}
