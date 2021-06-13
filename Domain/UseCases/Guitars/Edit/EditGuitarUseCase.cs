using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Abstractions.Queries;
using Domain.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.UseCases.Guitars.Edit
{
    public class EditGuitarUseCase : IUseCase<EditGuitarInput>
    {
        private readonly IAppContext _context;
        private readonly IFileStorage _storage;

        public EditGuitarUseCase(IAppContext context, IFileStorage storage)
        {
            _context = context;
            _storage = storage;
        }

        public async Task<IOutput> Handle(EditGuitarInput request, CancellationToken cancellationToken)
        {
            var guitar = await _context.Guitars.FirstAsync(x => x.Id == request.Id, cancellationToken: cancellationToken);

            var image = guitar.Img;

            if (request.Image != Stream.Null)
            {
                await using var memoryStream = new MemoryStream();

                await request.Image.CopyToAsync(memoryStream, cancellationToken);

                var bytes = memoryStream.ToArray();
                image = await _storage.Save(bytes);
                image = "/api/v1/imgs/" + image;
            }

            var list = request.Files.ToList();
            var listOf = new List<string>();

            foreach (var stream in list)
            {
                await using var memoryStream1 = new MemoryStream();

                await stream.CopyToAsync(memoryStream1, cancellationToken);

                var bytes1 = memoryStream1.ToArray();

                var filename1 = await _storage.Save(bytes1);
                listOf.Add("/api/v1/imgs/" + filename1);
            }

            if (listOf.Count != 0)
            {
                guitar.DetailedImages = listOf.ToArray();
            }

            guitar.Cost = request.Cost;
            guitar.Img = image;
            guitar.Count = request.Count;
            guitar.Name = request.Name;
            guitar.Description = request.Description;
            guitar.Rating = request.Rating;
            guitar.GuitarTypeId = request.GuitarTypeId;

            await _context.SaveChangesAsync(cancellationToken);

            return ObjectOutput.CreateWithId(guitar.Id);
        }
    }
}