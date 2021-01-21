using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBorad.DataAccess
{
    public class AdoConnection
    {
        SqlConnection connection = new SqlConnection("Data Source=Enes;Initial Catalog=ScrumTaskBoardDb2;Integrated Security=True");
        public SqlConnection sqlConnectionOpen()
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
            {
                connection.Open();
            }
            
            return connection;
        }
        public SqlConnection sqlConnectionClose()
        {
            connection.Close();
            return connection;
        }
    }
}
