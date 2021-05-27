using System;
using System.Collections.Generic;
using AutoMapper;
using Domain.Abstractions.Queries;
using Domain.Entities;
using Domain.UseCases.Queries.Guitars;

namespace Domain.UseCases.Queries.Orders
{
    public class OrdersViewModel : IFilter, IQueryOutput
    {
        public int Id { get; set; }
        public List<CartItemViewModel> CartItems { get; set; }
        public string Address { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
    }

    public class CartItemViewModel
    {
        public int Id { get; set; }
        public GuitarsViewModel Guitar { get; set; }
        public int GuitarCount { get; set; }
    }

    public class CartItemMapper : Profile
    {
        public CartItemMapper()
        {
            CreateMap<CartItem, CartItemViewModel>();
            CreateMap<Entities.Cart, OrdersViewModel>();
        }
    }
}