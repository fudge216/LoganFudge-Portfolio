using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeopardy_final
{
    
    //Was unable to serialize the data but this class adds the scores into the DB and then puts the DB rows into a list
    
    
    [Serializable]
    public class Serialization
    {
        
        // Sets up sql variables 
        
        private string scores;
        private string connectionString;
        private SqlConnection sconnection;

        private SqlCommand sqlCmd;
        private string Cmd;

        private SqlDataReader dbReader;

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public SqlConnection sConnection { get => sconnection; set => sconnection = value; }
        public SqlCommand SqlCommand { get => sqlCmd; set => sqlCmd = value; }
        public string Command { get => Cmd; set => Cmd = value; }
        public SqlDataReader DBReader { get => dbReader; set => dbReader = value; }
        public string Scores { get => scores; set => scores = value; }

        // Serialize adds the finished game value to the DB by inserting it into the DB
        // the game is the string of the finished game added to the DB as a parameter

        public void Serialize(string game)
        {
            connectionString = "Data Source=stusql-cis151-101-fa21.cimq4ah3jd04.us-east-2.rds.amazonaws.com,1433; Initial Catalog=lf0898278; User Id=lf0898278; Password=898278;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String query = "INSERT INTO Jeopardy_Scores (Scores) VALUES (@scores)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@scores",game);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }
            }
        }
      
        // connect to the DB via my DB creds if it fails then it throws an exception 
        // disconnect closes the connection to the DB
        public void Connect()
        {
            connectionString = "Data Source=";//Pulled from a private school server


            sConnection = new SqlConnection(connectionString);

            try
            {
                sConnection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Disconnect()
        {
            try
            {
                sConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        public List<string> Old_Scores()
        {
            
            List<string> Old_Scores = new List<string>();
            
            Connect();
            Cmd = "SELECT * From Jeopardy_Scores ";
            sqlCmd = new SqlCommand(Cmd);

            //creates a new connection with the give string to run for the Jeopardy_Scores table
            sqlCmd.Connection = sConnection;

            //Set up the DB reader
            dbReader = sqlCmd.ExecuteReader();

            // while the reader reads it gets data from the data base to put into the Old_Scores list and returns it
            while (dbReader.Read())
            {


                var myString = dbReader.GetString(0);
                Old_Scores.Add(myString);
             


            }

            Disconnect();

            return Old_Scores;
        }


    }
}
