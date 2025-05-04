using CoffylabMVCProject.Entities;
using FluentValidation;

namespace CoffylabMVCProject.Validations
{
    public class AddressValidator : AbstractValidator<Header>
    {
        public AddressValidator()
        {
            RuleFor(x => x.OpenHoursWeekdays).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.OpenHoursWeekends).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.Location).NotEmpty().WithMessage("This field cannot be empty");          
        }
    }
}
