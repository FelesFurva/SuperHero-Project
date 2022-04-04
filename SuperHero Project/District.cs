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
        public List <SuperHero> HeroesInTheDistrict { get; set; }
        public List<SuperVillian> VilliansInTheDistrict { get; set; }

        public District()
        {
            Title = "Unknown";
            City = "Unknown";
            DistrictID = 0;
            HeroesInTheDistrict = new List<SuperHero>();
            VilliansInTheDistrict = new List<SuperVillian>();
        }

        public District(string title, string city, int districtID, List<SuperHero> heroinDistrict, List<SuperVillian> villiansInTheDistrict)
        {
            Title = title;
            City = city;
            DistrictID = districtID;
            HeroesInTheDistrict = heroinDistrict;
            VilliansInTheDistrict = villiansInTheDistrict;
        }

        public void addHero(SuperHero addedHero)
        {
            Console.WriteLine($"We have added to {Title} hero {addedHero.Nickname}");
            HeroesInTheDistrict.Add(addedHero);
        }

        public void removeHero(int position)
        {
            Console.WriteLine($"We removed the hero {HeroesInTheDistrict[position].Nickname} from {Title}");
            HeroesInTheDistrict.RemoveAt(position); 
        }

        public float CalculateLVLavarage()
        {
            float totalHerolevel = 0f;
            foreach(SuperHero superHero in HeroesInTheDistrict)
            {
                totalHerolevel += superHero.LVL;
            }

            float avrgHeroLVL = totalHerolevel / HeroesInTheDistrict.Count;
            return avrgHeroLVL;
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
            for (int i = 0; i < HeroesInTheDistrict.Count; i++)
            {
                Console.WriteLine($"{i+1}. {HeroesInTheDistrict[i].Nickname}");
            }
        }

        public void PrintListOfVillians()
        {
            for (int i = 0; i < VilliansInTheDistrict.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {VilliansInTheDistrict[i].Nickname}");
            }
        }


        public void createHero(List<SuperHero> heroAccademia)
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
            heroAccademia.Add(NewHero);
        }

        public void HeroSearch()
        {
            Console.WriteLine("Please enter search prameter:");
            Console.WriteLine("1. Search by Nickname");
            Console.WriteLine("2. Search by HeroId");
            Console.WriteLine("3. Search by LVL");
            int.TryParse(Console.ReadLine(), out int searchChoice);

            switch (searchChoice)
            {
                case 1:

                    string NameSearch = Console.ReadLine();
                    var item = HeroesInTheDistrict.Where(found => found.Nickname == NameSearch);
                    if (item != null)
                    {
                        Console.WriteLine("There's a match");
                        foreach (SuperHero Nickname in item)
                        {
                            Nickname.PrintInfo();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No match found");
                    }
                    break;

                case 2:
                    int.TryParse(Console.ReadLine(), out int IDSearch);
                    var item2 = HeroesInTheDistrict.Where(found => found.HeroID == IDSearch);
                    if (item2 != null)
                    {
                        Console.WriteLine("There's a match");
                        foreach (SuperHero heroID in item2)
                        {
                            heroID.PrintInfo();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No match found");
                    }
                    break;
                case 3:
                    int.TryParse(Console.ReadLine(), out int lvlSearch);
                    var item3 = HeroesInTheDistrict.Where(found => found.LVL == lvlSearch);
                    if (item3 != null)
                    {
                        Console.WriteLine("There's a match");
                        foreach (SuperHero LVL in item3)
                        {
                            LVL.PrintInfo();
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
            Console.WriteLine($"Are you sure you would like to remove {HeroesInTheDistrict[i].Nickname} file?");
            Console.WriteLine("Y for yes");
            Console.WriteLine("N for no");
            char.TryParse(Console.ReadLine(), out char userChoice3);

            if (userChoice3 == 'Y')
            {
                HeroesInTheDistrict.Remove(HeroesInTheDistrict[i]);
            }
            else
            {
                Console.WriteLine("Don't worry we won't");
            }
        }

        public void RemoveVillian(int i)
        {
            Console.WriteLine($"Are you sure you would like to remove {VilliansInTheDistrict[i].Nickname} file?");
            Console.WriteLine("Y for yes");
            Console.WriteLine("N for no");
            char.TryParse(Console.ReadLine(), out char userChoice3);

            if (userChoice3 == 'Y')
            {
                VilliansInTheDistrict.Remove(VilliansInTheDistrict[i]);
            }
            else
            {
                Console.WriteLine("Don't worry, we won't tell you tried");
            }
        }
    }
}
