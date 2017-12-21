using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using entities;

namespace Dealership.Models
{
    public class ProductVM
    {

        public Guid Id { get; set; }
        public string Country { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Presense { get; set; }
        public string Price { get; set; }

        public static bool AddProduct(ProductVM product)
        {
            var listprod =new Product();
            listprod.Id = product.Id;
            listprod.Country = product.Country;
            listprod.Mark = product.Mark;
            listprod.Model = product.Model;
            listprod.Presense = product.Presense;
            listprod.Price = product.Price;

           return Repo.repo.AddProduct(listprod);
        }

        public static List<ProductVM> GetAllProduct()
        {
            var list = Repo.repo.GetAllProduct();
            List<ProductVM> list1 = new List<ProductVM>();
            foreach (var item in list)
            {
                if (item != null)
                {
                    list1.Add(new ProductVM()
                    {
                        Id = item.Id,
                        Country = item.Country,
                        Mark = item.Mark,
                        Model = item.Model,
                        Presense = item.Presense,
                        Price = item.Price
                    }
                        );
                }
              
            }
            return list1;


        }

       
    }
}