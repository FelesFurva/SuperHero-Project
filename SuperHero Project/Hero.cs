using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Project
{
    internal class Hero : Person
    {
        public int HeroID { get; set; }
        public int DeedCount { get; set; }


        public Hero(string Name,
                         string Surname,
                         string Nickname,
                         int heroID,
                         int Age,
                         double Salary,
                         int LVL,
                         string PersonType) :base (Name,Surname,Nickname, Age,Salary,LVL, PersonType)
        {

            
            HeroID = heroID;

        }

        public override void PrintHeroInfo()
        {
            base.PrintHeroInfo();
            Console.WriteLine("   ================================");
            Console.WriteLine($"    HeroID:             {HeroID}");
            Console.WriteLine("   ================================");
            //tells if the hero is evil or not
            Console.WriteLine($"    {PersonNickname} is ready to protect the city\n");
        }

        public void HeroIndexMenu()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("What would you like to do?\n");
            Console.WriteLine($"1. View {PersonNickname} hero card");
            Console.WriteLine($"2. Calculate {PersonNickname} salary");
            Console.WriteLine($"3. Calculate {PersonNickname} level");
            Console.WriteLine($"4. Rate {PersonNickname} performance");
            Console.WriteLine($"5. Calculate the amount of cookies {PersonNickname} can buy");
            Console.WriteLine($"6. Delete {PersonNickname}'s file");
            Console.WriteLine("7. Go back to Hero List.");
            Console.WriteLine("8. Go back to main menu");
        }

        public void SalaryCalculation(int DeedCount)
        {
            Console.WriteLine("Input payment amount for 1 deed:");
            int.TryParse(Console.ReadLine(), out int hourlyrate);

            double dailysalary;
            double monthlySalary;

            Console.WriteLine($"    {PersonNickname} has completed {DeedCount} deeds");

            if (DeedCount <= 4)
            {
                dailysalary = DeedCount * hourlyrate;

                Console.WriteLine(value: $"    {PersonNickname} earned {dailysalary} today");
                monthlySalary = dailysalary * 30;

                Console.WriteLine(value: $"    {PersonNickname} monthly salary would be {monthlySalary}");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                PersonSalary += monthlySalary;
            }
            if (DeedCount > 4)
            {
                dailysalary = ((8 * hourlyrate) + ((DeedCount - 8) * 15));

                Console.WriteLine(value: $"    {PersonNickname} earned {dailysalary} today");
                monthlySalary = dailysalary * 30;

                Console.WriteLine(value: $"  If {PersonNickname} works at this rate their monthly salary would be {monthlySalary}");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                PersonSalary += monthlySalary;
            }
        }



        //Method calculates the level of the super human, depending on deed time
        public void CalculateLevel(int DeedCount)
        {
           
            if (DeedCount <= 3)
            {
                PersonLVL = 1;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"  {PersonNickname} current level is 1");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
            else if (DeedCount > 3 && DeedCount < 5)
            {
                PersonLVL = 2;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"  {PersonNickname} current hero level is 2");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
            else if (DeedCount >= 5)
            {
                PersonLVL = 3;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"  {PersonNickname} current hero level is 3");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
        }

        public void FinancialInfo()
        {
            double money = PersonSalary;
            double cookieCost = 1.29;
            double boughtCookies = Math.Floor(money / cookieCost);

            Console.WriteLine(" ************** FINANCIAL INFO **************");
            Console.WriteLine($"    {PersonNickname} has {money} in his account \n");
            Console.WriteLine($"    {PersonNickname} can buy {boughtCookies} cookies \n");
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
        public void CreateHero()
        {
            Console.WriteLine("Please enter the super hero's name:");
            string HeroName = Console.ReadLine();

            Console.WriteLine("Please enter the super hero's Surnamename:");
            string HeroSurname = Console.ReadLine();

            Console.WriteLine("Please enter the super hero's Nickname:");
            string HeroNickanme = Console.ReadLine();

            Console.WriteLine("Please enter the super hero's ID:");
            int.TryParse(Console.ReadLine(), out int HeroID);

            Console.WriteLine("Please enter the super hero's Age:");
            int.TryParse(Console.ReadLine(), out int HeroAge);

            Console.WriteLine("Please enter the super hero's Deed Time:");
            int.TryParse(Console.ReadLine(), out int HeroDeedTime);

            Console.WriteLine("Please enter super hero's 3 super powers:");
            string HeroPower1 = Console.ReadLine();
            string HeroPower2 = Console.ReadLine();
            string HeroPower3 = Console.ReadLine();

            List<string> HeroPowers = new List<string>();
            HeroPowers.Add(HeroPower1);
            HeroPowers.Add(HeroPower2);
            HeroPowers.Add(HeroPower3);

            Console.WriteLine("Please enter the super hero's Salary:");
            double.TryParse(Console.ReadLine(), out double HeroSalary);

            Console.WriteLine("Please enter the hero LVL");
            int.TryParse(Console.ReadLine(), out int lVL);

            Console.WriteLine("Is it a Hero or a Villian?(don't worry, they won't know you told us)");
            string personType = Console.ReadLine();


            Hero NewHero = new(HeroName,
                                    HeroSurname,
                                    HeroNickanme,
                                    HeroID,
                                    HeroAge,
                                    HeroSalary,
                                    lVL,
                                    personType);
        }

    }

   
}
