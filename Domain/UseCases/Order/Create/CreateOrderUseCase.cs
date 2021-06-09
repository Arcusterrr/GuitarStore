using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Entities;
using Domain.Services.Identity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.UseCases.Orders.Create
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

            var cart = new Cart
            {
                Available = false,
                Address = request.address,
                OrderDate = DateTime.Now,
                UserId = currentUser.Id,
            };

            var cartItem = new CartItem
            {
                CartId = 
            };
        }
    }
}
