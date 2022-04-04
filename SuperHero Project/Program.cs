using SuperHero_Project;
using System.Collections.Generic;

bool menu1 = true;
bool menuI = true;

SuperHero Secrete = new();
SuperHero SuperCat = new("Diana", "Walker", "SuperCat", 1, 'F', 33, "Hero", 33, "has 9 lives", "can fight lazer pointers", "walks without making a sound", 500, 2);
SuperHero DogMan = new("James", "Runner", "DogMan", 2, 'M', 27, "Hero", 17, "A true Bro", "will find anyting by scent", "runs fast!", 300, 1);
SuperHero TestPersone = new("Mystery", "Jhones", "TestPersone", 3, '?', 999, "Hero", 50, "always happy to help", "can be the best to test", "here and back again", 1000, 3);

SuperVillian CreepyV = new("Val", "Parker", "CreepyV", 1, 'F', 20, "Villian", 15, "Stalks around the cookie pile", "steps over sleeping ppl", "cracks mirrors", 600, 3);
SuperVillian GalBot = new("Ricky", "Hart", "GalBot", 2, 'F', 25, "Villian", 17, "Insults", "Evil eye", "Spooky haul", 700, 1);
SuperVillian Rakoon = new("Mark", "Brown", "Rakoon", 3, 'M', 20, "Villian", 21, "Trash attack", "Flipping birds", "Grauwl", 500, 2);

List<SuperHero> HeroAccademia = new List<SuperHero>();
HeroAccademia.Add(SuperCat);
HeroAccademia.Add(DogMan);
HeroAccademia.Add(TestPersone);

List<SuperVillian> VillianLigue = new List<SuperVillian>();
VillianLigue.Add(CreepyV);
VillianLigue.Add(GalBot);
VillianLigue.Add(Rakoon);

District Purvciems = new District("Purvciems", "Riga", 1, HeroAccademia, VillianLigue);
District Ilguciems = new District("Ilguciems", "Riga", 2, HeroAccademia, VillianLigue);
District Mezciems = new District("Mezciems", "Riga", 3, HeroAccademia, VillianLigue);

while (menu1)
{
    Console.WriteLine("Wellcome to the SuperHero application \n");
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine("Enter I if you would like to see all the Supers on file");
    Console.WriteLine("Enter N to create a new file");
    Console.WriteLine("Enter S to search for a hero");
    Console.WriteLine("Enter D to view District files");
    Console.WriteLine("Enter Q to exit the application");

    char.TryParse(Console.ReadLine(), out char menuItem);
    menuItem = char.ToUpper(menuItem);

    switch (menuItem)
    {
        case 'N':

            Purvciems.createHero(HeroAccademia);
            Console.WriteLine($"SuperHero has been added to the raster");
            break;

        case 'Q':
            Console.WriteLine("Goodbye! <3");
            menu1 = false;
            break;

        case 'S':

            Purvciems.HeroSearch();
            break;


        case 'I':

            {
            Console.WriteLine("Please select the file you would like to work with:\n");
            Console.WriteLine("H for Heroes");
            Console.WriteLine("V for Villians");
            Console.WriteLine("B to go Back");

            char.TryParse(Console.ReadLine(), out char superMenu);
            superMenu = char.ToUpper(superMenu);

            if (superMenu == 'H')
            {
                Purvciems.PrintListOfHeroes();

                bool menu2 = true;

                // user inputs which hero they choose
                int.TryParse(Console.ReadLine(), out int userChoice);

                while (menu2)
                {
                    //Shows possible choices of actions which can be preformed with a hero

                    HeroAccademia[userChoice - 1].HeroIndeMenu();

                    //user inputs which action they choose
                    int.TryParse(Console.ReadLine(), out int userChoice2);

                    switch (userChoice2)
                    {
                        case 1:

                            //prints out the super hero card
                            HeroAccademia[userChoice - 1].PrintInfo();
                            break;

                        case 2:

                            //calculate salary and add earned money to hero account
                            HeroAccademia[userChoice - 1].SalaryCalculation();
                            break;

                        case 3:

                            //calculate hero level, based on the amount of time spent on deeds
                            HeroAccademia[userChoice - 1].CalculatedLevel();
                            break;

                        case 4:

                            //Mark hero from A to F
                            HeroAccademia[userChoice - 1].GivingHeroMarks();
                            break;

                        case 5:

                            //provides heros savings and the possible cookie gains
                            HeroAccademia[userChoice - 1].FinancialInfo();
                            break;

                        case 6:

                            //removing the hero from the district
                            Purvciems.removeHero(userChoice - 1);
                            menu2 = false;
                            break;

                        case 7:
                            menu2 = false;
                            break;

                        default:
                            Console.WriteLine("Please choose a valid option");
                            break;
                    }
                }
            }
            else if (superMenu == 'V')
            {
                bool menu3 = true;
                Purvciems.PrintListOfVillians();
                // user inputs which villian they choose
                int.TryParse(Console.ReadLine(), out int userChoice);
                
                while (menu3)
                {
                    //user chooses what to do with the Villian
                    VillianLigue[userChoice - 1].VillianIndeMenu();
                    int.TryParse(Console.ReadLine(), out int userChoice2);

                    switch (userChoice2)
                    {
                        case 1:
                            VillianLigue[userChoice - 1].PrintInfo();
                            break;
                        case 2:
                            VillianLigue[userChoice - 1].CalculateVLvl();
                            break;
                        case 3:
                            VillianLigue[userChoice - 1].CalculationCrimeTime();
                            break;
                        case 4:
                            Purvciems.RemoveVillian(userChoice - 1);
                            menu3 = false;
                            break;
                        case 5:
                            menu3 = false;
                            break;
                    }
                }
            }
            else if (superMenu == 'B')
            {

            }
            else
            {
                Console.WriteLine("Plase choose a valid options");
            }
            break;
    }
        case 'D':
            
            Purvciems.PrintCityInfo();
            Console.WriteLine($"The avarage lvl of heros in the district{Purvciems.Title} is: {Purvciems.CalculateLVLavarage()}");
            break;
    }
}
