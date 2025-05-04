using CoffylabMVCProject.Entities;
using FluentValidation;

namespace CoffylabMVCProject.Validations
{
    public class AboutValidator :AbstractValidator<Meet>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.Subtitle).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.ShortDescription).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.FullDescription).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.VideoUrl).NotEmpty().WithMessage("This field cannot be empty")
                                    . Must(link => Uri.IsWellFormedUriString(link, UriKind.Absolute))
                                    .WithMessage("Enter a valid URL");
        }
    }
}
