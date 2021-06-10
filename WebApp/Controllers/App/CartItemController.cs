using Domain.Enums;
using Domain.UseCases.CartItems.Get;
using Domain.UseCases.Order.Remove;
using Domain.UseCases.Orders.Create;
using Microsoft.AspNetCore.Mvc;
using Schedule.Identity;
using Schedule.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Controllers.App
{
    [Route("api/v1/cartitem"), AuthorizeByRoles(UserRole.Participant)]
    public class CartItemController : Controller
    {
        private readonly IUseCaseDispatcher _dispatcher;

        public CartItemController(IUseCaseDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }
        [HttpGet]
        public async Task<IActionResult> GetCartItem([FromQuery] GetCartemsInput request) =>
            await _dispatcher.DispatchAsync(request);


        [HttpPost("add/{id}")]
        public async Task<IActionResult> AddCartItem([FromRoute] int id) =>
            await _dispatcher.DispatchAsync(new CreateCartItemInput {
                guitarId = id
            });


        [HttpDelete("remove/{id}")]
        public async Task<IActionResult> RemoveCartItem([FromRoute] int id) =>
            await _dispatcher.DispatchAsync(new RemoveCartItemInput {
                GuitarId = id
            });
    }
}
