using System.Data.SqlClient;

namespace SuperHero_Project
{
    internal class DeedManager
    {
        private DBConnection Connection;

        public DeedManager(DBConnection connection)
        {
            Connection = connection;
        }

        public List<Deed> GetDeedbyID(int PersonID)
        {
            string query2 = $"Select d.DeedID, d.PeopleAffected, d.DistrictID, d.PowerID from Deed d " +
                $"Join SuperPower sp on d.PowerID = sp.PowerID " +
                $"Join Person p on sp.PersonID = p.PersonID where p.PersonID = '{PersonID}'";
            List<Deed> HeroDeeds = new List<Deed>();
            try
            {
                SqlCommand cmd = new SqlCommand(query2, Connection.Conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int DeedID = Convert.ToInt32(reader["DeedID"]);
                        int PeopleAffected = Convert.ToInt32(reader["PeopleAffected"]);
                        int PowerID = Convert.ToInt32(reader["PowerID"]);
                        var deed = new Deed(DeedID, PeopleAffected, PowerID);
                        HeroDeeds.Add(deed);

                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e.Message);
            }
            return HeroDeeds;
        }

    }
}
