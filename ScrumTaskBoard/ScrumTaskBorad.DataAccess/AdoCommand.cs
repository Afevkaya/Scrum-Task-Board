using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBorad.DataAccess
{
    public class AdoCommand
    {
        AdoConnection connection = new AdoConnection();
        public SqlCommand sqlCommand(string sqlSentence)
        {
            SqlCommand command = new SqlCommand(sqlSentence,connection.sqlConnectionOpen());
            return command;
        }
    }
}
