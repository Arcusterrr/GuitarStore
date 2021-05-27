using Domain.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{

    public class Guitar : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public string[] DetailedImages { get; set; }
        public int Cost { get; set; }
        public int Count { get; set; }
        public int Rating { get; set; }
        public DateTime DateCreated { get; set; }
        public int GuitarTypeId { get; set; }
        public GuitarType GuitarType { get; set; }
    }
}
