using ScrumTaskBoard.Entities.Abstarct;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBoard.Entities.Concrete
{
    [Table("Kartlar")]
    public class Kart:IEntity
    {
        public int KartId { get; set; }
        public int TeknikUzmanId { get; set; }
        public DateTime Tarih { get; set; }
        public int KartNo { get; set; }
        public string ProjeNoAd { get; set; }
        public int TahminiSure { get; set; }
        public int GerceklesenSure { get; set; }
        public string IsinAciklamasi { get; set; }
        public string Notlar { get; set; }
    }
}
