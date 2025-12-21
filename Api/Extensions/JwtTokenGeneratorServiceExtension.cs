using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Service;

namespace Api.Extensions
{
    public static class JwtTokenGeneratorServiceExtension
    {
        public static IServiceCollection AddJwtTokenGenerator(this IServiceCollection services)
        {
            return services.AddScoped<JwtTokenGenerator>();
        }
    }
}