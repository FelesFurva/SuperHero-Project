using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SuperHero_Project
{
    public class DBConnection
    {
        string Datasource { get; set; }//your server
        string Database { get; set; } //your database name
        string ConnString { get; set; }
        public SqlConnection Conn { get; set; }

        public DBConnection()
        {
            Console.WriteLine("Getting Connection ...");
            Datasource = @"WINDOWS-TFE0AK8";
            Database = "SuperHeroProject";
            ConnString = @$"Server={Datasource};Database={Database};Trusted_Connection=True;";
            Conn = new SqlConnection(ConnString);
            try
            {
                Conn.Open();
                Console.WriteLine("Connection created");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }
    }
}
