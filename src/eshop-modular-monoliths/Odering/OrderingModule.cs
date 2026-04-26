using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering
{
    public static class OrderingModule
    {
        public static IServiceCollection AddOderingModule(this IServiceCollection services, IConfiguration configuration)
        {
            //services
            //    .AddApplicationServices()
            //    .AddInfrastructureServices(configuration)
            //    .AddApiServices(configuration);
            return services;
        }
        public static IApplicationBuilder UseOrderingModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}
