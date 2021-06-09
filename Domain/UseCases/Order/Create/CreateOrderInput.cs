using Domain.Abstractions.Mediator;
using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UseCases.Orders.Create
{
    public class CreateOrderInput : IUseCaseInput
    {
        public int guitarId;
        public string address;

    }
    public class CreateOrderInputValidator : AbstractValidator<CreateOrderInput>
    {
        public CreateOrderInputValidator()
        {

        }
    }
}
