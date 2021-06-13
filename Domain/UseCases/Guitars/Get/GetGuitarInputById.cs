using Domain.Abstractions.Mediator;
using FluentValidation;

namespace Domain.UseCases.Guitars.Get
{
    public class GetGuitarInputById : IUseCaseInput
    {
        public int Id { get; set; }
    }
    public class GetGuitarInputByIdValidator : AbstractValidator<GetGuitarInputById>
    {
        public GetGuitarInputByIdValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
        }
    }
}
