using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ticTacToe.Domain.Interfaces;
using ticTacToe.Infrastructure.Persistence;
using ticTacToe.Infrastructure.Repository;

namespace ticTacToe.Infrastructure.Extensions
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<IPartidaRepository, PartidaRepository>();

            return services;
        }
    }
}
