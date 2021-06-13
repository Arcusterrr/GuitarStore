using AutoMapper;
using Domain.Abstractions.Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.UseCases.Queries.Orders
{
    public class OrdersQueryHandler : QueryHandler<OrdersViewModel, Cart, OrdersViewModel>
    {
        public OrdersQueryHandler(IAppContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        protected override IQueryable<Cart> GetQuery()
        {
            return base.GetQuery().Include(x => x.CartItems).ThenInclude(x => x.Guitar);
        }

        protected async override Task<IQueryable<Cart>> Filter(IQueryable<Cart> query, OrdersViewModel filter)
        {
            return query.Where(x => !x.Available);
        }
    }
}