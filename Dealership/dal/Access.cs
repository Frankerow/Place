using interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities;
using System.Data.SqlClient;

namespace dal
{
    public class Access:IDAL
    {


        private string connectionstring;



        public Access()
        {
            connectionstring= ConfigurationManager.ConnectionStrings["Dealership"].ConnectionString;
        }






        public bool AddCustomer(Customers customer, CustomersMoreDetail customersMoreDetail)
        {
            using (SqlConnection connectoin = new SqlConnection(connectionstring))
            {
                string com = "INSERT INTO [dbo].[Customers] (Id,Thename,Adress,Phone) VALUES (@Id,@Thename,@Adress,@Phone)";

                string com1 = "INSERT INTO [dbo].[CustomersMoreDetail] (Id,BytePhoto,Type,IdUser,Description) VALUES (@Id,@BytePhoto,@Type,@IdUser,@Description)";
                SqlCommand comand = new SqlCommand(com, connectoin);
                comand.Parameters.AddWithValue("@Id", customer.Id);
                comand.Parameters.AddWithValue("@Thename", customer.TheName);
                comand.Parameters.AddWithValue("@Adress", customer.Adress);
                comand.Parameters.AddWithValue("@Phone", customer.Phone);


                connectoin.Open();

                return comand.ExecuteNonQuery() == 1;
            }
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
