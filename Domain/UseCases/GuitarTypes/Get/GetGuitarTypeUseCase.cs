using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.UseCases.GuitarTypes.Get
{
    public class GetGuitarTypeUseCase : IUseCase<GetGuitarTypeInput>
    {
        private readonly IAppContext _context;

        public GetGuitarTypeUseCase(IAppContext context)
        {
            _context = context;
        }
        public async Task<IOutput> Handle(GetGuitarTypeInput request, CancellationToken cancellationToken)
        {
            var query = _context.GuitarTypes.AsQueryable();

            if (request.SortName == "ASC")
            {
                query = query.OrderBy(x => x.Name);
            }
            else
            {
                query = query.OrderByDescending(x => x.Name);
            }

            var items = await query.ToListAsync();

            return ActionOutput.SuccessData(new
            {
                items
            });
        }
    }
}
