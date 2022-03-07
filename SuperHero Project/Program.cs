// See https://aka.ms/new-console-template for more information

string name = "SuperCat";
char gender = 'F';
int age = 33;
string power1, power2, power3;
power1 = "has 9 lives";
power2 = "can fight lazer pointers";
power3 = "walks without making a sound";
double salary = 1000;
bool IsEvil = false;
int deedTimeInHours1, deedTimeInHours2, deedTimeInHours3;

Console.WriteLine(" ~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-");
Console.WriteLine(" ===============================");
Console.WriteLine("            Hero");
Console.WriteLine(" ===============================");
Console.WriteLine();
Console.WriteLine($"    Hero Name: {name}");
Console.WriteLine($"    Hero Age: " + age);
Console.WriteLine($"    Hero Gender: {gender}");
Console.WriteLine($"    Hero Powers: {power1}; {power2}; {power3};");
Console.WriteLine(" ~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-");

// Superhero salary calculation

var workingHoursInDay = 10;
var hourlyrate = 10;
double monthlySalary;

if (workingHoursInDay > 0)
{
    if (workingHoursInDay <= 8)
    {
        monthlySalary = workingHoursInDay * hourlyrate;
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Console.WriteLine(value: $"     {name} salary is {monthlySalary}");

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }
    if (workingHoursInDay > 8)
    {
        monthlySalary = ((8 * hourlyrate) + ((workingHoursInDay - 8)*15));
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Console.WriteLine(value: $"     {name} salary is {monthlySalary}");

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }
}
else
{
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    Console.WriteLine("  You cannot work less than 1 hour");
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
}



// Cookie calculation

double cookieCost = 1.29;
double boughtCookies = Math.Floor(salary / cookieCost);
double dailySalary = Math.Round(salary / 30, 2);

deedTimeInHours1 = 5;
deedTimeInHours2 = 2;
deedTimeInHours3 = 3;

int totaldeedtime = deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3;
int avgdeedtime = totaldeedtime / 3;
int CookiesPerHour = 5;
int cookiesgot = CookiesPerHour * totaldeedtime;

Console.WriteLine(" ********* FINANCIAL INFO ********************");
Console.WriteLine($"    {name} spent {totaldeedtime} hours working");
Console.WriteLine($"    on avarage it takes {name} {avgdeedtime} hours to complete a task");
Console.WriteLine($"    {name} earned {cookiesgot}");
Console.WriteLine($"    {name} can buy {boughtCookies} cookies");
Console.WriteLine($"    {name} earns {dailySalary} daily");

if (!IsEvil)
{
    Console.WriteLine($"    {name} is ready to protect the city");
}
else
{
    Console.WriteLine($"{name} could have bought the cookies, but chose to steal them instead");
}