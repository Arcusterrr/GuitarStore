using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.UseCases.Guitars.Get
{
    public class GetGuitarUseCase : IUseCase<GetGuitarInput>
    {
        private readonly IAppContext _context;

        public GetGuitarUseCase(IAppContext context)
        {
            _context = context;
        }

        public async Task<IOutput> Handle(GetGuitarInput request, CancellationToken cancellationToken)
        {
            var query = _context.Guitars.AsQueryable();

            if (request.TypeId.HasValue)
            {
                query = query.Where(x => x.GuitarTypeId == request.TypeId);
            }

            if (request.Sort == "Date")
            {
                if (request.Order == "ASC")
                {
                    query = query.OrderBy(x => x.DateCreated);
                }
                else
                {
                    query = query.OrderByDescending(x => x.DateCreated);
                }
            }
            else
            {
                if (request.Order == "ASC")
                {
                    query = query.OrderBy(x => x.Cost);
                }
                else
                {
                    query = query.OrderByDescending(x => x.Cost);
                }
            }


            query = query
                .Skip((request.Page - 1) * (request.PageSize ?? 10))
                .Take(request.PageSize ?? 10);

            var items = await query.ToListAsync();
            var totalCount = await _context.Guitars.CountAsync();

            return ActionOutput.SuccessData(new
            {
                items,
                totalCount
            });
        }
    }
}
