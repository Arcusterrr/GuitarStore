using Domain.Abstractions.Data;
using Domain.Abstractions.Mediator;
using Domain.Abstractions.Outputs;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.UseCases.Guitars.Get
{
    class GetGuitarByIdUseCase : IUseCase<GetGuitarInputById>
    {
        private readonly IAppContext _context;

        public GetGuitarByIdUseCase(IAppContext context)
        {
            _context = context;
        }

        public async Task<IOutput> Handle(GetGuitarInputById request, CancellationToken cancellationToken)
        {
            var query = await _context.Guitars.FirstOrDefaultAsync(x => x.Id == request.Id);

            return ActionOutput.SuccessData(query);
        }
    }
}
