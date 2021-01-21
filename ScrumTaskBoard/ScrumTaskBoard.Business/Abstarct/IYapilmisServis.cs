using ScrumTaskBoard.Business.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBoard.Business.Abstarct
{
    public interface IYapilmisServis
    {
        List<YapilmisDTO> GetAll(string sqlSentence);
        void Add(string sqlSentence);
        void Update(string sqlSentence);
        void Delete(string sqlSentence);
        void Truncate(string sqlSentence);
    }
}
