using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Domain.Services.Identity;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.UseCases.CartItems.Get
{
    public class GetCartItemsUseCase : IUseCase<GetCartemsInput>
    {
        private readonly IAppContext _context;
        private readonly IMediator _mediator;

        public GetCartItemsUseCase(IAppContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }
        public async Task<IOutput> Handle(GetCartemsInput request, CancellationToken cancellationToken)
        {
            var currentUser = await _mediator.Send(new GetCurrentUserInput());

            var cart = await _context.Carts
                .Include(x => x.CartItems)
                    .ThenInclude(x => x.Guitar)
                .FirstAsync(x => x.UserId == currentUser.Id && x.Available);

            var items = cart.CartItems.Select(x => new
            {
                x.Id,
                Guitar = new
                {
                    x.Guitar.Id,
                    x.Guitar.Name,
                    x.Guitar.Img,
                    x.Guitar.Cost,
                },
            });

            return ActionOutput.SuccessData(new
            {
                cart.Id,
                Items = items,
            });
        }
    }
}
