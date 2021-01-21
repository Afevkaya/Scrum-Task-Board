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
    
    public class YapilacakManager : IYapilacakServis
    {
        AdoConnection adoConnection = new AdoConnection();
        AdoCommand adoCommand = new AdoCommand();
        SqlCommand command;
        
        public List<YapilacakDTO> GetAll(string sqlSentence)
        {
            command = adoCommand.sqlCommand(sqlSentence);
            SqlDataReader reader = command.ExecuteReader();
            List<YapilacakDTO> ypdto = new List<YapilacakDTO>();
            while (reader.Read())
            {
                ypdto.Add(new YapilacakDTO
                {
                    YapilacakId = Convert.ToInt32(reader["YapilacakId"]),
                    YapilacakKart = reader["YapilacakKart"].ToString()
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
