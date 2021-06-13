using AutoMapper;
using Domain.Abstractions.Queries;

namespace Domain.UseCases.Queries.GuitarTypes
{
    public class GuitarTypesViewModel : IFilter, IQueryOutput
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string q { get; set; }
    }

    public class GuitarTypeViewModelMapper : Profile
    {
        public GuitarTypeViewModelMapper()
        {
            CreateMap<Entities.GuitarType, GuitarTypesViewModel>();
        }
    }
}