using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class GuitarTypeConfiguration : IEntityTypeConfiguration<GuitarType>
    {
        public void Configure(EntityTypeBuilder<GuitarType> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
