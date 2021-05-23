﻿using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Abstractions;
using Domain.Abstractions.Mediator;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions
{
    public static class DomainExtensions
    {
        private static readonly List<Type> Types = typeof(IUseCaseInput).Assembly.ExportedTypes.ToList();
        public static void InstallDomain(this IServiceCollection services)
        {
            services
                .AddTransient<IDateTimeProvider, DateTimeProvider>();;
        } 
    }
}