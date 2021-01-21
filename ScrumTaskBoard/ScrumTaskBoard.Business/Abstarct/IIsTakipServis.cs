using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBoard.Business.Abstarct
{
    public interface IIsTakipService
    {
        List<IsTakip> GetAll();
        void Add(IsTakip isTakip);
        void Update(IsTakip isTakip);
        void Delete(IsTakip isTakip);
        List<IsTakip> GetIsTakipByKart(int kartId);
    }
}
