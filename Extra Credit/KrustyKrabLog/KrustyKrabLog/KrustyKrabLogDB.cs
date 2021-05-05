using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrustyKrabLog
{
    public class KrustyKrabLogDB
    {
        private static string connectionString = "server=localhost;user=root;database=krustykrablogdb;port=3306;password=yourpassword";
        /// <summary>
        /// Fet all Information from database
        /// </summary>
        /// <returns></returns>
        public static List<Information> getAllInformation()
        {
            List<Information> allInformation = new List<Information>();
            try
            {
                string query = "SELECT* from information";
                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    allInformation.Add(new Information(int.Parse(mySqlDataReader[0].ToString()),
                        DateTime.Parse(mySqlDataReader[1].ToString()), mySqlDataReader[2].ToString(),
                        mySqlDataReader[3].ToString(), mySqlDataReader[4].ToString()));
                }
                mySqlConnection.Close();

            }
            catch{}
            return allInformation;
        }

        /// <summary>
        /// insert Information
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="name"></param>
        /// <param name="supervisor"></param>
        /// <param name="notes"></param>
        public static void insertInformation(int id, DateTime date, string name, string supervisor, string notes)
        {
            try
            {
                string query = "insert into krustykrablogdb.information(ID,Date,Name,Supervisor,Note) values('" +
                    id + "','" + date.ToString("yyyy-MM-dd") + "','" + name + "','" + supervisor + "','" + notes + "');";
                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                mySqlConnection.Open();
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch{ }
        }

        /// <summary>
        /// Update Information
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="name"></param>
        /// <param name="supervisor"></param>
        /// <param name="notes"></param>
        public static void updateInformation(int id, DateTime date, string name, string supervisor, string notes)
        {
            
            try
            {
                string query = "update krustykrablogdb.information set Date='" + date.ToString("yyyy-MM-dd") +
                        "',Name='" + name + "',Supervisor='" + supervisor + "',Note='" + notes + "' where ID='" + id + "';";
                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                mySqlConnection.Open();
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch { }
        }
    }
}
