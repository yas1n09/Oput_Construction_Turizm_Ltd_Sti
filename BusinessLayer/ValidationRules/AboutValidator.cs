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
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Hakkımızda Başlığı Boş Geçilemez");
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Açıklama kısmı Boş Geçilemez");
            RuleFor(x=>x.ImageUrl).NotEmpty().WithMessage("Fotoğraf Kısmı Boş Geçilemez");
        }
    }
}
