using Domain.Abstractions.Data;

namespace Domain.Entities
{
    public class CartItem : IEntity
    {
        public int Id { get; set; }
        public Cart Cart { get; set; }
        public int CartId { get; set; }
        public Guitar Guitar { get; set; }
        public int GuitarId { get; set; }
        public int GuitarCount { get; set; }
    }
}
