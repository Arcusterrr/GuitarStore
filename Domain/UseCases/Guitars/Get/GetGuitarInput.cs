using Domain.Abstractions.Mediator;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UseCases.Guitars.Get
{
    public class GetGuitarInput : IUseCaseInput
    {
        public string Sort { get; set; }
        public int Page { get; set; }
        public string Order { get; set; }
    }

    public class GetGuitarInputValidtor : AbstractValidator<GetGuitarInput>
    {
        public GetGuitarInputValidtor()
        {
            RuleFor(x => x.Sort)
                .Must(x => x == "Date" || x == "Price")
                .WithMessage("Неверные параметры сортировки");

            RuleFor(x => x.Order)
                .Must(x => x == "ASC" || x == "DESC")
                .WithMessage("Неверные параметры сортировки");

            RuleFor(x => x.Page).GreaterThan(0);
        }
    }
}
