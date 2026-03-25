using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ticTacToe.Application.Mapping;
using ticTacToe.Application.Services;
using ticTacToe.Application.Services.interfaces;

namespace ticTacToe.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            var applicationAssembly = typeof(ServiceCollectionExtensions).Assembly;

            services.AddAutoMapper(applicationAssembly);

            services.AddScoped<IPartidaService, PartidaService>();
        }

    }
}
