using Domain.Enums;
using Domain.UseCases.Order.Create;
using Domain.UseCases.Order.Get;
using Microsoft.AspNetCore.Mvc;
using Schedule.Identity;
using Schedule.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Controllers.App
{
    [Route("api/v1/order"), AuthorizeByRoles(UserRole.Participant)]
    public class OrderController : Controller
    {
        private readonly IUseCaseDispatcher _dispatcher;

        public OrderController(IUseCaseDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }
        [HttpGet]
        public async Task<IActionResult> GetOrder([FromQuery] GetOrdersInput request) =>
            await _dispatcher.DispatchAsync(request);

        [HttpPost("create")]
        public async Task<IActionResult> GetOrder([FromBody] CreateOrderInput request) =>
            await _dispatcher.DispatchAsync(request);
    }
}
