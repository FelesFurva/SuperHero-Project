using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Project
{
    public class Person
    {
        public string PersonName;
        public string PersonSurname;
        public string PersonNickname { get; set; }
        public int PersonAge { get; set; }
        List<string> Powers { get; set; }
        public double PersonSalary { get; set; }
        public int PersonLVL { get; set; }
        public string PersonType { get; set; }

        public Person()
        {
            PersonName = "unknown";
            PersonSurname = "unknown";
            PersonNickname = "unknown";
            PersonAge = 0;
            PersonSalary = 0;
            PersonLVL = 0;
            PersonType = "unknown";
        }

        public Person(string name,
                 string surname,
                 string nickname,
                 int age,
                 double salary,
                 int lVL,
                 string personType)
        {

            PersonName = name;
            PersonSurname = surname;
            PersonNickname = nickname;
            PersonAge = age;
            PersonSalary = salary;
            PersonLVL = lVL;
            PersonType = personType;
        }


        public virtual void PrintHeroInfo()
        {
            Console.WriteLine(" ~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-");
            Console.WriteLine("   ================================");
            Console.WriteLine("            File");
            Console.WriteLine("   ================================");
            Console.WriteLine();
            Console.WriteLine($"    Nickname:           {PersonNickname}");
            Console.WriteLine($"    Age:                {PersonAge}");
            Console.WriteLine($"    LVL:                {PersonLVL}");
        }



    }


}
