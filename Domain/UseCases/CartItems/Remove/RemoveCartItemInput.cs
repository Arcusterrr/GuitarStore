using Domain.Abstractions.Mediator;
using FluentValidation;

namespace Domain.UseCases.Order.Remove
{
    public class RemoveCartItemInput : IUseCaseInput
    {
        public int GuitarId { get; set; }
    }

    public class RemoveCartItemInputValidator : AbstractValidator<RemoveCartItemInput>
    {
        public RemoveCartItemInputValidator()
        {

        }
    }
}
