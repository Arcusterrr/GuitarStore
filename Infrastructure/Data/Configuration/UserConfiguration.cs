using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class UserConfiguration: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.Carts).WithOne(x => x.User).HasForeignKey(x => x.UserId);

            builder
                .HasMany(u => u.RolesEntities)
                .WithOne()
                .HasForeignKey(r => r.UserId)
                .IsRequired();
        }
    }
}