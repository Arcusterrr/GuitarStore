using Domain.Abstractions.Mediator;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UseCases.Guitars.Get
{
    public class GetGuitarInputById : IUseCaseInput
    {
        public int Id { get; set; }
    }
    public class GetGuitarInputByIdValidator : AbstractValidator<GetGuitarInputById>
    {
        public GetGuitarInputByIdValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
        }
    }
}
