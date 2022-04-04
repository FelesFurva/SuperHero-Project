using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Project
{
    internal class SuperVillian : SuperHuman
    {
        public string GoodEvil { get; set; }
        public int CrimeTime { get; set; }
        public int VillainID { get; set; }


        public SuperVillian()
        {

            GoodEvil = "We have yet to see";
            CrimeTime = 0;
            VillainID = 0;

        }

        public SuperVillian(string Name,
                         string Surname,
                         string Nickname,
                         int villainID,
                         char Gender,
                         int Age,
                         string goodEvil,
                         int crimeTime,
                         string Powers1,
                         string Powers2,
                         string Powers3,
                         double Salary,
                         int LVL) : base(Name, Surname, Nickname, Gender, Age, Powers1, Powers2, Powers3, Salary, LVL)
        {

            GoodEvil = goodEvil;
            CrimeTime = crimeTime;
            VillainID = villainID;

        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("   ================================");
            Console.WriteLine($"    VillainID:             {VillainID}");
            Console.WriteLine("   ================================");
            //tells if the hero is evil or not
            Console.WriteLine($"    {Nickname} could have bought the cookies, but chose to steal them instead");
        }

        public void VillianIndeMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine($"1. View {Nickname} villiane card");
            Console.WriteLine($"2. Calculate {Nickname} level");
            Console.WriteLine($"3. Check {Nickname}'s crime rate");
            Console.WriteLine($"4. Delete {Nickname}'s file");
            Console.WriteLine("5. Go back.");
        }

        public void CalculationCrimeTime()
        {
            Console.WriteLine($"Input how many hours {Nickname} spent on task 1:");

            int.TryParse(Console.ReadLine(), out int crimetime1);

            Console.WriteLine($"Input how many hours {Nickname} spent on task 2:"); ;

            int.TryParse(Console.ReadLine(), out int crimetime2);

            Console.WriteLine($"Input how many hours {Nickname} spent on task 3:");

            int.TryParse(Console.ReadLine(), out int crimetime3);

            int TotalCrimeTime = crimetime1 + crimetime2 + crimetime3;

            int avgdeedtime = TotalCrimeTime / 3;

            CrimeTime += TotalCrimeTime;

            Console.WriteLine($"{Nickname} spent {CrimeTime} hours doing crimes");
            Console.WriteLine($"Today, the varage crime rate is: {avgdeedtime} hours");
        }

        public void CalculateVLvl()
        {
            if (CrimeTime <= 20)
            {
                LVL = 1;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"  {Nickname} current level is 1");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
            else if (CrimeTime > 20 && CrimeTime < 40)
            {
                LVL = 2;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"  {Nickname} current hero level is 2");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
            else if (CrimeTime >= 40)
            {
                LVL = 3;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"  {Nickname} current hero level is 3");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
        }
    }
}
