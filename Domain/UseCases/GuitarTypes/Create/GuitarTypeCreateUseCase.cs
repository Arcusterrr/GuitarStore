using System.Threading;
using System.Threading.Tasks;
using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Abstractions.Queries;
using Domain.Entities;

namespace Domain.UseCases.GuitarTypes.Create
{
    public class GuitarTypeCreateUseCase: IUseCase<GuitarTypeCreateInput>
    {
        private readonly IAppContext _context;

        public GuitarTypeCreateUseCase(IAppContext context)
        {
            _context = context;
        }

        public async Task<IOutput> Handle(GuitarTypeCreateInput request, CancellationToken cancellationToken)
        {
            var guitarType = new GuitarType
            {
                Name = request.Name,
            };

            await _context.GuitarTypes.AddAsync(guitarType, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);
            
            return ObjectOutput.CreateWithId(guitarType.Id);
        }
    }
}