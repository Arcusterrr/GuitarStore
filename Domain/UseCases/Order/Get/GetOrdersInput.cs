using Domain.Abstractions.Mediator;
using FluentValidation;

namespace Domain.UseCases.Order.Get
{
    public class GetOrdersInput : IUseCaseInput
    {
    }

    public class GetOrdersValidator : AbstractValidator<GetOrdersInput>
    {
        public GetOrdersValidator()
        {

        }
    }
}
