using Domain.Abstractions.Mediator;
using FluentValidation;

namespace Domain.UseCases.GuitarTypes.Edit
{
    public class GuitarTypeEditInput: IUseCaseInput
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class GuitarTypeEditInputValidator : AbstractValidator<GuitarTypeEditInput>
    {
        public GuitarTypeEditInputValidator()
        {
            
        }
    }
}