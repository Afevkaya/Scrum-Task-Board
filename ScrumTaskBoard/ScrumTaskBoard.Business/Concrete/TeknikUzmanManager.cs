using ScrumTaskBoard.Business.Abstarct;
using ScrumTaskBoard.Entities.Concrete;
using ScrumTaskBorad.DataAccess.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBoard.Business.Concrete
{
    public class TeknikUzmanManager : ITeknikUzmanServis
    {
        private ITeknikUzmanDal _teknikUzmanDal;

        public TeknikUzmanManager(ITeknikUzmanDal teknikUzmanDal)
        {
            _teknikUzmanDal = teknikUzmanDal;
        }

        public List<TeknikUzman> GetAll()
        {
            return _teknikUzmanDal.GetAll();
        }

        public List<TeknikUzman> GetSureByTeknikUzman(int teknikUzmanId)
        {
            return _teknikUzmanDal.GetAll(t => t.TeknikUzmanId == teknikUzmanId).ToList();
        }
    }
}
