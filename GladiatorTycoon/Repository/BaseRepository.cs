using MySql.Data.MySqlClient;
using System.Data;

namespace GladiatorTycoon.Repository
{
    public class BaseRepository<T>
    {
        private static MySqlConnection dbConn;

        public BaseRepository()
        {

        }

        public DataTable GetData(string query)
        {
            var builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "password";
            builder.Database = "gladiator_tycoon";

            var connectionString = builder.ToString();
            builder = null;

            dbConn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            return GetDataTable(query, cmd);
        }

        public void SaveData(string query)
        {
            var builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "password";
            builder.Database = "gladiator_tycoon";

            var connectionString = builder.ToString();
            builder = null;

            dbConn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }

        private DataTable GetDataTable(string query, MySqlCommand cmd)
        {
            var dataTable = new DataTable();
            var dataSet = new DataSet();
            var dataAdapter = new MySqlDataAdapter { SelectCommand = cmd };

            dataAdapter.Fill(dataSet);
            dataTable = dataSet.Tables[0];
            return dataTable;
        }

    }
}
