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
    public class YapilmisManager:IYapilmisServis
    {
        AdoConnection adoConnection = new AdoConnection();
        AdoCommand adoCommand = new AdoCommand();
        SqlCommand command;

        public List<YapilmisDTO> GetAll(string sqlSentence)
        {
            command = adoCommand.sqlCommand(sqlSentence);
            SqlDataReader reader = command.ExecuteReader();
            List<YapilmisDTO> ypdto = new List<YapilmisDTO>();
            while (reader.Read())
            {
                ypdto.Add(new YapilmisDTO
                { 
                    YapilmisId = Convert.ToInt32(reader["YapilmisId"]),
                    YapilmisKart = reader["YapilmisKart"].ToString()
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
