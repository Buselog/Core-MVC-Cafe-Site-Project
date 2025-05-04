using CoffylabMVCProject.Entities;
using FluentValidation;

namespace CoffylabMVCProject.Validations
{
    public class TestimonialValidator : AbstractValidator<Testimonial>
    {
        public TestimonialValidator()
        {
            RuleFor(x => x.TestimonialTitle).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.Description).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.TestimonialRating).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.TestimonialImageUrl).NotEmpty().WithMessage("This field cannot be empty")
                                               .Must(link => Uri.IsWellFormedUriString(link, UriKind.Absolute))
                                               .WithMessage("Enter a valid URL");
        }
    }
}
