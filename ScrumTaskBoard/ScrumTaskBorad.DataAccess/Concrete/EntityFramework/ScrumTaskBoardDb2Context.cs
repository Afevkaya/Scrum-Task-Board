using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBorad.DataAccess.Concrete.EntityFramework
{
    public class ScrumTaskBoardDb2Context:DbContext
    {
        public DbSet<Kart> Kartlar { get; set; }
        public DbSet<TeknikUzman> TeknikUzmanlar { get; set; }
        public DbSet<IsTakip> IsTakipleri { get; set; }
       
    }
}
