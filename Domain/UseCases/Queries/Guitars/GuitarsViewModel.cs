using System;
using AutoMapper;
using Domain.Abstractions.Queries;

namespace Domain.UseCases.Queries.Guitars
{
    public class GuitarsViewModel: IFilter, IQueryOutput
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
    }

    public class GuitarViewModelMapper : Profile
    {
        public GuitarViewModelMapper()
        {
            CreateMap<Entities.Guitar, GuitarsViewModel>();
        }
    }
}