using CoffylabMVCProject.Entities;
using FluentValidation;

namespace CoffylabMVCProject.Validations
{
    public class AdminValidator : AbstractValidator<Admin>
    {
       public AdminValidator()
        {
            RuleFor(x => x.AdminName).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.Email).NotEmpty().WithMessage("This field cannot be empty")
                                 .EmailAddress().WithMessage("Enter a valid email address");
            RuleFor(x => x.password).NotEmpty().WithMessage("This field cannot be empty");
        }
    }
}
