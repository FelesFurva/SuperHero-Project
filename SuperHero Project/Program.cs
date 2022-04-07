using SuperHero_Project;
using System.Collections.Generic;

bool mainmenu = true;
bool menu1 = true;

SuperHero SuperCat = new("Diana", "Walker", "SuperCat", 1, 'F', 33, "Hero", 33, "has 9 lives", "can fight lazer pointers", "walks without making a sound", 500, 2);
SuperHero DogMan = new("James", "Runner", "DogMan", 2, 'M', 27, "Hero", 17, "A true Bro", "will find anyting by scent", "runs fast!", 300, 1);
SuperHero TestPersone = new("Mystery", "Jhones", "TestPersone", 3, '?', 999, "Hero", 50, "always happy to help", "can be the best to test", "here and back again", 1000, 3);
SuperHero Secrete = new("No one knows", "A mystery", "Secrete", 4, '?', 40, "Hero", 300, "covered in shadows", "moves silently", "always in a scarf", 10000, 3);
SuperHero Bear = new("Mikhael", "Grawl", "Bear", 5, 'M', 10, "Hero", 10, "is adorable", "extra strong", "thick skin", 500, 1);
SuperHero ManBat = new("Bruce", "Whine", "ManBat", 6, 'M', 55, "Hero", 999, "money", "graping hook", "detective work", 100000, 3);
SuperHero CapedBaldy = new("Saitama", "Garou", "CapedBaldy", 7, 'M', 25, "Hero", 999, "Supernatural Reflexes and Senses", "Invulnerability", "Punches really hard", 0, 3);

SuperVillian CreepyV = new("Val", "Parker", "CreepyV", 1, 'F', 20, "Villian", 15, "Stalks around the cookie pile", "steps over sleeping ppl", "cracks mirrors", 600, 3);
SuperVillian GalBot = new("Ricky", "Hart", "GalBot", 2, 'F', 25, "Villian", 17, "Insults", "Evil eye", "Spooky haul", 700, 1);
SuperVillian Rakoon = new("Mark", "Brown", "Rakoon", 3, 'M', 20, "Villian", 21, "Trash attack", "Flipping birds", "Grauwl", 500, 2);

List<SuperHero> HeroAccademia = new List<SuperHero>();
HeroAccademia.Add(SuperCat);
HeroAccademia.Add(DogMan);
HeroAccademia.Add(TestPersone);
HeroAccademia.Add(Secrete);
HeroAccademia.Add(Bear);
HeroAccademia.Add(ManBat);
HeroAccademia.Add(CapedBaldy);

List<SuperVillian> VillainLigue = new List<SuperVillian>();
VillainLigue.Add(CreepyV);
VillainLigue.Add(GalBot);
VillainLigue.Add(Rakoon);


List<SuperHuman> purvciems = new List<SuperHuman>();
purvciems.Add(SuperCat);
purvciems.Add(DogMan);
purvciems.Add(TestPersone);
purvciems.Add(CreepyV);
purvciems.Add(GalBot);

List<SuperHuman> ilguciems = new List<SuperHuman>();
ilguciems.Add(Secrete);
ilguciems.Add(Bear);
ilguciems.Add(Rakoon);

List<SuperHuman> mezciems = new List<SuperHuman>();
mezciems.Add(ManBat);
mezciems.Add(CapedBaldy);


District Purvciems = new District("Purvciems", "Riga", 1, purvciems);
District Ilguciems = new District("Ilguciems", "Riga", 2, ilguciems);
District Mezciems = new District("Mezciems", "Riga", 3, mezciems);

List<District> Metropolis = new List<District>();
Metropolis.Add(Purvciems);
Metropolis.Add(Ilguciems);
Metropolis.Add(Mezciems);

