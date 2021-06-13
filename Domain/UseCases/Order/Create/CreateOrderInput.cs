using Domain.Abstractions.Mediator;
using FluentValidation;

namespace Domain.UseCases.Order.Create
{
    public class CreateOrderInput : IUseCaseInput
    {
        public string Address { get; set; }
    }

    public class CreateOrderInputValidator : AbstractValidator<CreateOrderInput>
    {
        public CreateOrderInputValidator()
        {

        }
    }
}
