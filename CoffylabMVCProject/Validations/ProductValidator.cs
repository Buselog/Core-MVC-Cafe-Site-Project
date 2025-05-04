using CoffylabMVCProject.Entities;
using FluentValidation;

namespace CoffylabMVCProject.Validations
{
    public class ProductValidator : AbstractValidator<Product>
    {
         public ProductValidator()
        {
            RuleFor(x => x.CategoryId).NotEqual(0).WithMessage("Please select a category");
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.Description).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.ProductPrice).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.ImageFile).NotNull().WithMessage("This field cannot be empty");

        }
    }
}
