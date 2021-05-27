using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Abstractions.Data;
using Domain.Entities;

namespace Domain.UseCases.Queries.Guitars
{
    public class GuitarsQueryHandler : QueryHandler<GuitarsViewModel, Entities.Guitar, GuitarsViewModel>
    {
        public GuitarsQueryHandler(IAppContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        protected async override Task<IQueryable<Guitar>> Filter(IQueryable<Guitar> query, GuitarsViewModel filter)
        {
            return query;
        }
    }
}