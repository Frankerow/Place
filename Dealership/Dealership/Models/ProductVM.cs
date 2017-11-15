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
        public double Price { get; set; }

        public static bool AddProduct(ProductVM product,TechnicalDataVM technicalDataVM)
        {
            var listprod =new Product();
            listprod.Id = product.Id;
            listprod.Country = product.Country;
            listprod.Mark = product.Mark;
            listprod.Model = product.Model;
            listprod.Presense = product.Presense;
            listprod.Price = product.Price;

            var listte = new TechnicalData();
            listte.Id = technicalDataVM.Id;
            listte.Numbersofdoors = technicalDataVM.Numbersofdoors;
            listte.Numbersofplaces = technicalDataVM.Numbersofplaces;
            listte.EugineType = technicalDataVM.EugineType;
            listte.EugineLocation = technicalDataVM.EugineLocation;
            listte.EugineVolume = technicalDataVM.EugineVolume;
            listte.BodyType = technicalDataVM.BodyType;

           return Repo.repo.AddProduct(listprod,listte);
        }
    }
}