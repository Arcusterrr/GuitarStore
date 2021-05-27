using System.Collections.Generic;
using System.IO;
using Domain.Abstractions.Mediator;
using FluentValidation;

namespace Domain.UseCases.Guitars.Edit
{
    public class EditGuitarInput: IUseCaseInput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Stream Image { get; set; }
        public IEnumerable<Stream> Files { get; set; }
        public int Cost { get; set; }
        public int Count { get; set; }
        public int Rating { get; set; }
        public int GuitarTypeId { get; set; }
    }

    public class EditGuitarInputValidator : AbstractValidator<EditGuitarInput>
    {
        public EditGuitarInputValidator()
        {
            
        }
    }
}