using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CrossCutting.DependencyInjection
{
    public static class MediatRSetup
    {
        public static void ConfigureMediatRSetup(this IServiceCollection serviceCollection)
        {
            var assembly = AppDomain.CurrentDomain.Load("Domain");
            serviceCollection.AddMediatR(assembly);
        }
    }
}
