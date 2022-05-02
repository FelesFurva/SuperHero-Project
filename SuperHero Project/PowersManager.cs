using System.Data.SqlClient;
//works fine for now
namespace SuperHero_Project
{
    internal class PowersManager
    {
        private DBConnection Connection;

        public PowersManager(DBConnection connection)
        {
            Connection = connection;
        }

        public List<SuperPowers> GetHeroPowersbyID(int PersonID)
        {
            string query2 = $"Select * from SuperPower sp Where PersonID = '{PersonID}'";
            List<SuperPowers> HeroPowers = new List<SuperPowers>();
            try
            {
                SqlCommand cmd = new SqlCommand(query2, Connection.Conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int PowerID = Convert.ToInt32(reader["PowerID"]);
                        int PersID = Convert.ToInt32(reader["PersonID"]);
                        var power = new SuperPowers(PowerID, reader["PowerName"].ToString(), reader["PowerDescription"].ToString(), PersonID);
                        HeroPowers.Add(power);

                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e.Message);
            }
            return HeroPowers;
        }

        

        }

}
