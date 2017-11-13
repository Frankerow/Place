using interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities;

namespace bll
{
    public class Logic : IBLL
    {
        dal.Access dal1;


        public Logic()
        {

            dal1 = new dal.Access(); 

        }






        public bool AddCustomer(Customers customer, CustomersMoreDetail customersMoreDetail)
        {
            return dal1.AddCustomer(customer, customersMoreDetail);
        }

        public bool AddProduct(Product product, TechnicalData technical)
        {
            throw new NotImplementedException();
        }

        public bool AddPurchase(Purchase purchase)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer()
        {
            throw new NotImplementedException();
        }

        public bool DeleteProduct()
        {
            throw new NotImplementedException();
        }

        public bool DeletePurchase()
        {
            throw new NotImplementedException();
        }

        public List<Customers> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public Product GetOneProduct(string mark, string model)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer()
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct()
        {
            throw new NotImplementedException();
        }

        public bool UpdatePurchase()
        {
            throw new NotImplementedException();
        }
    }
}
