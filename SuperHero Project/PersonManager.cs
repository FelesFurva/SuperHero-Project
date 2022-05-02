using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SuperHero_Project
{
    public class PersonManager
    {
        private DBConnection Connection;

        public PersonManager(DBConnection connection)
        {
            Connection = connection;
        }

        public List<Person> GetAllPeopleinDistrict(int DistritcID)
        {
            string query2 = $"Select * from Person p Where DistrictID = '{DistritcID}'";

            List<Person> Allpeople = new List<Person>();
            try
            {
                SqlCommand cmd = new SqlCommand(query2, Connection.Conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var person = new Person(
                            reader["PersonName"].ToString(),
                            reader["PersonSurname"].ToString(),
                            reader["PersoneNickname"].ToString(),
                            Convert.ToInt32(reader["PersonAge"]),
                            Convert.ToDouble(reader["PersoneSalary"]),
                            Convert.ToInt32(reader["PersonLVL"]),
                            reader["PersoneType"].ToString());
                        Allpeople.Add(person);

                    }
                    Console.WriteLine("GetProductsByCategoryId command executed");
                    reader.Close();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e.Message);
            }
            return Allpeople;
        }

        public List<Person> GetAllPeopleinDistrictbyType(int DistritcID, string PersonType)
        {
            string query2 = $"Select * from Person p Where DistrictID = '{DistritcID}' and PersoneType = '{PersonType}'";

            List<Person> people = new List<Person>();
            try
            {
                SqlCommand cmd = new SqlCommand(query2, Connection.Conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (PersonType == "Hero")
                        {
                            var hero = new Hero(
                                reader["PersonName"].ToString(),
                                reader["PersonSurname"].ToString(),
                                reader["PersoneNickname"].ToString(),
                                Convert.ToInt32(reader["PersonID"]),
                                Convert.ToInt32(reader["PersonAge"]),
                                Convert.ToDouble(reader["PersoneSalary"]),
                                Convert.ToInt32(reader["PersonLVL"]),
                                reader["PersoneType"].ToString());
                            people.Add(hero);
                        }
                        if (PersonType == "Villian")
                        {
                            var villian = new Villian(
                                reader["PersonName"].ToString(),
                                reader["PersonSurname"].ToString(),
                                reader["PersoneNickname"].ToString(),
                                Convert.ToInt32(reader["PersonID"]),
                                Convert.ToInt32(reader["PersonAge"]),
                                Convert.ToDouble(reader["PersoneSalary"]),
                                Convert.ToInt32(reader["PersonLVL"]),
                                reader["PersoneType"].ToString());
                            people.Add(villian);
                        }
                    }
                    Console.WriteLine("GetProductsByCategoryId command executed");
                    reader.Close();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e.Message);
            }
            return people;
        }


        public List<Person> GetAllHerosorVillains(string PersonType)
        {
            string query2 = $"Select * from Person p Where PersoneType = '{PersonType}'";

            List<Person> AllHeros = new List<Person>();
            try
            {
                SqlCommand cmd = new SqlCommand(query2, Connection.Conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (PersonType == "Hero")
                        {
                            var hero = new Hero(
                                reader["PersonName"].ToString(),
                                reader["PersonSurname"].ToString(),
                                reader["PersoneNickname"].ToString(),
                                Convert.ToInt32(reader["PersonID"]),
                                Convert.ToInt32(reader["PersonAge"]),
                                Convert.ToDouble(reader["PersoneSalary"]),
                                Convert.ToInt32(reader["PersonLVL"]),
                                reader["PersoneType"].ToString());
                            AllHeros.Add(hero);
                        }
                        if (PersonType == "Villian")
                        {
                            var villian = new Villian(
                                reader["PersonName"].ToString(),
                                reader["PersonSurname"].ToString(),
                                reader["PersoneNickname"].ToString(),
                                Convert.ToInt32(reader["PersonID"]),
                                Convert.ToInt32(reader["PersonAge"]),
                                Convert.ToDouble(reader["PersoneSalary"]),
                                Convert.ToInt32(reader["PersonLVL"]),
                                reader["PersoneType"].ToString());
                            AllHeros.Add(villian);
                        }
                    }
                    Console.WriteLine("GetProductsByCategoryId command executed");
                    reader.Close();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e.Message);
            }
            return AllHeros;
        }

        public void AutoAddHeros()
        {


            List<Person> heroes = new List<Person>();

            try
            {
                foreach (var person in heroes)
                {
                    string query = $"INSERT INTO Person (PersonName, PersonSurname, PersoneNickname, PersonAge, PersonLVL, PersoneType, PersoneSalary) VALUES('{person.PersonName}', '{person.PersonSurname}', '{person.PersonNickname}', '{person.PersonAge}', '{person.PersonLVL}', '{person.PersonType}', '{person.PersonSalary}'); ";
                    SqlCommand cmd = new SqlCommand(query, Connection.Conn);
                    var number = cmd.ExecuteNonQuery();
                    Console.WriteLine("Rows affected : " + number);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
           


        }

    }
}
