﻿using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
 using Domain.Entities;
 using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Domain.Abstractions.Data
{
    public interface IAppContext: IUnitOfWorkCreator
    {
        DbSet<User> Users { get; set; }
        DbSet<Cart> Carts { get; set; }
        DbSet<CartItem> CartItems { get; set; }
        DbSet<Guitar> Guitars { get; set; }
        DbSet<GuitarType> GuitarTypes { get; set; }
        DbSet<TEntity> Set<TEntity>() where TEntity : class, IEntity;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        EntityEntry<TEntity> Entry<TEntity>([NotNull] TEntity entity)
            where TEntity : class, IEntity;
    }
}