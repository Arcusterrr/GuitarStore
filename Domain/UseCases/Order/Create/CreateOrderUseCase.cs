using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Entities;
using Domain.Services.Identity;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.UseCases.Order.Create
{
    public class CreateOrderUseCase : IUseCase<CreateOrderInput>
    {
        private readonly IAppContext _context;
        private readonly IMediator _mediator;

        public CreateOrderUseCase(IAppContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }


        public async Task<IOutput> Handle(CreateOrderInput request, CancellationToken cancellationToken)
        {
            var currentUser = await _mediator.Send(new GetCurrentUserInput());

            var cart = await _context.Carts
                .Include(x => x.CartItems)
                .FirstAsync(x => x.UserId == currentUser.Id && x.Available);

            cart.Address = request.Address;
            cart.OrderDate = DateTime.Now;
            cart.Available = false;

            var newCart = new Cart
            {
                UserId = currentUser.Id,
                Available = true,
            };

            _context.Carts.Add(newCart);
            await _context.SaveChangesAsync();

            return ActionOutput.Success;
        }
    }
}
