using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MP.apiDotNet6.Domain.Repository;
using MP.ApiDotNet6.Application.Mappings;
using MP.ApiDotNet6.Application.services;
using MP.ApiDotNet6.infra.Data.context;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mp.ApiDoteNet6.infra.Ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<applicationDbcontext>(options =>
                                  options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<Equipmenty_repository, Equipmenty_repository>();
            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddAutoMapper(typeof(DomainToDTOMapping));
            services.AddScoped<EquipmentServices, EquipmentServices>();
        }

    }
}
