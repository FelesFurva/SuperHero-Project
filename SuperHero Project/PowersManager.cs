using System.Data.SqlClient;
//works fine for now
namespace SuperHero_Project
{
    public class PowersManager
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

        public void AddAllPowers()
        {

            List<SuperPowers> superPowers = new List<SuperPowers>();
 

            try
            {
                foreach (var superPower in superPowers)
                {
                    string query = $"INSERT INTO SuperPower (PowerName,PowerDescription,PersonID) VALUES('{superPower.PowerName}', '{superPower.PowerDescription}', '{superPower.PersonID}'); ";
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
