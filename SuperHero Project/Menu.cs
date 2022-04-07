using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Project
{
    public static class Menu
    {
        public static void MainMenu()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("What would you like to do Today?\n");
            Console.WriteLine("1. View a list of heros");
            Console.WriteLine("2. View a list of villians");
            Console.WriteLine("3. View a list of Districts");
            Console.WriteLine("4. View the district with the heighst ");
            Console.WriteLine("5. Exit SuperHero application \n");
        }
    }
}
