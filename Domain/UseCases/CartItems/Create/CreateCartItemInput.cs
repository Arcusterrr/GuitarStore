using Domain.Abstractions.Mediator;
using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

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
