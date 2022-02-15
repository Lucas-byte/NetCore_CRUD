using AutoMapper;
using Domain.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.DependencyInjection
{
    public static class AutoMapperSetup
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                AutoMapperConfig.RegisterMappings(cfg);
            });
        }

        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            var config = RegisterMappings();

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
