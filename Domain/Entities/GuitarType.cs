using Domain.Abstractions.Data;

namespace Domain.Entities
{
    public class GuitarType : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
