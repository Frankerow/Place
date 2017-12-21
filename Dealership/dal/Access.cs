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






        //public bool AddCustomer(Customers customer, CustomersMoreDetail customersMoreDetail)
        //{
        //    using (SqlConnection connectoin = new SqlConnection(connectionstring))
        //    {
        //        string com = "INSERT INTO [dbo].[Customers] (Id,Thename,Adress,Phone) VALUES (@Id,@Thename,@Adress,@Phone)";

        //        string com1 = "INSERT INTO [dbo].[Customers_More_Detail] (Id,PassportSerius,PassportNumber) VALUES (@Id,@PassportSerius,@PassportNumber)";
        //        SqlCommand comand = new SqlCommand(com, connectoin);
        //        comand.Parameters.AddWithValue("@Id", customer.Id);
        //        comand.Parameters.AddWithValue("@Thename", customer.TheName);
        //        comand.Parameters.AddWithValue("@Adress", customer.Adress);
        //        comand.Parameters.AddWithValue("@Phone", customer.Phone);

        //        SqlCommand comand1 = new SqlCommand(com1, connectoin);
        //        comand1.Parameters.AddWithValue("@Id", customersMoreDetail.Id);
        //        comand1.Parameters.AddWithValue("@PassportSerius", customersMoreDetail.PassportNumber);
        //        comand1.Parameters.AddWithValue("@PassportNumber", customersMoreDetail.PassportSerius);


        //        connectoin.Open();

        //        return comand.ExecuteNonQuery() == 1;
        //    }
        //}

        public bool AddCustomer(Customers customer)
        {
            using (SqlConnection connectoin = new SqlConnection(connectionstring))
            {
                string com = "INSERT INTO [dbo].[Customers] (Id,Thename,Adress,Phone) VALUES (@Id,@Thename,@Adress,@Phone)";
                SqlCommand comand = new SqlCommand(com, connectoin);
                comand.Parameters.AddWithValue("@Id", customer.Id);
                comand.Parameters.AddWithValue("@Thename", customer.TheName);
                comand.Parameters.AddWithValue("@Adress", customer.Adress);
                comand.Parameters.AddWithValue("@Phone", customer.Phone);
                connectoin.Open();

                return comand.ExecuteNonQuery() == 1;
            }
        }

        public bool AddCustomersMoreDetail(CustomersMoreDetail customersMoreDetail)
        {
                using (SqlConnection connectoin = new SqlConnection(connectionstring))
                {


                    string com1 = "INSERT INTO [dbo].[Customers_More_Detail] (Id,PassportSerius,PassportNumber) VALUES (@Id,@PassportSerius,@PassportNumber)";
                    SqlCommand comand1 = new SqlCommand(com1, connectoin);
                    comand1.Parameters.AddWithValue("@Id", customersMoreDetail.Id);
                    comand1.Parameters.AddWithValue("@PassportSerius", customersMoreDetail.PassportNumber);
                    comand1.Parameters.AddWithValue("@PassportNumber", customersMoreDetail.PassportSerius);


                    connectoin.Open();

                    return comand1.ExecuteNonQuery() == 1;
                }
                }

        public bool AddProduct(Product product)
        {
            using (SqlConnection connectoin = new SqlConnection(connectionstring))
            {
                string com = "INSERT INTO [dbo].[Product] (Id,Country,Mark,Model,Presense,Price) VALUES (@Id,@Country,@Mark,@Model,@Presense,@Price)";

               
                SqlCommand comand = new SqlCommand(com, connectoin);
                comand.Parameters.AddWithValue("@Id", product.Id);
                comand.Parameters.AddWithValue("@Country", product.Country);
                comand.Parameters.AddWithValue("@Mark", product.Mark);
                comand.Parameters.AddWithValue("@Model", product.Model);
                comand.Parameters.AddWithValue("@Presense", product.Presense);
                comand.Parameters.AddWithValue("@Price", product.Price);




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

        public bool AddTechnicalData(TechnicalData technicalData)
        {
            using (SqlConnection connectoin = new SqlConnection(connectionstring))
            {

                string com1 = "INSERT INTO [dbo].[Technical_Data] (Id,Bodytype,Numbersofdoors,Numbersofplaces,Euginetype,Euginelocation,Euginevolume) VALUES (@Id,@Bodytype,@Numbersofdoors,@Numbersofplaces,@Euginetype,@Euginelocation,@Euginevolume)";
                SqlCommand comand1 = new SqlCommand(com1, connectoin);
                comand1.Parameters.AddWithValue("@Id", technicalData.Id);
                comand1.Parameters.AddWithValue("@Bodytype", technicalData.BodyType);
                comand1.Parameters.AddWithValue("@Numbersofdoors", technicalData.Numbersofdoors);
                comand1.Parameters.AddWithValue("@Numbersofplaces", technicalData.Numbersofplaces);
                comand1.Parameters.AddWithValue("@Euginetype", technicalData.EugineType);
                comand1.Parameters.AddWithValue("@Euginelocation", technicalData.EugineLocation);
                comand1.Parameters.AddWithValue("@Euginevolume", technicalData.EugineVolume);

                connectoin.Open();

                return comand1.ExecuteNonQuery() == 1;
            }

        }


        public bool DeleteCustomer(Guid id)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string com1 = "DELETE FROM [dbo].[Customer] WHERE [Id]=@Id";

                SqlCommand comand1 = new SqlCommand(com1, connection);
                comand1.Parameters.AddWithValue("@Id", id);
                connection.Open();
                return comand1.ExecuteNonQuery() == 1;
            }
        }

        public bool DeleteCustomerMoreDetail(Guid id)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string com1 = "DELETE FROM [dbo].[Customer] WHERE [Id]=@Id";

                SqlCommand comand1 = new SqlCommand(com1, connection);
                comand1.Parameters.AddWithValue("@Id", id);
                connection.Open();
                return comand1.ExecuteNonQuery() == 1;
            }
        }

        public bool DeleteProduct(Guid id)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string com1 = "DELETE FROM [dbo].[Product] WHERE [Id]=@Id";

                SqlCommand comand1 = new SqlCommand(com1, connection);
                comand1.Parameters.AddWithValue("@Id", id);
                connection.Open();
                return comand1.ExecuteNonQuery() == 1;
            }
        }

        public bool DeletePurchase()
        {
            throw new NotImplementedException();
        }

        public bool DeleteTechnicalData(Guid id)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string com1 = "DELETE FROM [dbo].[TechnicalData] WHERE [Id]=@Id";

                SqlCommand comand1 = new SqlCommand(com1, connection);
                comand1.Parameters.AddWithValue("@Id", id);
                connection.Open();
                return comand1.ExecuteNonQuery() == 1;
            }
        }

        public List<Customers> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProduct()
        {
            using (SqlConnection connect = new SqlConnection(connectionstring))
            {
                string comand = "SELECT [ID],[Country],[Mark],[Model],[Presense],[Price] FROM [dbo].[Product]";
                SqlCommand com = new SqlCommand(comand, connect);
                connect.Open();
                var reader = com.ExecuteReader();
                while (reader.Read())
                {
                    yield return new Product()
                    {
                        Id = (Guid)reader["ID"],
                        Country = (string)reader["Country"],
                        Mark = (string)reader["Mark"],
                        Model = (string)reader["Model"],
                        Presense = (string)reader["Presense"],
                        Price = (string)reader["Price"]
                    };
                }
                yield return null;
            }
        }

        public Product GetOneProduct(string mark, string model)
        {
            throw new NotImplementedException();
        }

        public TechnicalData GetTechnicalDataById(Guid id)
        {
            using (SqlConnection connect = new SqlConnection(connectionstring))
            {
                string comand = "SELECT [Id],[Bodytype],[Numbersofdoors],[Numbersofplaces],[Euginetype],[Euginelocation],[Euginevolume] FROM [dbo].[TechnicalData] WHERE [ID]=@Id";
                SqlCommand com = new SqlCommand(comand, connect);
                connect.Open();
                var reader = com.ExecuteReader();
                while (reader.Read())
                {
                     return new TechnicalData()
                    {
                        Id = (Guid)reader["ID"],
                        BodyType = (string)reader["Bodytype"],
                        Numbersofdoors = (int)reader["Numbersofdoors"],
                        Numbersofplaces = (int)reader["Numbersofplaces"],
                        EugineType = (string)reader["Euginetype"],
                        EugineLocation = (string)reader["Euginelocation"],
                        EugineVolume = (string)reader["Euginevolume"]
                     };
                }
                 return null;
            }
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
