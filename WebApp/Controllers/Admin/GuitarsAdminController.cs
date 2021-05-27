using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Enums;
using Domain.UseCases.Guitars.Create;
using Domain.UseCases.Guitars.Edit;
using Domain.UseCases.Queries;
using Domain.UseCases.Queries.Guitars;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Schedule.Identity;
using Schedule.Implementations;
using WebApp.Abstractions;

namespace WebApp.Controllers.Admin
{
    [Route("admin/api/v1/guitars"), AuthorizeByRoles(UserRole.Admin, UserRole.Moderator)]
    public class GuitarsAdminController: QueryController<GuitarsViewModel, Guitar, GuitarsViewModel>
    {
        private readonly IUseCaseDispatcher _dispatcher;
        
        public GuitarsAdminController(QueryHandler<GuitarsViewModel, Guitar, GuitarsViewModel> queryHandler, IUseCaseDispatcher dispatcher) : base(queryHandler)
        {
            _dispatcher = dispatcher;
        }

        [HttpPost]
        public async Task<IActionResult> CreateGuitar([FromForm] CreateGuitarModel request, IFormFileCollection Files) =>
            await _dispatcher.DispatchAsync(new CreateGuitarInput
            {
                Name = request.Name,
                Description = request.Description,
                Cost = request.Cost,
                Count = request.Count,
                Rating = request.Rating,
                GuitarTypeId = request.GuitarTypeId,
                Image = Files.First().OpenReadStream(),
                Files = Files.Skip(1).Select(x => x.OpenReadStream()),
            });

        [HttpPut("{id}")]
        public async Task<IActionResult> EditGuitar([FromForm] CreateGuitarModel request, [FromRoute] int id,
            IFormFileCollection Files) =>
            await _dispatcher.DispatchAsync(new EditGuitarInput
            {
                Id = id,
                Name = request.Name,
                Description = request.Description,
                Cost = request.Cost,
                Count = request.Count,
                Rating = request.Rating,
                GuitarTypeId = request.GuitarTypeId,
                Image = Files.FirstOrDefault() != null ? Files.FirstOrDefault()!.OpenReadStream() : Stream.Null,
                Files = Files?.Skip(1).Select(x => x.OpenReadStream()) ?? Array.Empty<Stream>()
            });
    }

    public class CreateGuitarModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public int Count { get; set; }
        public int Rating { get; set; }
        public int GuitarTypeId { get; set; }
    }
}