using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SendContactUsValidator:AbstractValidator<SendMessageDTO>
    {
        public SendContactUsValidator() {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez.");
        
        
        }
    }
}
