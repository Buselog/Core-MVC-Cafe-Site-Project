using CoffylabMVCProject.Entities;
using FluentValidation;

namespace CoffylabMVCProject.Validations
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("This field cannot be empty");
        }
    }
}
