using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Project
{
    internal class SuperHero : SuperHuman
    {
        public int HeroID { get; set; }
        public string GoodEvil { get; set; }
        public int DeedTime { get; set; }


        public SuperHero()
        {

            GoodEvil = "We have yet to see";
            DeedTime = 0;

        }

        public SuperHero(string Name,
                         string Surname,
                         string Nickname,
                         int heroID,
                         char Gender,
                         int Age,
                         string goodEvil,
                         int deedTime,
                         string Powers1,
                         string Powers2,
                         string Powers3,
                         double Salary,
                         int LVL) :base (Name,Surname,Nickname,Gender,Age,Powers1,Powers2,Powers3,Salary,LVL)
        {

            GoodEvil = goodEvil;
            DeedTime = deedTime;
            HeroID = heroID;

        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("   ================================");
            Console.WriteLine($"    HeroID:             {HeroID}");
            Console.WriteLine("   ================================");
            //tells if the hero is evil or not
            Console.WriteLine($"    {Nickname} is ready to protect the city\n");
        }

        public void SalaryCalculation()
        {
            Console.WriteLine($"Input how many hours {Nickname} spent on task 1:");

            int.TryParse(Console.ReadLine(), out int deedTimeInHours1);

            Console.WriteLine($"Input how many hours {Nickname} spent on task 2:"); ;

            int.TryParse(Console.ReadLine(), out int deedTimeInHours2);

            Console.WriteLine($"Input how many hours {Nickname} spent on task 3:");

            int.TryParse(Console.ReadLine(), out int deedTimeInHours3);

            int TotalDeedTime = deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3;

            int avgdeedtime = TotalDeedTime / 3;

            DeedTime += TotalDeedTime;

            Console.WriteLine("Input hourly rate:");
            int.TryParse(Console.ReadLine(), out int hourlyrate);

            double dailysalary;
            double monthlySalary;

            Console.WriteLine($"    On avarage it takes {Nickname} {avgdeedtime} hours to complete a task");
            Console.WriteLine($"    {Nickname} spent {DeedTime} hours working");

            if (DeedTime <= 8)
            {
                dailysalary = DeedTime * hourlyrate;

                Console.WriteLine(value: $"    {Nickname} earned {dailysalary} today");
                monthlySalary = dailysalary * 30;

                Console.WriteLine(value: $"    {Nickname} monthly salary would be {monthlySalary}");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Salary += monthlySalary;
            }
            if (DeedTime > 8)
            {
                dailysalary = ((8 * hourlyrate) + ((DeedTime - 8) * 15));

                Console.WriteLine(value: $"    {Nickname} earned {dailysalary} today");
                monthlySalary = dailysalary * 30;

                Console.WriteLine(value: $"    {Nickname} monthly salary would be {monthlySalary}");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Salary += monthlySalary;
            }
        }

        public void HeroIndeMenu()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("What would you like to do?\n");
            Console.WriteLine($"1. View {Nickname} hero card");
            Console.WriteLine($"2. Calculate {Nickname} salary");
            Console.WriteLine($"3. Calculate {Nickname} level");
            Console.WriteLine($"4. Rate {Nickname} performance");
            Console.WriteLine($"5. Calculate the amount of cookies {Nickname} can buy");
            Console.WriteLine($"6. Delete {Nickname}'s file");
            Console.WriteLine("7. Go back to Hero List.");
            Console.WriteLine("8. Go back to main menu");
        }

        //Method calculates the level of the super human, depending on deed time
        public void CalculatedLevel()
        {
            if (DeedTime <= 20)
            {
                LVL = 1;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"  {Nickname} current level is 1");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
            else if (DeedTime > 20 && DeedTime < 40)
            {
                LVL = 2;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"  {Nickname} current hero level is 2");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
            else if (DeedTime >= 40)
            {
                LVL = 3;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"  {Nickname} current hero level is 3");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
        }

        public void FinancialInfo()
        {
            double money = Salary;
            double cookieCost = 1.29;
            double boughtCookies = Math.Floor(money / cookieCost);

            Console.WriteLine(" ************** FINANCIAL INFO **************");
            Console.WriteLine($"    {Nickname} has {money} in his account \n");
            Console.WriteLine($"    {Nickname} can buy {boughtCookies} cookies \n");
        }

        public void GivingHeroMarks()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Please garde how well the hero did on the task!");
            Console.WriteLine("Select a grdae from A to H");

            char.TryParse(Console.ReadLine(), out char deed);
            deed = char.ToUpper(deed);
            Console.WriteLine("");
            switch (deed)
            {
                case 'A':
                case 'B':
                    Console.WriteLine("Perfect! You are so brave!");
                    break;
                case 'C':
                    Console.WriteLine("Good! But You can do better!");
                    break;
                case 'D':
                case 'E':
                    Console.WriteLine("It is not good! You should choose your bad or good side!");
                    break;
                case 'F':
                    Console.WriteLine("You are walking a fine line between Antihero and Hero!");
                    break;
                case 'G':
                    Console.WriteLine("Bad, you are true villain");
                    break;
                case 'H':
                    Console.WriteLine("Straight to hell with you!");
                    break;
                default:
                    Console.WriteLine("No one can be that bad!");
                    break;
            }
        }
        public void createHero()
        {
            Console.WriteLine("Please enter the super hero's name:");
            string HeroName = Console.ReadLine();

            Console.WriteLine("Please enter the super hero's Surnamename:");
            string HeroSurname = Console.ReadLine();

            Console.WriteLine("Please enter the super hero's Nickname:");
            string HeroNickanme = Console.ReadLine();

            Console.WriteLine("Please enter the super hero's ID:");
            int.TryParse(Console.ReadLine(), out int HeroID);

            Console.WriteLine("Please enter the super hero's Gender:");
            char.TryParse(Console.ReadLine(), out char HeroGender);

            Console.WriteLine("Please enter the super hero's Age:");
            int.TryParse(Console.ReadLine(), out int HeroAge);

            Console.WriteLine("Please enter the super hero's Deed Time:");
            int.TryParse(Console.ReadLine(), out int HeroDeedTime);

            Console.WriteLine("Please enter super hero's 3 super powers:");
            string HeroPower1 = Console.ReadLine();
            string HeroPower2 = Console.ReadLine();
            string HeroPower3 = Console.ReadLine();

            Console.WriteLine("Please enter the super hero's Salary:");
            double.TryParse(Console.ReadLine(), out double HeroSalary);

            Console.WriteLine("Please enter the hero LVL");
            int.TryParse(Console.ReadLine(), out int lVL);

            Console.WriteLine("Is it a Hero - 0 or a Villian - 1?(don't worry, they won't know you told us)");
            string evilGood = Console.ReadLine();


            SuperHero NewHero = new(HeroName,
                                    HeroSurname,
                                    HeroNickanme,
                                    HeroID,
                                    HeroGender,
                                    HeroAge,
                                    evilGood,
                                    HeroDeedTime,
                                    HeroPower1,
                                    HeroPower2,
                                    HeroPower3,
                                    HeroSalary,
                                    lVL);
        }

    }

   
}
