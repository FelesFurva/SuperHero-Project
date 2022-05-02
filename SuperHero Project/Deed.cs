using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Project
{
    internal class Deed
    {
        public int DistrictID { set; get; }
        public int PeopleAffected { set; get; }
        public int PowerID { set; get; }
        
        public Deed(int districtID, int peopleAffected, int powerID)
        {
            DistrictID = districtID;
            PeopleAffected = peopleAffected;
            PowerID = powerID;
        }


    }
}
