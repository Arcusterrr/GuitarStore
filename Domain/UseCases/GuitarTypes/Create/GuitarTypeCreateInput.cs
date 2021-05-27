using Domain.Abstractions.Mediator;
using FluentValidation;

namespace Domain.UseCases.GuitarTypes.Create
{
    public class GuitarTypeCreateInput: IUseCaseInput
    {
        public string Name { get; set; }
    }

    public class GuitarTypeCreateValidation : AbstractValidator<GuitarTypeCreateInput>
    {
        public GuitarTypeCreateValidation()
        {
            
        }
    }
}