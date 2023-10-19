using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage(" Başlık Boş Geçilemez");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon kısmı Boş Geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail kısmı Boş Geçilemez");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Adres kısmı Boş Geçilemez");
        }
    }
}
