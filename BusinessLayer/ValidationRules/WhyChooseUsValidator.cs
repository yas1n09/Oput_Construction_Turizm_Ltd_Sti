using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WhyChooseUsValidator : AbstractValidator<WhyChooseUs>
    {
        public WhyChooseUsValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage(" Başlık Boş Geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmı Boş Geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim kısmı Boş Geçilemez");
        }
    }
}
