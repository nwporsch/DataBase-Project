using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;

public class Connection
{
    private string connectionString;
    private SqlConnection cnn;

	public Connection()
	{
        connectionString = "Data Source:mssql.cs.ksu.edu;Initial Catalog:mdlier; Integrated Security=true";
        cnn = new SqlConnection(connectionString);
    }

    public OpenConnection()
    {
        cnn.Open(); 
    }

    public CloseConnection()
    {
        cnn.Close(); 
    }
}
