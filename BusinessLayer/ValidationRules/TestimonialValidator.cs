using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TestimonialValidator : AbstractValidator<Testimonial>
    {
        public TestimonialValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(" İsim Boş Geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Meslek kısmı Boş Geçilemez");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("Yorum kısmı Boş Geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim kısmı Boş Geçilemez");
        }
    }
}
