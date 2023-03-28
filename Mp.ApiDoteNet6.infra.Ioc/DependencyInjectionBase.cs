using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MP.ApiDotNet6.Application.Mappings;
using MP.ApiDotNet6.Application.services;

namespace Mp.ApiDoteNet6.infra.Ioc
{
    public static class DependencyInjectionBase
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(DomainToDTOMapping));
            services.AddScoped<EquipmentServices, EquipmentServices>();
        }
    }
}