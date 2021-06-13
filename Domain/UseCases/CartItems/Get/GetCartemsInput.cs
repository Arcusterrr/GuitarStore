using Domain.Abstractions.Mediator;
using FluentValidation;

namespace Domain.UseCases.CartItems.Get
{
    public class GetCartemsInput : IUseCaseInput
    {
    }

    public class GetCartemsInputValidator : AbstractValidator<GetCartemsInput>
    {
        public GetCartemsInputValidator()
        {

        }
    }
}
