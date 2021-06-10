using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Services.Identity;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.UseCases.Order.Get
{
    public class GetOrdersUseCase : IUseCase<GetOrdersInput>
    {
        private readonly IAppContext _context;
        private readonly IMediator _mediator;

        public GetOrdersUseCase(IAppContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<IOutput> Handle(GetOrdersInput request, CancellationToken cancellationToken)
        {
            var currentUser = await _mediator.Send(new GetCurrentUserInput());

            var carts = await _context.Carts
                .Where(x => x.UserId == currentUser.Id && !x.Available)
                .Include(x => x.CartItems)
                    .ThenInclude(x => x.Guitar)
                .ToListAsync();

            var orders = carts.Select(x => new
            {
                x.Id,
                x.OrderDate,
                x.Address,
                Items = x.CartItems.Select(z => new
                {
                    z.Id,
                    Guitar = new
                    {
                        z.Guitar.Id,
                        z.Guitar.Name,
                        z.Guitar.Img,
                        z.Guitar.Cost,
                    },
                })
            });

            return ActionOutput.SuccessData(orders);
        }
    }
}
