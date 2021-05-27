using Domain.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Cart : IEntity
    {
        public int Id { get; set; }
        public bool Available { get; set; }
        public List<CartItem> CartItems { get; set; }
        public string Address { get; set; }
        public DateTime OrderDate { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
