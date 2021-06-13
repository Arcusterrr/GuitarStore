using AutoMapper;
using Domain.Abstractions.Data;
using Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.UseCases.Queries.GuitarTypes
{
    public class GuitarTypesQueryHandler : QueryHandler<GuitarTypesViewModel, GuitarType, GuitarTypesViewModel>
    {
        public GuitarTypesQueryHandler(IAppContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        protected async override Task<IQueryable<GuitarType>> Filter(IQueryable<GuitarType> query, GuitarTypesViewModel filter)
        {
            if (!string.IsNullOrEmpty(filter.q))
            {
                return query.Where(x => x.Name.ToLower().Contains(filter.q.ToLower()));
            }

            return query;
        }
    }
}