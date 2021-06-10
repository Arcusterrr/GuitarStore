using Domain.Abstractions.Mediator;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UseCases.Order.Remove
{
    public class RemoveCartItemInput: IUseCaseInput
    {
        public int GuitarId { get; set; }
    }

    public class RemoveCartItemInputValidator: AbstractValidator<RemoveCartItemInput>
    {
        public RemoveCartItemInputValidator()
        {

        }
    }
}
