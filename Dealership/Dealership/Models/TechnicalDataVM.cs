using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dealership.Models;

namespace Dealership.Models
{
    public class TechnicalDataVM
    {

        public Guid Id { get; set; }
        public string BodyType { get; set; }
        public int Numbersofdoors { get; set; }
        public int Numbersofplaces { get; set; }
        public string EugineType { get; set; }
        public string EugineLocation { get; set; }
        public string EugineVolume { get; set; }

        public static bool AddTechnicalData(TechnicalDataVM technicalDataVM)
        {
            var listte = new TechnicalData();
            listte.Id = technicalDataVM.Id;
            listte.Numbersofdoors = technicalDataVM.Numbersofdoors;
            listte.Numbersofplaces = technicalDataVM.Numbersofplaces;
            listte.EugineType = technicalDataVM.EugineType;
            listte.EugineLocation = technicalDataVM.EugineLocation;
            listte.EugineVolume = technicalDataVM.EugineVolume;
            listte.BodyType = technicalDataVM.BodyType;

           return Repo.repo.AddTechnicalData(listte);
        }

        public static TechnicalDataVM GetTechnicalDataById(Guid id)
        {
            var data = Repo.repo.GetTechnicalDataById(id);
            TechnicalDataVM teh = new TechnicalDataVM()
            {
                Id=data.Id,
                BodyType=data.BodyType,
                EugineLocation=data.EugineLocation,
                EugineType=data.EugineType,
                EugineVolume=data.EugineVolume,
                Numbersofdoors=data.Numbersofdoors,
                Numbersofplaces=data.Numbersofplaces
            }
                ;

            return teh;
        }
    }
}