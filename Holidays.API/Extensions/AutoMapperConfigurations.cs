using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Reflection;
using AutoMapper;

namespace Holidays.API.Extensions
{
    public static class AutoMapperConfigurations
    {
        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            var assemblies = new List<Assembly> { Assembly.Load("Holidays.API.Features") };
            services.AddAutoMapper(assemblies);
        }
    }
}
