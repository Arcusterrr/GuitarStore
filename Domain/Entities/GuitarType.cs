using Domain.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class GuitarType : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
