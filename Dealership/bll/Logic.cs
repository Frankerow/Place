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

        public bool AddCustomer(Customers customer)
        {
           return dal1.AddCustomer(customer);
        }






        //public bool AddCustomer(Customers customer, CustomersMoreDetail customersMoreDetail)
        //{
        //    return dal1.AddCustomer(customer, customersMoreDetail);
        //}


        public bool AddMoreDetail(CustomersMoreDetail customersMoreDetail)
        {
            return dal1.AddCustomersMoreDetail(customersMoreDetail);
        }

        public bool AddProduct(Product product)
        {
            return dal1.AddProduct(product);
        }

        //public bool AddProduct(Product product)
        //{
        //    return dal1.AddProduct(product);
        //}

        public bool AddTecnicalData(TechnicalData technicalData)
        {
           return dal1.AddTechnicalData(technicalData);
          
        }

        public bool AddPurchase(Purchase purchase)
        {
            throw new NotImplementedException();
        }

        public bool AddTechnicalData(TechnicalData technicalData)
        {
            return dal1.AddTechnicalData(technicalData);
        }

        public bool DeleteCustomer(Guid id)
        {
            throw new NotImplementedException();
        }


        public bool DeleteMoreDetail(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProduct(Guid id)
        {
            throw new NotImplementedException();
        }


        public bool DeletePurchase()
        {
            throw new NotImplementedException();
        }

        public bool DeleteTecnicalData(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Customers> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProduct()
        {
           return dal1.GetAllProduct().ToList();
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

        public TechnicalData GetTechnicalDataById(Guid id)
        {
            return dal1.GetTechnicalDataById(id);
        }
    }
}
