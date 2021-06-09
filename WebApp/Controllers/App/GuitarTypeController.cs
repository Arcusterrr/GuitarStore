using Domain.UseCases.GuitarTypes.Get;
using Microsoft.AspNetCore.Mvc;
using Schedule.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Controllers.App
{
    [Route("api/v1/guitartypes")]
    public class GuitarTypeController : Controller
    {
        private readonly IUseCaseDispatcher _dispatcher;

        public GuitarTypeController(IUseCaseDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        [HttpGet]
        public async Task<IActionResult> GetGuitars([FromQuery] GetGuitarTypeInput request) =>
            await _dispatcher.DispatchAsync(request);
    }
}
