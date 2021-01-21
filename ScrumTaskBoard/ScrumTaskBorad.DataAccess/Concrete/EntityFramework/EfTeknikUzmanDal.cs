using ScrumTaskBoard.Entities.Concrete;
using ScrumTaskBorad.DataAccess.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBorad.DataAccess.Concrete.EntityFramework
{
    public class EfTeknikUzmanDal: EfEntityRepositoryBase<TeknikUzman, ScrumTaskBoardDb2Context>,ITeknikUzmanDal
    {
    }
}
