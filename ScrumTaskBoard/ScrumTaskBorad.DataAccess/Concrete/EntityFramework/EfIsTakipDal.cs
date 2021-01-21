using ScrumTaskBoard.Entities.Concrete;
using ScrumTaskBorad.DataAccess.Abstarct;
using ScrumTaskBorad.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBorad.DataAccess.Concrete.EntityFramework
{
    public class EfIsTakipDal : EfEntityRepositoryBase<IsTakip, ScrumTaskBoardDb2Context>, IIsTakipDal
    {
       
    }
}
