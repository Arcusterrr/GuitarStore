using System.Threading.Tasks;
using Domain.Entities;
using Domain.Enums;
using Domain.UseCases.GuitarTypes.Create;
using Domain.UseCases.GuitarTypes.Edit;
using Domain.UseCases.Queries;
using Domain.UseCases.Queries.GuitarTypes;
using Microsoft.AspNetCore.Mvc;
using Schedule.Identity;
using Schedule.Implementations;
using WebApp.Abstractions;

namespace WebApp.Controllers.Admin
{
    [Route("admin/api/v1/guitartypes"), AuthorizeByRoles(UserRole.Admin, UserRole.Moderator)]
    public class GuitarTypesAdminController: QueryController<GuitarTypesViewModel, GuitarType, GuitarTypesViewModel>
    {
        private readonly IUseCaseDispatcher _dispatcher;
        
        public GuitarTypesAdminController(QueryHandler<GuitarTypesViewModel, GuitarType, GuitarTypesViewModel> queryHandler, IUseCaseDispatcher dispatcher) : base(queryHandler)
        {
            _dispatcher = dispatcher;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] GuitarTypeCreateInput request) =>
            await _dispatcher.DispatchAsync(request);
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit([FromRoute] int id, [FromBody] GuitarTypeCreateInput request) =>
            await _dispatcher.DispatchAsync(new GuitarTypeEditInput
            {
                Id = id,
                Name = request.Name,
            });
        
    }
}