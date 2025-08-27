using EducationalPlatform.Infrastructure.DependencyInjectionConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatform.Infrastructure.DependencyInjectionConfig
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructurecs(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            // Register other infrastructure services here
            // e.g., repositories, file storage services, etc.
            return services;
        }
    }
}
