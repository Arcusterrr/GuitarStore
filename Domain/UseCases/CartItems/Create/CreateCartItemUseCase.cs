using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Entities;
using Domain.Services.Identity;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.UseCases.Orders.Create
{
    public class CreateCartItemUseCase : IUseCase<CreateCartItemInput>
    {
        private readonly IAppContext _context;
        private readonly IMediator _mediator;

        public CreateCartItemUseCase(IAppContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<IOutput> Handle(CreateCartItemInput request, CancellationToken cancellationToken)
        {
            var currentUser = await _mediator.Send(new GetCurrentUserInput());

            var cart = await _context.Carts
                .Include(x => x.CartItems)
                .FirstAsync(x => x.UserId == currentUser.Id && x.Available);

            if (cart.CartItems.Select(x => x.GuitarId).Contains(request.guitarId))
            {
                return ActionOutput.Failure("Такая гитара уже есть в корзине");
            }

            var cartItem = new CartItem
            {
                CartId = cart.Id,
                GuitarId = request.guitarId,
            };

            _context.CartItems.Add(cartItem);

            await _context.SaveChangesAsync();

            return ActionOutput.Success;
        }
    }
}