Console.WriteLine("Wellcome to the SuperHero application \n");
while (mainmenu)
{
    Menu.MainMenu();
    int.TryParse(Console.ReadLine(), out int uChoice);

    switch (uChoice)
    {
        case 1:
            do
            {
                bool Heromenu = true;

                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("The following Heros are on file\n");
                for (int i = 0; i < HeroAccademia.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {HeroAccademia[i].Nickname}");
                }
                
                // user inputs which hero they choose
                int.TryParse(Console.ReadLine(), out int HeroIndex);

                do
                {
                    HeroAccademia[HeroIndex - 1].HeroIndexMenu();

                    //user inputs which action they choose
                    int.TryParse(Console.ReadLine(), out int HmenuChoice);

                    switch (HmenuChoice)
                    {
                        case 1:
                            HeroAccademia[HeroIndex - 1].PrintHeroInfo();
                            break;
                        case 2:
                            HeroAccademia[HeroIndex - 1].SalaryCalculation();
                            break;
                        case 3:
                            HeroAccademia[HeroIndex - 1].CalculateLevel();
                            break;
                        case 4:
                            HeroAccademia[HeroIndex - 1].GivingHeroMarks();
                            break;
                        case 5:
                            HeroAccademia[HeroIndex - 1].FinancialInfo();
                            break;
                        case 6:
                            HeroAccademia.RemoveAt(HeroIndex - 1);
                            Heromenu = false;
                            break;
                        case 7:
                            Heromenu = false;
                            break;
                        case 8:
                            Heromenu = false;
                            menu1 = false;
                            break;
                        default:
                            Console.WriteLine("Please choose a valid option");
                            break;
                    }
                } while (Heromenu);
            } while (menu1);
            break; 

           case 2:
            do
            {
                bool Vilmenu = true;
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("The following Villians are on file\n");
                for (int i = 0; i < VillainLigue.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {VillainLigue[i].Nickname}");
                }

                // user inputs which villian they choose
                int.TryParse(Console.ReadLine(), out int VilIndex);
                do
                {
                    //user chooses what to do with the Villian
                    VillainLigue[VilIndex - 1].VillianIndeMenu();
                    int.TryParse(Console.ReadLine(), out int userChoice2);

                    switch (userChoice2)
                    {
                        case 1:
                            VillainLigue[VilIndex - 1].PrintHeroInfo();
                            break;
                        case 2:
                            VillainLigue[VilIndex - 1].CalculateVillainLvl();
                            break;
                        case 3:
                            VillainLigue[VilIndex - 1].CalculationCrimeTime();
                            break;
                        case 4:
                            Purvciems.RemoveVillian(VilIndex - 1);
                            Vilmenu = false;
                            menu1 = false;
                            break;
                        case 5:
                            Vilmenu = false;
                            break;
                        case 6:
                            menu1 = false;
                            Vilmenu = false;
                            break;
                        default:
                            Console.WriteLine("Please select a valid option.");
                            break;
                    }
                } while (Vilmenu);
            } while (menu1);
            break;

        case 3:
            do
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Please select the district you would like to view: \n");
                for (int i = 0; i < Metropolis.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Metropolis[i].Title}");
                }
                bool Distmenu = true;
                int.TryParse(Console.ReadLine(), out int DistrictChoice);
                do
                {
                    Metropolis[DistrictChoice - 1].DistrictMenu();

                    char.TryParse(Console.ReadLine(), out char menuItem);
                    menuItem = char.ToUpper(menuItem);

                    switch (menuItem)
                    {
                        case 'D':
                            Metropolis[DistrictChoice - 1].PrintCityInfo();
                            Console.WriteLine($"\nThe avarage lvl of heros in the district {Metropolis[DistrictChoice - 1].Title} is: {Metropolis[DistrictChoice - 1].CalculateLVLavarage()}");
                            Metropolis[DistrictChoice - 1].MaxHeroandVillianLVL();
                            Metropolis[DistrictChoice - 1].CrimeTimeCalculator();
                            break;

                        case 'N':

                            Console.WriteLine("Which hero would you like to add: ");
                            for (int i = 0; i < HeroAccademia.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {HeroAccademia[i].Nickname}");
                            }
                            int.TryParse(Console.ReadLine(), out int addedhero);

                            Metropolis[DistrictChoice - 1].addHero(HeroAccademia[addedhero - 1]);
                            Console.WriteLine($"SuperHero has been added to {Metropolis[DistrictChoice - 1].Title}");
                            break;
                        case 'V':
                            Console.WriteLine("Which hero would you like to add: ");
                            for (int i = 0; i < VillainLigue.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {VillainLigue[i].Nickname}");
                            }
                            int.TryParse(Console.ReadLine(), out int addedvillain);

                            Metropolis[DistrictChoice - 1].addVillian(VillainLigue[addedvillain - 1]);
                            Console.WriteLine($"SuperHero has been added to {Metropolis[DistrictChoice - 1].Title}");
                            break;

                        case 'S':
                            Metropolis[DistrictChoice - 1].HeroSearch();
                            break;
                        case 'R':
                            Metropolis[DistrictChoice - 1].removePerson();
                            break;
                        case 'L':
                            Distmenu = false;
                            break;

                        case 'M':
                            menu1 = false;
                            Distmenu = false;
                            break;
                    }
                } while (Distmenu);
            } while (menu1);
            break;

        case 4:
                string districtName = "";
                float MaxAvrgLVL = 0f;
                foreach (District district in Metropolis)
                {
                    float AvrgLVL = district.CalculateLVLavarage();
                    if (AvrgLVL > MaxAvrgLVL)
                    {
                        MaxAvrgLVL = AvrgLVL;
                        districtName = district.Title;
                    }
                }
                Console.WriteLine($"\nThe maximum Hero LVL avarage amoung districts is: {MaxAvrgLVL}");
                Console.WriteLine($"The district with the heights hero LVL avarage is: {districtName}");
            break;

        case 5:
            mainmenu = false;
            break;
    }
}