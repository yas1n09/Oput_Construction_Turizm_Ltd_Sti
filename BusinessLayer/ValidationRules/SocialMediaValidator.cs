using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SocialMediaValidator : AbstractValidator<SocialMedia>
    {
        public SocialMediaValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(" Başlık Boş Geçilemez");
            RuleFor(x => x.Url).NotEmpty().WithMessage("Link kısmı Boş Geçilemez");
            RuleFor(x => x.Icon).NotEmpty().WithMessage("Resim kısmı Boş Geçilemez");
        }
    }
}
