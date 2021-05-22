using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrustyKrabLog
{
    public class KrustyKrabLogDB
    {
        ////4-27-2021 Saung NEW 5L : change this connection string according to your settings.
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\KrustyKrabLogDB.mdf;Integrated Security=True;Connect Timeout=30";
        ////4-27-2021 Saung NEW 5L :private static string connectionString  = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=KrustyKrabLogDB;Integrated Security=true;";
        /// <summary>
        /////4-27-2021 Saung NEW 5L :  Fet all Information from database
        /// </summary>
        /// <returns></returns>
        public static List<Information> getAllInformation()
        {
            List<Information> allInformation = new List<Information>();
            try
            {
                string query = "SELECT* from Information";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    allInformation.Add(new Information(int.Parse(sqlDataReader[0].ToString()),
                        DateTime.Parse(sqlDataReader[1].ToString()), sqlDataReader[2].ToString(),
                        sqlDataReader[3].ToString(), sqlDataReader[4].ToString()));
                }
                sqlConnection.Close();

            }
            catch{}
            return allInformation;
        }

        /// <summary>
        /////4-27-2021 Saung NEW 5L : insert Information
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
                string query = "insert into Information(ID,Date,Name,Supervisor,Note) values('" +
                    id + "','" + date.ToString("yyyy-MM-dd") + "','" + name + "','" + supervisor + "','" + notes + "');";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch{ }
        }

        /// <summary>
        /////4-27-2021 Saung NEW 5L : Update Information
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
                string query = "update Information set Date='" + date.ToString("yyyy-MM-dd") +
                        "',Name='" + name + "',Supervisor='" + supervisor + "',Note='" + notes + "' where ID='" + id + "';";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch { }
        }
    }
}
