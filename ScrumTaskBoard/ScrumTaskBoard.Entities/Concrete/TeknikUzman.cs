using ScrumTaskBoard.Entities.Abstarct;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBoard.Entities.Concrete
{
    [Table("TeknikUzmanlar")]
    public class TeknikUzman:IEntity
    {
        public int TeknikUzmanId { get; set; }
        public string TeknikUzmanAd { get; set; }
        public int Sure { get; set; }
    }
}
