using Domain.Abstractions.Mediator;
using FluentValidation;

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
