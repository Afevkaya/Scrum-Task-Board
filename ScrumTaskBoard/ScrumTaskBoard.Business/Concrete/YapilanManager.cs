using ScrumTaskBoard.Business.Abstarct;
using ScrumTaskBoard.Business.DTO;
using ScrumTaskBorad.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBoard.Business.Concrete
{
    public class YapilanManager:IYapilanServis
    {
        AdoConnection adoConnection = new AdoConnection();
        AdoCommand adoCommand = new AdoCommand();
        SqlCommand command;

        public List<YapilanDTO> GetAll(string sqlSentence)
        {
            command = adoCommand.sqlCommand(sqlSentence);
            SqlDataReader reader = command.ExecuteReader();
            List<YapilanDTO> ypdto = new List<YapilanDTO>();
            while (reader.Read())
            {
                ypdto.Add(new YapilanDTO
                {
                    YapilanId = Convert.ToInt32(reader["YapilanId"]),
                    YapilanKart = reader["YapilanKart"].ToString()
                });
            }
            adoConnection.sqlConnectionClose();
            return ypdto;
        }

        public void Add(string sqlSentence)
        {
            command = adoCommand.sqlCommand(sqlSentence);
            command.ExecuteNonQuery();
            adoConnection.sqlConnectionClose();
        }

        public void Update(string sqlSentence)
        {
            command = adoCommand.sqlCommand(sqlSentence);
            command.ExecuteNonQuery();
            adoConnection.sqlConnectionClose();
        }

        public void Delete(string sqlSentence)
        {
            command = adoCommand.sqlCommand(sqlSentence);
            command.ExecuteNonQuery();
            adoConnection.sqlConnectionClose();
        }

        public void Truncate(string sqlSentence)
        {
            command = adoCommand.sqlCommand(sqlSentence);
            command.ExecuteNonQuery();
            adoConnection.sqlConnectionClose();
        }
    }
}
