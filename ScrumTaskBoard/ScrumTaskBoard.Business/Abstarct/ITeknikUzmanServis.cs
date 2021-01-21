using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBoard.Business.Abstarct
{
    public interface ITeknikUzmanServis
    {
        List<TeknikUzman> GetAll();
        List<TeknikUzman> GetSureByTeknikUzman(int TeknikUzmanId);
    }
}
