using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
   public interface IBLL
    {
        bool AddProduct(Product product);
        bool AddTecnicalData(TechnicalData technicalData);
        bool DeleteProduct(Guid id);
        bool DeleteTecnicalData(Guid id);
        bool UpdateProduct();
        Product GetOneProduct(string mark, string model);
        List<Product> GetAllProduct();

        bool AddCustomer(Customers customer);
        bool AddMoreDetail(CustomersMoreDetail customersMoreDetail);
        bool DeleteCustomer(Guid id);
        bool DeleteMoreDetail(Guid id);
        bool UpdateCustomer();
        List<Customers> GetAllCustomers();

        bool AddPurchase(Purchase purchase);
        bool DeletePurchase();
        bool UpdatePurchase();
        bool AddTechnicalData(TechnicalData technicalData);
        TechnicalData GetTechnicalDataById(Guid id);
    }
}
