using ScrumTaskBoard.Entities.Abstarct;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBoard.Entities.Concrete
{
    [Table("IsTakipleri")]
    public class IsTakip:IEntity
    {
        public int IsTakipId { get; set; }
        public int KartId { get; set; }
        public string IsTakipAciklama { get; set; }
    }
}
