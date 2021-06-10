using Domain.Abstractions.Mediator;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UseCases.Order.Get
{
    public class GetOrdersInput: IUseCaseInput
    {
    }

    public class GetOrdersValidator: AbstractValidator<GetOrdersInput>
    {
        public GetOrdersValidator()
        {

        }
    }
}
