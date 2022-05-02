using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Project
{
    internal class District
    {
        public string Title { get; set; }
        public string City { get; set; }
        public int DistrictID { get; set; }
        public List <Person> People { get; set; }

        public District()
        {
            Title = "Unknown";
            City = "Unknown";
            DistrictID = 0;
        }

        public District(string title, string city, int districtID)
        {
            Title = title;
            City = city;
            DistrictID = districtID;
        }

        public void AddHero(Hero addedHero)
        {
            Console.WriteLine($"We have added to {Title} hero {addedHero.PersonNickname}");
            People.Add(addedHero);
        }

        public void AddVillian(Villian addedvillain)
        {
            Console.WriteLine($"We have added to {Title} hero {addedvillain.PersonNickname}");
            People.Add(addedvillain);
        }

        public void RemovePerson()
        {
            for(int i = 0; i < People.Count; i++)
            {
                Console.WriteLine($"{i+1}. {People[i].PersonNickname}");
            }

            int.TryParse(Console.ReadLine(), out int RemovePersone);

            Console.WriteLine($"{People[RemovePersone - 1].PersonNickname} has been removed from district {Title}");
            People.RemoveAt(RemovePersone - 1);

        }

        public void PrintCityInfo()
        {
            Console.WriteLine("   ================================");
            Console.WriteLine("            District");
            Console.WriteLine("   ================================");
            Console.WriteLine();
            Console.WriteLine($"    Title:     {Title}");
            Console.WriteLine($"    City:      {City}");
            Console.WriteLine($"    ID:       {DistrictID}");

            Console.WriteLine("=============================================");


        }

        public void PrintListOfHeroes(List<Hero> People)
        {
            Console.WriteLine($"Here are all the Heroes curently in {Title}:");
            Console.WriteLine("=============================================");
            int count = 0; 
            foreach (Hero person in People)
            {
                if (person.GetType() == typeof(Hero))
                {
                    count++;
                    Console.WriteLine($"{count}. {person.PersonNickname}");
                }
            }
        }

        public void PrintListOfVillians(List<Villian> People)
        {
            Console.WriteLine($"Here are all the Villians curently in {Title}:");
            Console.WriteLine("=============================================");
            int count = 0;
            foreach (Villian person in People)
            {
                if (person.GetType() == typeof(Villian))
                {
                    count++;
                    Console.WriteLine($"{count}. {person.PersonNickname}");
                }
            }
        }

        public float CalculateLVLavarage(List<Person> People)
        {
            float totalHerolevel = 0f;
            int count = 0;
            foreach (Person person in People)
            {
                if (person.GetType() == typeof(Hero))
                {
                    count++;
                    totalHerolevel += person.PersonLVL;
                }
            }

            float avrgHeroLVL = totalHerolevel / count;
            return avrgHeroLVL;
        }

        public void MaxHeroandVillianLVL(List<Hero> Hero, List<Villian> villians)
        {
            foreach (Hero person in Hero)
            {

                var MaxHeroLVL = Hero.MaxBy(x => x.PersonLVL);
                if (MaxHeroLVL != null)
                {
                    Console.WriteLine("\n=============================================================");
                    Console.WriteLine($"The strongest Person in the {Title} is : {MaxHeroLVL.PersonNickname} ");
                    Console.WriteLine("=============================================================");
                }
                else
                {
                    Console.WriteLine($"No hero in sight");
                }
            }
            foreach (Villian person in villians)
            { 
                var MaxVillainLVL = People.MaxBy(x => x.PersonLVL);
                if (MaxVillainLVL != null)
                {
                    Console.WriteLine($"The strongest Villian in the {Title} is : {MaxVillainLVL.PersonNickname} ");
                }
                else
                {
                    Console.WriteLine($"No villian in sight");
                } 
            }
        }

        public void CrimeTimeCalculator(List<Villian> People)
        {
            int totalCrime = 0;
            int MaxCrimeTime = 0;
            string VillianName = "";
            foreach (Villian person in People)
            {
                if (person is Villian superVillian)
                {
                    totalCrime += superVillian.CrimeCount;
                    if (superVillian.CrimeCount > MaxCrimeTime)
                    {
                        MaxCrimeTime = superVillian.CrimeCount;
                        VillianName = superVillian.PersonNickname;
                    }
                }
            }
            Console.WriteLine($"The total crime time in the district is {totalCrime}");
            Console.WriteLine($"The villian who comited most crimes is {VillianName}");
        }



        public void HeroSearch()
        {
            Console.WriteLine("Please enter search prameter:");
            Console.WriteLine("1. Search by Nickname");
            Console.WriteLine("2. Search by LVL");
            int.TryParse(Console.ReadLine(), out int searchChoice);

            List<Person> people = new();
            foreach (Person person in People)
            {
                people.Add(person);
            }

            switch (searchChoice)
            {
                case 1:

                    string NameSearch = Console.ReadLine();
                    var item = people.Where(found => found.PersonNickname == NameSearch);
                    if (item != null)
                    {
                        Console.WriteLine("There's a match");
                        foreach (Person Nickname in item)
                        {
                            Nickname.PrintHeroInfo();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No match found");
                    }
                    break;

                case 2:
                    int.TryParse(Console.ReadLine(), out int lvlSearch);
                    var item3 = people.Where(found => found.PersonLVL == lvlSearch);
                    if (item3 != null)
                    {
                        Console.WriteLine("There's a match");
                        foreach (Person LVL in item3)
                        {
                            LVL.PrintHeroInfo();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No match found");
                    }
                    break;
            }
        }

        public void RemoveHero(int i)
        {
            Console.WriteLine($"Are you sure you would like to remove {People[i].PersonNickname} file?");
            Console.WriteLine("Y for yes");
            Console.WriteLine("N for no");
            char.TryParse(Console.ReadLine(), out char userChoice3);

            if (userChoice3 == 'Y')
            {
                People.Remove(People[i]);
            }
            else
            {
                Console.WriteLine("Don't worry we won't");
            }
        }

        public void RemoveVillian(int i)
        {
            Console.WriteLine($"Are you sure you would like to remove {People[i].PersonNickname} file?");
            Console.WriteLine("Y for yes");
            Console.WriteLine("N for no");
            char.TryParse(Console.ReadLine(), out char userChoice3);

            if (userChoice3 == 'Y')
            {
                People.Remove(People[i]);
            }
            else
            {
                Console.WriteLine("Don't worry, we won't tell you tried");
            }
        }
        public void DistrictMenu()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Enter D to view {Title} file");
            Console.WriteLine($"Enter N to add a hero to {Title}");
            Console.WriteLine($"Enter S to search {Title}");
            Console.WriteLine($"Enter R to remove people from {Title}");
            Console.WriteLine($"Enter V to let a villain loose on the city!");
            Console.WriteLine($"Enter L to go back to district list");
            Console.WriteLine($"Enter M to main menu");
        }
    
    }
}
