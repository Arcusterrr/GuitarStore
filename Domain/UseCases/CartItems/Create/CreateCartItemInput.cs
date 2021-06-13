using Domain.Abstractions.Mediator;
using FluentValidation;

namespace Domain.UseCases.Orders.Create
{
    public class CreateCartItemInput : IUseCaseInput
    {
        public int guitarId;
    }
    public class CreateCartItemInputValidator : AbstractValidator<CreateCartItemInput>
    {
        public CreateCartItemInputValidator()
        {

        }
    }
}
