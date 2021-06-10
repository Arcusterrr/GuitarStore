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

namespace Domain.UseCases.Order.Remove
{
    public class RemoveCartItemUseCase : IUseCase<RemoveCartItemInput>
    {
        private readonly IAppContext _context;
        private readonly IMediator _mediator;

        public RemoveCartItemUseCase(IMediator mediator, IAppContext context)
        {
            _mediator = mediator;
            _context = context;
        }

        public async Task<IOutput> Handle(RemoveCartItemInput request, CancellationToken cancellationToken)
        {
            var currentUser = await _mediator.Send(new GetCurrentUserInput());

            var cart = await _context.Carts
                .Include(x => x.CartItems)
                .FirstAsync(x => x.UserId == currentUser.Id && x.Available);

            var item = cart.CartItems.FirstOrDefault(x => x.GuitarId == request.GuitarId);

            if (item is null)
            {
                return ActionOutput.Success;
            }

            _context.CartItems.Remove(item);

            await _context.SaveChangesAsync();

            return ActionOutput.Success;
        }
    }
}
