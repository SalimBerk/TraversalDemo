using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator() {

            RuleFor(x => x.Name).NotEmpty().WithMessage(x => ValidatorOptions.Global.LanguageManager.GetString("NotEmptyValidator",new CultureInfo("tr")));
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad Alanı Boş Geçilemez.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Geçilemez.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez.");
        }
    }
}
