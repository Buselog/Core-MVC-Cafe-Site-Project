using CoffylabMVCProject.Entities;
using FluentValidation;

namespace CoffylabMVCProject.Validations
{
    public class ChangePasswordValidator : AbstractValidator<Admin>
    {
        public ChangePasswordValidator()
        {
            RuleFor(x => x.CurrentPassword).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.NewPassword).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("This field cannot be empty");
        }
    }
}
