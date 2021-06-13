using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Abstractions.Queries;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.UseCases.GuitarTypes.Edit
{
    public class GuitarTypeEditUseCase : IUseCase<GuitarTypeEditInput>
    {
        private readonly IAppContext _context;

        public GuitarTypeEditUseCase(IAppContext context)
        {
            _context = context;
        }

        public async Task<IOutput> Handle(GuitarTypeEditInput request, CancellationToken cancellationToken)
        {
            var type = await _context.GuitarTypes.FirstAsync(x => x.Id == request.Id, cancellationToken);

            type.Name = request.Name;

            await _context.SaveChangesAsync(cancellationToken);

            return ObjectOutput.CreateWithId(type.Id);
        }
    }
}