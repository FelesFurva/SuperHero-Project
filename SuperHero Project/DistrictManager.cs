using System.Data.SqlClient;

namespace SuperHero_Project
{
    internal class DistrictManager
    {
        private DBConnection Connection;
        private PersonManager PersonManager;

        public DistrictManager(DBConnection connection, PersonManager personManager)
        {
            Connection = connection;
            PersonManager = personManager;
        }


        public List<District> GetAllDistricts()
        {
            string query2 = $"Select * from District";
            List<District> districts = new List<District>();
            try
            {
                SqlCommand cmd = new SqlCommand(query2, Connection.Conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        int DistrictID = Convert.ToInt32(reader["DistrictID"]);
                        var district = new District(reader["DistrictTitle"].ToString(), reader["CityName"].ToString(), DistrictID);
                        districts.Add(district);
                    }
                    Console.WriteLine("GetAllDistricts command executed");
                    reader.Close();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e.Message);
            }
            return districts;
        }

        public void GetPeoplebyDistrict(List<District> districts)
        {
            foreach (District district in districts)
            {
                var people = PersonManager.GetAllPeopleinDistrict(district.DistrictID);
                district.People = people;
            }
        }
    }
}
