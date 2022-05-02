using SuperHero_Project;
using System.Collections.Generic;
using System.Data.SqlClient;

bool mainmenu = true;
bool menu1 = true;

DBConnection dBConnection = new DBConnection();
PowersManager powersManager = new PowersManager(dBConnection);
PersonManager personManager = new PersonManager(dBConnection, powersManager);
DistrictManager districtManager = new DistrictManager(dBConnection, personManager);

var Riga = districtManager.GetAllDistricts();
districtManager.GetPeoplebyDistrict(Riga);

var AllHeros = personManager.GetAllHerosorVillains("Hero");
List<Hero> HeroAccademia = AllHeros.OfType<Hero>().ToList();

var AllVillians = personManager.GetAllHerosorVillains("Villian");
List<Villian> VillainLigue = AllVillians.OfType<Villian>().ToList();

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

                for (int i = 0; i < AllHeros.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {AllHeros[i].PersonNickname}");
                }
                
                // user inputs which hero they choose
                int.TryParse(Console.ReadLine(), out int HeroIndex);

                do
                {
                    HeroAccademia[HeroIndex - 1].HeroIndexMenu();

                    //user inputs which action they choose
                    int.TryParse(Console.ReadLine(), out int HmenuChoice);

                    DeedManager deedManager = new DeedManager(dBConnection);
                    int DeedCount = 0;
                    List<Deed> HeroDeeds = deedManager.GetDeedbyID(HeroAccademia[HeroIndex - 1].HeroID);
                    foreach (var deed in HeroDeeds)
                    {
                        DeedCount++;
                    }

                    switch (HmenuChoice)
                    {
                        case 1:
                            HeroAccademia[HeroIndex - 1].PrintHeroInfo();
                            
                            List<SuperPowers> HeroPowers = powersManager.GetHeroPowersbyID(HeroAccademia[HeroIndex - 1].HeroID);
                            foreach(var power in HeroPowers)
                            {
                                Console.WriteLine($"    {power.PowerName} : {power.PowerDescription}");
                            }
                            break;
                        case 2:
                            HeroAccademia[HeroIndex - 1].SalaryCalculation(DeedCount);
                            break;
                        case 3:
                            HeroAccademia[HeroIndex - 1].CalculateLevel(DeedCount);
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
                for (int i = 0; i < AllVillians.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {AllVillians[i].PersonNickname}");
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
                            
                            List<SuperPowers> VillainPowers = powersManager.GetHeroPowersbyID(VillainLigue[VilIndex - 1].VillainID);
                            foreach (var power in VillainPowers)
                            {
                                Console.WriteLine($"{power.PowerName} : {power.PowerDescription}");
                            }
                            break;
                        case 2:
                            VillainLigue[VilIndex - 1].CalculateVillainLvl();
                            break;
                        case 3:
                            VillainLigue[VilIndex - 1].CalculationCrimeTime();
                            break;
                        case 4:
                            //Purvciems.RemoveVillian(VilIndex - 1);
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
                
                for (int i = 0; i < Riga.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Riga[i].Title}");
                }
                bool Distmenu = true;
                int.TryParse(Console.ReadLine(), out int DistrictChoice);
                do
                {
                    Riga[DistrictChoice - 1].DistrictMenu();

                    char.TryParse(Console.ReadLine(), out char menuItem);
                    menuItem = char.ToUpper(menuItem);

                    int DistrictID = Riga[DistrictChoice - 1].DistrictID;
                    var Everyone = personManager.GetAllPeopleinDistrict(DistrictID).ToList();

                    var Hero = personManager.GetAllPeopleinDistrictbyType(DistrictID, "Hero").ToList();
                    List<Hero> DistrictHeroes = Hero.OfType<Hero>().ToList();
                    var Villian = personManager.GetAllPeopleinDistrictbyType(DistrictID, "Villian").ToList();
                    List<Villian> DistrictVillianes = Villian.OfType<Villian>().ToList();

                    switch (menuItem)
                    {
                        case 'D':
                            Riga[DistrictChoice - 1].PrintCityInfo();
                            Riga[DistrictChoice - 1].PrintListOfHeroes(DistrictHeroes);
                            Riga[DistrictChoice - 1].PrintListOfVillians(DistrictVillianes);
                            Console.WriteLine($"\nThe avarage lvl of heros in the district {Riga[DistrictChoice - 1].Title} is: {Riga[DistrictChoice - 1].CalculateLVLavarage(Hero)}");
                            Riga[DistrictChoice - 1].MaxHeroandVillianLVL(DistrictHeroes, DistrictVillianes);
                            Riga[DistrictChoice - 1].CrimeTimeCalculator(DistrictVillianes);
                            break;

                        case 'N':

                            Console.WriteLine("Which hero would you like to add: ");
                            for (int i = 0; i < HeroAccademia.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {HeroAccademia[i].PersonNickname}");
                            }
                            int.TryParse(Console.ReadLine(), out int addedhero);

                            personManager.InsertIntoDistrict(Riga[DistrictChoice - 1].DistrictID, HeroAccademia[addedhero - 1].HeroID);
                            break;
                        case 'V':
                            Console.WriteLine("Which hero would you like to add: ");
                            for (int i = 0; i < VillainLigue.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {VillainLigue[i].PersonNickname}");
                            }
                            int.TryParse(Console.ReadLine(), out int addedvillain);

                            personManager.InsertIntoDistrict(Riga[DistrictChoice - 1].DistrictID, VillainLigue[addedvillain - 1].VillainID);
                            break;

                        case 'S':
                            Riga[DistrictChoice - 1].HeroSearch();
                            break;
                        case 'R':
                            Riga[DistrictChoice - 1].RemovePerson(); //not working yet
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
                foreach (District district in Riga)
                {
                    int DistrictID = district.DistrictID;
                    List<Person> HeroinDistrict = personManager.GetAllPeopleinDistrictbyType(DistrictID, "Hero").ToList();
                float AvrgLVL = district.CalculateLVLavarage(HeroinDistrict);
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