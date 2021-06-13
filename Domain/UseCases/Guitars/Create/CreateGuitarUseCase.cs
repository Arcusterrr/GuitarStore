using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Abstractions.Queries;
using Domain.Entities;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.UseCases.Guitars.Create
{
    public class CreateGuitarUseCase : IUseCase<CreateGuitarInput>
    {
        private readonly IAppContext _context;
        private readonly IFileStorage _storage;

        public CreateGuitarUseCase(IAppContext context, IFileStorage storage)
        {
            _context = context;
            _storage = storage;
        }

        public async Task<IOutput> Handle(CreateGuitarInput request, CancellationToken cancellationToken)
        {
            await using var memoryStream = new MemoryStream();

            await request.Image.CopyToAsync(memoryStream, cancellationToken);

            var bytes = memoryStream.ToArray();

            var filename = await _storage.Save(bytes);

            var list = new List<string>();

            foreach (var requestFile in request.Files)
            {
                await using var memoryStream1 = new MemoryStream();

                await requestFile.CopyToAsync(memoryStream1, cancellationToken);

                var bytes1 = memoryStream1.ToArray();

                var filename1 = await _storage.Save(bytes1);
                list.Add("/api/v1/imgs/" + filename1);
            }

            var guitar = new Guitar
            {
                Img = "/api/v1/imgs/" + filename,
                DetailedImages = list.ToArray(),
                Cost = request.Cost,
                Count = request.Count,
                DateCreated = DateTime.Now,
                Description = request.Description,
                GuitarTypeId = request.GuitarTypeId,
                Name = request.Name,
                Rating = request.Rating,
            };

            await _context.Guitars.AddAsync(guitar, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);

            return ObjectOutput.CreateWithId(guitar.Id);
        }
    }
}