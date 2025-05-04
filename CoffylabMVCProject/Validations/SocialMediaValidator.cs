using CoffylabMVCProject.Entities;
using FluentValidation;


namespace CoffylabMVCProject.Validations
{
    public class SocialMediaValidator : AbstractValidator<SocialMedia>
    {
       public SocialMediaValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.Icon).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x=>x.Link).NotEmpty().WithMessage("This field cannot be empty");
        }
    }
}
