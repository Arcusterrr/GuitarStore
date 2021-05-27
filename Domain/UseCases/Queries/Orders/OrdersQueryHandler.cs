using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Abstractions.Data;
using Domain.Entities;

namespace Domain.UseCases.Queries.Orders
{
    public class OrdersQueryHandler: QueryHandler<OrdersViewModel, Cart, OrdersViewModel>
    {
        public OrdersQueryHandler(IAppContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        protected async override Task<IQueryable<Cart>> Filter(IQueryable<Cart> query, OrdersViewModel filter)
        {
            return query.Where(x => !x.Available);
        }
    }
}