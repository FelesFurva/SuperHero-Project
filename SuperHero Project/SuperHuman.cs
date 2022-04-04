using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Project
{
    internal class SuperHuman
    {
        private string Name;
        private string Surname;
        public string Nickname { get; set; }
        public char Gender { get; set; }
        public int Age { get; set; }
        string[] Powers = new string[3];
        public double Salary { get; set; }
        public int LVL { get; set; }

        public SuperHuman()
        {
            Name = "unknown";
            Surname = "unknown";
            Nickname = "unknown";
            Gender = '?';
            Age = 0;
            Powers = new string[3];
            Salary = 0;
            LVL = 0;
        }

        public SuperHuman(string name,
                 string surname,
                 string nickname,
                 char gender,
                 int age,
                 string Powers1,
                 string Powers2,
                 string Powers3,
                 double salary,
                 int lVL)
        {

            Name = name;
            Surname = surname;
            Nickname = nickname;
            Gender = gender;
            Age = age;
            Powers[0] = Powers1;
            Powers[1] = Powers2;
            Powers[2] = Powers3;
            Salary = salary;
            LVL = lVL;
        }



        public virtual void PrintInfo()
        {
            Console.WriteLine(" ~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-");
            Console.WriteLine("   ================================");
            Console.WriteLine("            File");
            Console.WriteLine("   ================================");
            Console.WriteLine();
            Console.WriteLine($"    Nickname:           {Nickname}");
            Console.WriteLine($"    Age:                {Age}");
            Console.WriteLine($"    Gender:             {Gender}");
            Console.WriteLine($"    LVL:                {LVL}");

            //loops through the available super powers
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(value: $"    Hero Power:         {Powers[i]}");
            }
            Console.WriteLine("");

        }

    }


}
