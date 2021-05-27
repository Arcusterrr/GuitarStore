using Domain.Entities;
using Domain.Enums;
using Domain.UseCases.Queries;
using Domain.UseCases.Queries.Orders;
using Microsoft.AspNetCore.Mvc;
using Schedule.Identity;
using WebApp.Abstractions;

namespace WebApp.Controllers.Admin
{
    [Route("admin/api/v1/orders"), AuthorizeByRoles(UserRole.Admin, UserRole.Moderator)]
    public class OrdersAdminController: QueryController<OrdersViewModel, Cart, OrdersViewModel>
    {
        public OrdersAdminController(QueryHandler<OrdersViewModel, Cart, OrdersViewModel> queryHandler) : base(queryHandler)
        {
        }
    }
}