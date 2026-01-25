using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Service;

namespace Api.Extensions
{
    public static class OrderServiceExtension
    {
        public static IServiceCollection AddOrderService(this IServiceCollection services)
        {
            return services.AddScoped<OrderService>();
        }
    }
}