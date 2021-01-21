using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBoard.Business.Abstarct
{
    public interface IKartService
    {
        List<Kart> GetAll();
        void Add(Kart kart);
        void Update(Kart kart);
        void Delete(Kart kart);
        
    }
}
