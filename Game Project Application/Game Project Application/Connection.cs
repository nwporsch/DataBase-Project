using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Game_Project_Application
{
    public class Connection
    {
        private string connectionString;
        private SqlConnection cnn;

        public Connection()
        {
            connectionString = "Data Source:mssql.cs.ksu.edu;Initial Catalog:mdlier; Integrated Security=true";
            //connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=GameStore;Integrated Security=SSPI;";
            try
            {
                cnn = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            
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

