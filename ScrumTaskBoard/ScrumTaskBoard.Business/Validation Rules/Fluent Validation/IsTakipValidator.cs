using FluentValidation;
using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBoard.Business.Validation_Rules.Fluent_Validation
{
    public class IsTakipValidator: AbstractValidator<IsTakip>
    {
        public IsTakipValidator()
        {
            RuleFor(i => i.IsTakipAciklama).NotEmpty().WithMessage("İş Takip Açıklama Kısmı Boş Bırakılamaz");
        }
    }
}
