using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            if(request.Sort == "Date")
            {
                if(request.Order == "ASC")
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
                .Skip((request.Page - 1) * 10)
                .Take(10);

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
