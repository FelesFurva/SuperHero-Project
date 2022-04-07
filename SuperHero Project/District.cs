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
        public List <SuperHuman> People { get; set; }

        public District()
        {
            Title = "Unknown";
            City = "Unknown";
            DistrictID = 0;
            People = new List<SuperHuman>();
        }

        public District(string title, string city, int districtID, List<SuperHuman> people)
        {
            Title = title;
            City = city;
            DistrictID = districtID;
            People = people;
        }

        public void addHero(SuperHero addedHero)
        {
            Console.WriteLine($"We have added to {Title} hero {addedHero.Nickname}");
            People.Add(addedHero);
        }

        public void addVillian(SuperVillian addedvillain)
        {
            Console.WriteLine($"We have added to {Title} hero {addedvillain.Nickname}");
            People.Add(addedvillain);
        }

        public void removePerson()
        {
            for(int i = 0; i < People.Count; i++)
            {
                Console.WriteLine($"{i+1}. {People[i].Nickname}");
            }

            int.TryParse(Console.ReadLine(), out int RemovePersone);

            Console.WriteLine($"{People[RemovePersone - 1].Nickname} has been removed from district {Title}");
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
            Console.WriteLine($"Here are all the heroes curently in {Title}");
            PrintListOfHeroes();
            Console.WriteLine("=============================================");
            Console.WriteLine($"Here are all the villians curently in {Title}");
            PrintListOfVillians();

        }

        public void PrintListOfHeroes()
        {
            int count = 0; 
            foreach (SuperHuman person in People)
            {
                if (person.GetType() == typeof(SuperHero))
                {
                    count++;
                    Console.WriteLine($"{count}. {person.Nickname}");
                }
            }
        }

        public void PrintListOfVillians()
        {
            int count = 0;
            foreach (SuperHuman person in People)
            {
                if (person.GetType() == typeof(SuperVillian))
                {
                    count++;
                    Console.WriteLine($"{count}. {person.Nickname}");
                }
            }
        }

        public float CalculateLVLavarage()
        {
            float totalHerolevel = 0f;
            int count = 0;
            foreach (SuperHuman person in People)
            {
                if (person.GetType() == typeof(SuperHero))
                {
                    count++;
                    totalHerolevel += person.LVL;
                }
            }

            float avrgHeroLVL = totalHerolevel / count;
            return avrgHeroLVL;
        }

        public void MaxHeroandVillianLVL()
        {
            var MaxHeroLVL = People.Where(x => x is SuperHero).MaxBy(x => x.LVL);
            var MaxVillainLVL = People.Where(x => x is SuperVillian).MaxBy(x => x.LVL);

            Console.WriteLine("\n=============================================================");
            Console.WriteLine($"The strongest Hero in the {Title} is : {MaxHeroLVL.Nickname} ");
            Console.WriteLine("=============================================================");
            if (MaxVillainLVL != null)
            {
                Console.WriteLine($"The strongest Villian in the {Title} is : {MaxVillainLVL.Nickname} ");
            }
            else
            {
                Console.WriteLine($"No villian in sight");
            }
        }

        public void CrimeTimeCalculator()
        {
            int totalCrime = 0;
            int MaxCrimeTime = 0;
            string VillianName = "";
            foreach (SuperHuman person in People)
            {
                if (person is SuperVillian)
                {
                    SuperVillian superVillian = (SuperVillian)person;

                    totalCrime += superVillian.CrimeTime;
                    if (superVillian.CrimeTime > MaxCrimeTime)
                    {
                        MaxCrimeTime = superVillian.CrimeTime;
                        VillianName = superVillian.Nickname;
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
            Console.WriteLine("2. Search by HeroId");
            Console.WriteLine("3. Search by LVL");
            int.TryParse(Console.ReadLine(), out int searchChoice);

            List<SuperHuman> hero = new List<SuperHuman>();
            foreach (SuperHuman person in People)
            {
                if (person.GetType() == typeof(SuperHero))
                {
                    hero.Add(person);
                }
            }

            switch (searchChoice)
            {
                case 1:

                    string NameSearch = Console.ReadLine();
                    var item = hero.Where(found => found.Nickname == NameSearch);
                    if (item != null)
                    {
                        Console.WriteLine("There's a match");
                        foreach (SuperHuman Nickname in item)
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
                    int.TryParse(Console.ReadLine(), out int IDSearch);

                    int count = 0;
                    foreach (SuperHero h in hero)
                    {
                  
                            if (h.HeroID == IDSearch)
                            {
                                h.PrintHeroInfo();
                                count++;
                            }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine("No match found");
                    }

                    break;
                case 3:
                    int.TryParse(Console.ReadLine(), out int lvlSearch);
                    var item3 = hero.Where(found => found.LVL == lvlSearch);
                    if (item3 != null)
                    {
                        Console.WriteLine("There's a match");
                        foreach (SuperHuman LVL in item3)
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
            Console.WriteLine($"Are you sure you would like to remove {People[i].Nickname} file?");
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
            Console.WriteLine($"Are you sure you would like to remove {People[i].Nickname} file?");
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
