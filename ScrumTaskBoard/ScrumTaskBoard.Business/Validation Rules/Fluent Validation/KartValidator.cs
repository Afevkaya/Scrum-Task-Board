using FluentValidation;
using ScrumTaskBoard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTaskBoard.Business.Validation_Rules.Fluent_Validation
{
    public class KartValidator:AbstractValidator<Kart>
    {
        public KartValidator()
        {
            RuleFor(k => k.KartNo).GreaterThan(0).WithMessage("Kart alanı 0 dan büyük olmalıdır");
           
            RuleFor(k => k.ProjeNoAd).NotEmpty().WithMessage("Proje No-Ad Bölümü boş geçilemez").
                Length(5, 50).WithMessage("Proje No-Ad 5 ile 50 karakter arasında olmalıdır");
            
            RuleFor(k => k.TeknikUzmanId).NotEmpty().WithMessage("Lutfen Teknik Uzman Seçiniz");
            
            RuleFor(k => k.TahminiSure).NotEmpty().WithMessage("Lutfen Seçmeyi Unutmayınız");
            
            RuleFor(k => k.GerceklesenSure).NotEmpty().WithMessage("Lutfen Gerçekleşme Süresini Giriniz").
                GreaterThan(0).WithMessage("Gerçekleşme Süresi 0 dan küçük olamaz");
            
            RuleFor(k => k.IsinAciklamasi).NotEmpty().WithMessage("Lutfen Doldurunuz").
                MinimumLength(10).WithMessage("Açıklama En Az 10 karakter içermelidir");
            
            RuleFor(k => k.Notlar).NotEmpty().WithMessage("Lutfen Doldurunuz").
                MinimumLength(10).WithMessage("Not En az 10 karakter içermelidir");
        }

       
    }
}
