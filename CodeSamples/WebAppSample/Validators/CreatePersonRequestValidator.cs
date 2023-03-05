using FluentValidation;
using LearnDotNet.WebAppSample.Controllers;

namespace LearnDotNet.WebAppSample.Validators;

public sealed class MyClassValidator : AbstractValidator<WeatherForecastController.MyClass>
{
    public MyClassValidator()
    {
        RuleFor(x => x.Value)
            .NotNull()
            .NotEmpty()
            .WithMessage("Value should not be null or empty");
        
        RuleFor(x => x.IntValue)
            .GreaterThan(100)
            .WithMessage("IntValue should be greater than 100");
    }
}
