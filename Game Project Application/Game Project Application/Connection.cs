using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Game_Project_Application
{
    public class Connection
    {
        private string connectionString;
        private SqlConnection cnn;

        public Connection()
        {
            connectionString = "Data Source:mssql.cs.ksu.edu;Initial Catalog:mdlier; Integrated Security=true";
            cnn = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            cnn.Open();
        }

        public void CloseConnection()
        {
            cnn.Close();
        }
    }
}

