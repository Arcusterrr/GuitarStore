using Domain.Abstractions.Mediator;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UseCases.GuitarTypes.Get
{
    public class GetGuitarTypeInput : IUseCaseInput
    {
        public string SortName { get; set; }
    }
    public class GetGuitarTypeInputValidtor : AbstractValidator<GetGuitarTypeInput>
    {
        public GetGuitarTypeInputValidtor()
        {
            RuleFor(x => x.SortName)
                .Must(x => x == "ASC" || x == "DESC")
                .WithMessage("Неверные параметры сортировки");
        }
    }
}
