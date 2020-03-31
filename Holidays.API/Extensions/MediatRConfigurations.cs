using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Reflection;

namespace Holidays.API.Extensions
{
    public static class MediatRConfigurations
    {
        public static void ConfigureMediatR(this IServiceCollection services)
        {
            var assemblies = new List<Assembly> { Assembly.Load("Holidays.API.Features") };
            services.AddMediatR(assemblies.ToArray());
        }
    }
}
