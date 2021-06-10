using Domain.Abstractions.Mediator;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UseCases.Order.Create
{
    public class CreateOrderInput: IUseCaseInput
    {
        public string Address { get; set; }
    }

    public class CreateOrderInputValidator: AbstractValidator<CreateOrderInput>
    {
        public CreateOrderInputValidator()
        {

        }
    }
}
