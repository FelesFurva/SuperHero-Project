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


List<SuperHuman> neighbourhood1 = new List<SuperHuman>();
neighbourhood1.Add(SuperCat);
neighbourhood1.Add(DogMan);
neighbourhood1.Add(TestPersone);
neighbourhood1.Add(CreepyV);
neighbourhood1.Add(GalBot);

List<SuperHuman> neighbourhood2 = new List<SuperHuman>();
neighbourhood2.Add(Secrete);
neighbourhood2.Add(Bear);
neighbourhood2.Add(Rakoon);

List<SuperHuman> neighbourhood3 = new List<SuperHuman>();
neighbourhood3.Add(ManBat);
neighbourhood3.Add(CapedBaldy);


District Purvciems = new District("Purvciems", "Riga", 1, neighbourhood1);
District Ilguciems = new District("Ilguciems", "Riga", 2, neighbourhood2);
District Mezciems = new District("Mezciems", "Riga", 3, neighbourhood3);

List<District> Metropolis = new List<District>();
Metropolis.Add(Purvciems);
Metropolis.Add(Ilguciems);
Metropolis.Add(Mezciems);
while (mainmenu)
{
    Console.WriteLine("Wellcome to the SuperHero application \n");
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine("What would you like to do Today?\n");
    Console.WriteLine("1. View a list of heros");
    Console.WriteLine("2. View a list of villians");
    Console.WriteLine("3. View a list of Districts");
    Console.WriteLine("4. Exit SuperHero application \n");
    int.TryParse(Console.ReadLine(), out int uChoice);


    switch (uChoice)
    {
       
        
        case 1:
        while (menu1)
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

            while (Heromenu)
            {
                //Shows possible choices of actions which can be preformed with a hero
                HeroAccademia[HeroIndex - 1].HeroIndeMenu();

                //user inputs which action they choose
                int.TryParse(Console.ReadLine(), out int HmenuChoice);

                switch (HmenuChoice)
                {
                    case 1:

                        //prints out the super hero card
                        HeroAccademia[HeroIndex - 1].PrintInfo();
                        break;

                    case 2:

                        //calculate salary and add earned money to hero account
                        HeroAccademia[HeroIndex - 1].SalaryCalculation();
                        break;

                    case 3:

                        //calculate hero level, based on the amount of time spent on deeds
                        HeroAccademia[HeroIndex - 1].CalculatedLevel();
                        break;

                    case 4:

                        //Mark hero from A to F
                        HeroAccademia[HeroIndex - 1].GivingHeroMarks();
                        break;

                    case 5:

                        //provides heros savings and the possible cookie gains
                        HeroAccademia[HeroIndex - 1].FinancialInfo();
                        break;

                    case 6:

                        //removing the hero from the district
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
            }
        }
            break; 

           case 2:
            while (menu1)
            {
                bool Vilmenu= true;
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("The following Villians are on file\n");
                for (int i = 0; i < VillainLigue.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {VillainLigue[i].Nickname}");
                }

                // user inputs which villian they choose
                int.TryParse(Console.ReadLine(), out int VilIndex);

                while (Vilmenu)
                {
                    //user chooses what to do with the Villian
                    VillainLigue[VilIndex - 1].VillianIndeMenu();
                    int.TryParse(Console.ReadLine(), out int userChoice2);

                    switch (userChoice2)
                    {
                        case 1:
                            VillainLigue[VilIndex - 1].PrintInfo();
                            break;
                        case 2:
                            VillainLigue[VilIndex - 1].CalculateVLvl();
                            break;
                        case 3:
                            VillainLigue[VilIndex - 1].CalculationCrimeTime();
                            break;
                        case 4:
                            Purvciems.RemoveVillian(VilIndex - 1);
                            Vilmenu = false;
                            break;
                        case 5:
                            Vilmenu = false;
                            break;
                        case 6:
                            menu1 = false;
                            Vilmenu = false;
                            break;
                    }
                }
            }
            break;

        case 3:
            while (menu1)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Please select the district you would like to view: \n");
                for (int i = 0; i < Metropolis.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Metropolis[i].Title}");
                }
                bool Distmenu = true;
                int.TryParse(Console.ReadLine(), out int DistrictChoice);
                while (Distmenu)
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine($"Enter D to view {Metropolis[DistrictChoice - 1].Title} file");
                    Console.WriteLine($"Enter N to add a hero to {Metropolis[DistrictChoice - 1].Title}");
                    Console.WriteLine($"Enter S to search {Metropolis[DistrictChoice - 1].Title}");
                    Console.WriteLine($"Enter R to remove people from {Metropolis[DistrictChoice - 1].Title}");
                    Console.WriteLine($"Enter V to let a villain loose on the city!");
                    Console.WriteLine($"Enter L to go back to district list");
                    Console.WriteLine($"Enter M to main menu");

                    char.TryParse(Console.ReadLine(), out char menuItem);
                    menuItem = char.ToUpper(menuItem);

                    switch (menuItem)
                    {
                        case 'D':
                            Metropolis[DistrictChoice - 1].PrintCityInfo();
                            Console.WriteLine($"\nThe avarage lvl of heros in the district {Metropolis[DistrictChoice - 1].Title} is: {Metropolis[DistrictChoice - 1].CalculateLVLavarage()}");
                            Metropolis[DistrictChoice - 1].MaxHeroandVillian();
                            Console.WriteLine($"The total amoutn of crime time int {Metropolis[DistrictChoice - 1].Title} is: {Metropolis[DistrictChoice - 1].CrimeTimeCalculator()}");
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
                }
            }
            break;

        case 4:
            mainmenu = false;
            break;
    }
}