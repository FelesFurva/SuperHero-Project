using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Project
{
    internal class Villian : Person
    {
        public int CrimeCount { get; set; }
        public int VillainID { get; set; }


        public Villian()
        {

            VillainID = 0;

        }

        public Villian(string Name,
                         string Surname,
                         string Nickname,
                         int villainID,
                         int Age,
                         double Salary,
                         int LVL,
                         string PersonType) : base(Name, Surname, Nickname, Age, Salary, LVL, PersonType)
        {

            VillainID = villainID;

        }

        public override void PrintHeroInfo()
        {
            base.PrintHeroInfo();
            Console.WriteLine("   ================================");
            Console.WriteLine($"    VillainID:             {VillainID}");
            Console.WriteLine("   ================================");
            //tells if the hero is evil or not
            Console.WriteLine($"    {PersonNickname} could have bought the cookies, but chose to steal them instead");
        }

        public void VillianIndeMenu()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("What would you like to do?\n");
            Console.WriteLine($"1. View {PersonNickname} villiane card");
            Console.WriteLine($"2. Calculate {PersonNickname} level");
            Console.WriteLine($"3. Check {PersonNickname}'s crime rate");
            Console.WriteLine($"4. Delete {PersonNickname}'s file");
            Console.WriteLine("5. Go back to Villain list");
            Console.WriteLine("6. Go back to main menu");
        }

        public void CalculationCrimeTime()
        {
            Console.WriteLine($"Input how many hours {PersonNickname} spent on task 1:");

            int.TryParse(Console.ReadLine(), out int crimetime1);

            Console.WriteLine($"Input how many hours {PersonNickname} spent on task 2:"); ;

            int.TryParse(Console.ReadLine(), out int crimetime2);

            Console.WriteLine($"Input how many hours {PersonNickname} spent on task 3:");

            int.TryParse(Console.ReadLine(), out int crimetime3);

            int TotalCrimeTime = crimetime1 + crimetime2 + crimetime3;

            int avgdeedtime = TotalCrimeTime / 3;

            CrimeCount += TotalCrimeTime;

            Console.WriteLine($"{PersonNickname} spent {CrimeCount} hours doing crimes");
            Console.WriteLine($"Today, the varage crime rate is: {avgdeedtime} hours");
        }

        public void CalculateVillainLvl()
        {
            if (CrimeCount <= 20)
            {
                PersonLVL = 1;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"  {PersonNickname} current level is 1");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
            else if (CrimeCount > 20 && CrimeCount < 40)
            {
                PersonLVL = 2;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"  {PersonNickname} current hero level is 2");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
            else if (CrimeCount >= 40)
            {
                PersonLVL = 3;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"  {PersonNickname} current hero level is 3");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
        }
    }
}
