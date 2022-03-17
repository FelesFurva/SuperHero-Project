using SuperHero_Project;

string[] SuperHero_Name = { "SuperCat", "DogMan", "TestPersone" };
char[] SuperHero_Gender = { 'F', 'M', '?' };
int[] SuperHero_Age = { 33, 27, 999 };
string[,] SuperHero_Powers = { { "has 9 lives", "can fight lazer pointers", "walks without making a sound" },
                               { "A true Bro", "will find anyting by scent","runs fast!"},
                               { "always happy to help", "can be the best to test", "always gone when you need and back when you call" } };

double[] SuperHero_Salary = { 0f, 0f, 0f }; //new double[3];
bool[] SuperHero_IsEvil = { false, false, false };

bool menu1 = true;

Console.WriteLine("Wellcome to the SuperHero application \n");

while (menu1)
{
    Console.WriteLine("Enter I if you would like to see all the heros on file");
    Console.WriteLine("Enter N to create a new file");
    Console.WriteLine("Enter Q to exit the application");

    char.TryParse(Console.ReadLine(), out char menuItem);
    menuItem = char.ToUpper(menuItem);

            
    if (menuItem == 'N')
    {
        Console.WriteLine("Please enter the super hero's name:");
        string HeroName = Console.ReadLine();
        SuperHero_Name = SuperHero_Name.Append(HeroName);
        
        Console.WriteLine("Please enter the super hero's Gender:");
        char.TryParse(Console.ReadLine(), out char HeroGender);
        SuperHero_Gender = SuperHero_Gender.Append(HeroGender);
        
        Console.WriteLine("Please enter the super hero's Age:");
        int.TryParse(Console.ReadLine(), out int HeroAge);
        SuperHero_Age = SuperHero_Age.Append(HeroAge);
        
        Console.WriteLine("Please enter the super hero's super power 1:");
        string HeroPower1 = Console.ReadLine();
        string HeroPower2 = Console.ReadLine();
        string HeroPower3 = Console.ReadLine();

        string[] tmp = new string[3];
        tmp[0] = HeroPower1;
        tmp[1] = HeroPower2;
        tmp[2] = HeroPower3;

        SuperHero_Powers = SuperHero_Powers.Append(tmp);

        Console.WriteLine("Is the hero evil?(don't worry, they won't know you told us)");
        bool.TryParse(Console.ReadLine(), out bool evilGood);
        SuperHero_IsEvil = SuperHero_IsEvil.Append(evilGood);

        Console.WriteLine($"SuperHero {HeroName} has been added to the raster");
    }
    else if (menuItem == 'Q')
    {
        Console.WriteLine("Goodbye! <3");
        menu1 = false;
    }
    else if (menuItem == 'I')
    {
        Console.WriteLine("Please select the file you would like to work with:\n");
        for (int i = 0; i < SuperHero_Name.Length; i++)
        {
            Console.WriteLine($"{(i + 1)} : {SuperHero_Name[i]}");
        }

        bool menu2 = true;

        // user inputs which hero they choose
        int.TryParse(Console.ReadLine(), out int userChoice);

        while (menu2)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine($"1. View {SuperHero_Name[userChoice - 1]} hero card");
            Console.WriteLine($"2. Calculate {SuperHero_Name[userChoice - 1]} salary");
            Console.WriteLine($"3. Rate {SuperHero_Name[userChoice - 1]} performance");
            Console.WriteLine($"4. Calculate the amount of cookies {SuperHero_Name[userChoice - 1]} can buy");
            Console.WriteLine($"5. Delete {SuperHero_Name[userChoice - 1]}'s file");
            Console.WriteLine("6. Go back.");

            //user inputs which action they choose
            int.TryParse(Console.ReadLine(), out int userChoice2);

            switch (userChoice2)
            {
                case 1:

                    // Super hero card 1
                    Console.WriteLine(" ~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-");
                    Console.WriteLine("    ===============================");
                    Console.WriteLine("            Hero");
                    Console.WriteLine("    ===============================");
                    Console.WriteLine();
                    Console.WriteLine($"    Hero Name:     {SuperHero_Name[userChoice - 1]}");
                    Console.WriteLine($"    Hero Age:      {SuperHero_Age[userChoice - 1]}");
                    Console.WriteLine($"    Hero Gender:   {SuperHero_Gender[userChoice - 1]}");

                    //loops through the available super powers
                    for (int i = 0; i < SuperHero_Powers.GetLength(1); i++)
                    {
                        Console.WriteLine(value: $"    Hero Power:    {SuperHero_Powers[userChoice - 1, i]}");
                    }

                    Console.WriteLine("");

                    //tells if the hero is evil or not
                    if (!SuperHero_IsEvil[userChoice - 1])
                    {
                        Console.WriteLine($"    {SuperHero_Name[userChoice - 1]} is ready to protect the city");
                    }
                    else
                    {
                        Console.WriteLine($"{SuperHero_Name[userChoice - 1]} could have bought the cookies, but chose to steal them instead");
                    }

                    Console.WriteLine(" ~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-");

                    break;

                case 2:

                    Console.WriteLine($"Input how many hours {SuperHero_Name[userChoice - 1]} spent on task 1:");

                    int.TryParse(Console.ReadLine(), out int deedTimeInHours1);

                    Console.WriteLine($"Input how many hours {SuperHero_Name[userChoice - 1]} spent on task 2:"); ;

                    int.TryParse(Console.ReadLine(), out int deedTimeInHours2);

                    Console.WriteLine($"Input how many hours {SuperHero_Name[userChoice - 1]} spent on task 3:");

                    int.TryParse(Console.ReadLine(), out int deedTimeInHours3);

                    int workingHoursInDay = deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3;
                    int avgdeedtime = workingHoursInDay / 3;

                    Console.WriteLine("Input hourly rate:");
                    int.TryParse(Console.ReadLine(), out int hourlyrate);

                    double dailysalary;
                    double monthlySalary;

                    if (workingHoursInDay <= 0)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine("  You cannot work less than 1 hour");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    }
                    else if (workingHoursInDay > 24)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine("  There are only 24 hours in one day!");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    }
                    else
                    {
                        Console.WriteLine($"    On avarage it takes {SuperHero_Name[userChoice - 1]} {avgdeedtime} hours to complete a task");
                        Console.WriteLine($"    {SuperHero_Name[userChoice - 1]} spent {workingHoursInDay} hours working");

                        if (workingHoursInDay <= 8)
                        {
                            dailysalary = workingHoursInDay * hourlyrate;
                            Console.WriteLine(value: $"    {SuperHero_Name[userChoice - 1]} earned {dailysalary} today");
                            monthlySalary = dailysalary * 30;
                            Console.WriteLine(value: $"    {SuperHero_Name[userChoice - 1]} monthly salary would be {monthlySalary}");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            SuperHero_Salary[userChoice - 1] += monthlySalary;
                        }
                        if (workingHoursInDay > 8)
                        {
                            dailysalary = ((8 * hourlyrate) + ((workingHoursInDay - 8) * 15));
                            Console.WriteLine(value: $"    {SuperHero_Name[userChoice - 1]} earned {dailysalary} today");
                            monthlySalary = dailysalary * 30;
                            Console.WriteLine(value: $"    {SuperHero_Name[userChoice - 1]} monthly salary would be {monthlySalary}");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            SuperHero_Salary[userChoice - 1] += monthlySalary;
                        }
                    }
                    break;

                case 3:
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
                    break;

                case 4:
                    double money = SuperHero_Salary[userChoice - 1];
                    double cookieCost = 1.29;
                    double boughtCookies = Math.Floor(money / cookieCost);

                    Console.WriteLine(" ************** FINANCIAL INFO **************");
                    Console.WriteLine($"    {SuperHero_Name[userChoice - 1]} has {money} in his account \n");
                    Console.WriteLine($"    {SuperHero_Name[userChoice - 1]} can buy {boughtCookies} cookies \n");
                    break;

                case 5:
                    Console.WriteLine("Are you sure you would like to remove SuperHero_Name[userChoice - 1] file?");
                    Console.WriteLine("Y for yes");
                    Console.WriteLine("N for no");
                    char.TryParse(Console.ReadLine(), out char userChoice3);

                    if (userChoice3 == 'Y')
                    {
                        SuperHero_Name = SuperHero_Name.Remove(userChoice - 1);
                        menu2 = false;
                    }
                    else
                    {
                        Console.WriteLine("Don't worry we won't");
                    }
                    break;

                case 6:
                    menu2 = false;
                    break;

                default:
                    Console.WriteLine("Please choose a valid option");
                    break;
            }
        }
    }
}
