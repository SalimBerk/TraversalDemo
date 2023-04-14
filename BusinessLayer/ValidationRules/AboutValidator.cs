using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x=>x.Details).NotEmpty().WithMessage("Açıklama Kısmı Boş Geçilemez.");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen Görsel Seçiniz");
            RuleFor(x => x.Details).MinimumLength(50).WithMessage("Minumum 50 Karakter Giriniz");
            
        }
    }
}
