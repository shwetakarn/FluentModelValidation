using FluentValidation;

namespace ModelValidation.Model
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
        RuleFor(temp => temp.ProductCode).NotEmpty();
        RuleFor(temp => temp.ProductName).Length(0,5);
        RuleFor(temp => temp.Price).NotEmpty();
        }
      
    }
}