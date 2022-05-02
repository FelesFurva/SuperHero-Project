using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Project
{
    public class SuperPowers
    {
        public int PowerID { get; set; }
        public string PowerName { get; set; }
        public string PowerDescription { get; set; }
        public int PersonID { get; set; }

        public SuperPowers(int powerID, string powerName, string powerDescription, int personID)
        {
            PowerID = powerID;
            PowerName = powerName;
            PowerDescription = powerDescription;
            PersonID = personID;
        }


    }
}
