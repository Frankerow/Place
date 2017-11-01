using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
   public class TechnicalData
    {
        public Guid Id { get; set; }
        public string BodyType { get; set; }
        public int Numbersofdoors { get; set; }
        public int Numbersofplaces { get; set; }
        public string EugineType { get; set; }
        public string EugineLocation { get; set; }
        public string EugineVolume { get; set; }

        public TechnicalData()
        {

        }

        public TechnicalData(Guid id,string bodytype,int numberofdoors,int numberofplaces,string euginetype,string euginelocation,string euginevolume)
        {
            this.Id = id;
            this.BodyType = bodytype;
            this.Numbersofdoors = numberofdoors;
            this.Numbersofplaces = numberofplaces;
            this.EugineType = euginetype;
            this.EugineLocation = euginelocation;
            this.EugineVolume = euginevolume;
        }
    }
}
