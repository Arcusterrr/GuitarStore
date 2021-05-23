using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

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
