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

                string com1 = "INSERT INTO [dbo].[Customers_More_Detail] (Id,PassportSerius,PassportNumber) VALUES (@Id,@PassportSerius,@PassportNumber)";
                SqlCommand comand = new SqlCommand(com, connectoin);
                comand.Parameters.AddWithValue("@Id", customer.Id);
                comand.Parameters.AddWithValue("@Thename", customer.TheName);
                comand.Parameters.AddWithValue("@Adress", customer.Adress);
                comand.Parameters.AddWithValue("@Phone", customer.Phone);

                SqlCommand comand1 = new SqlCommand(com1, connectoin);
                comand1.Parameters.AddWithValue("@Id", customersMoreDetail.Id);
                comand1.Parameters.AddWithValue("@PassportSerius", customersMoreDetail.PassportNumber);
                comand1.Parameters.AddWithValue("@PassportNumber", customersMoreDetail.PassportSerius);


                connectoin.Open();

                return comand.ExecuteNonQuery() == 1;
            }
        }

        public bool AddProduct(Product product, TechnicalData technical)
        {
            using (SqlConnection connectoin = new SqlConnection(connectionstring))
            {
                string com = "INSERT INTO [dbo].[Product] (Id,Country,Mark,Model,Presense,Price) VALUES (@Id,@Country,@Mark,@Model,@Presense,@Price)";

                string com1 = "INSERT INTO [dbo].[Technical_Data] (Id,Bodytype,Numberofdoors,Numberofplaces,Euginetype,Euginelocation,Euginevolume) VALUES (@Id,@Bodytype,@Numberofdoors,@Numberofplaces,@Euginetype,@Euginelocation,@Euginevolume)";
                SqlCommand comand = new SqlCommand(com, connectoin);
                comand.Parameters.AddWithValue("@Id", product.Id);
                comand.Parameters.AddWithValue("@Country", product.Country);
                comand.Parameters.AddWithValue("@Mark", product.Mark);
                comand.Parameters.AddWithValue("@Model", product.Model);
                comand.Parameters.AddWithValue("@Presense", product.Presense);
                comand.Parameters.AddWithValue("@Price", product.Price);

                SqlCommand comand1 = new SqlCommand(com1, connectoin);
                comand1.Parameters.AddWithValue("@Id", technical.Id);
                comand1.Parameters.AddWithValue("@Bodytype", technical.BodyType);
                comand1.Parameters.AddWithValue("@Numberofdoors", technical.Numbersofdoors);
                comand1.Parameters.AddWithValue("@Numberofplaces", technical.Numbersofplaces);
                comand1.Parameters.AddWithValue("@Euginetype", technical.EugineType);
                comand1.Parameters.AddWithValue("@Euginelocation", technical.EugineLocation);
                comand1.Parameters.AddWithValue("@Euginevolume", technical.EugineVolume);


                connectoin.Open();

                return comand.ExecuteNonQuery() == 1;
            }
        }

        public bool AddPurchase(Purchase purchase)
        {
            //using (SqlConnection connectoin = new SqlConnection(connectionstring))
            //{
            //    string com = "INSERT INTO [dbo].[Purchase] (Id,Thename,Adress,Phone) VALUES (@Id,@Thename,@Adress,@Phone)";

            //    string com1 = "INSERT INTO [dbo].[Customers_More_Detail] (Id,PassportSerius,PassportNumber) VALUES (@Id,@PassportSerius,@PassportNumber)";
            //    SqlCommand comand = new SqlCommand(com, connectoin);
            //    comand.Parameters.AddWithValue("@Id", customer.Id);
            //    comand.Parameters.AddWithValue("@Thename", customer.TheName);
            //    comand.Parameters.AddWithValue("@Adress", customer.Adress);
            //    comand.Parameters.AddWithValue("@Phone", customer.Phone);

            //    SqlCommand comand1 = new SqlCommand(com1, connectoin);
            //    comand1.Parameters.AddWithValue("@Id", customersMoreDetail.Id);
            //    comand1.Parameters.AddWithValue("@PassportSerius", customersMoreDetail.PassportNumber);
            //    comand1.Parameters.AddWithValue("@PassportNumber", customersMoreDetail.PassportSerius);


            //    connectoin.Open();

            //    return comand.ExecuteNonQuery() == 1;
            //}
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
