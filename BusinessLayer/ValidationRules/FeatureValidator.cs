using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class FeatureValidator : AbstractValidator<Feature>
    {
        public FeatureValidator()
        {
            RuleFor(x=>x.Header).NotEmpty().WithMessage(" Başlık Boş Geçilemez");
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Açıklama kısmı Boş Geçilemez");
        }
    }
}
