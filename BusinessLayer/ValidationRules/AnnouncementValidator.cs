using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Resources;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator:AbstractValidator<AnnouncementAddDTO>
    {
        public AnnouncementValidator() { 
            RuleFor(x=>x.Title).NotEmpty().WithMessage(x => ValidatorOptions.Global.LanguageManager.GetString("NotEmptyValidator", new CultureInfo("tr")));
            RuleFor(x=>x.Content).NotEmpty().WithMessage("Lütfen Duyuru İçeriğini Boş Geçmeyin.");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Veri Girişi Yapınız.");
        
        }
    }
}
