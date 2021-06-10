using Domain.Abstractions.Mediator;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UseCases.CartItems.Get
{
    public class GetCartemsInput: IUseCaseInput
    {
    }

    public class GetCartemsInputValidator: AbstractValidator<GetCartemsInput>
    {
        public GetCartemsInputValidator()
        {

        }
    }
}
