using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MobileBank.Classes
{
    internal class DataBaseConnection
    {
        SqlConnection sqlconnection = new SqlConnection(@"Server=tcp:mobilebank.database.windows.net,1433;Initial Catalog=MobileBank;Persist Security Info=False;User ID=master;Password={medionxbox360$};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public void openConnection()
        {
            if(sqlconnection.State == System.Data.ConnectionState.Closed) 
            {
                sqlconnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlconnection.State == System.Data.ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlconnection;
        }
    }

    
}
//DESKTOP-97JHR07