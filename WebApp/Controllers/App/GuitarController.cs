using Domain.UseCases.Guitars.Get;
using Microsoft.AspNetCore.Mvc;
using Schedule.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Controllers.App
{
    [Route("api/v1/guitars")]
    public class GuitarController : Controller
    {
        private readonly IUseCaseDispatcher _dispatcher;

        public GuitarController(IUseCaseDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        [HttpGet]
        public async Task<IActionResult> GetGuitars([FromQuery] GetGuitarInput request) =>
            await _dispatcher.DispatchAsync(request);
    }
}
