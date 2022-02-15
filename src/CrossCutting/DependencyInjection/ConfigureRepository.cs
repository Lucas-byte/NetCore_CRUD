using Core.Interfaces;
using Core.Services;
using Data.Dapper.Data;
using Data.EF.Context;
using Data.EF.Repository;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.DependencyInjection
{
    public static class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepositoryEF<>), typeof(BaseRepositoryEF<>));
            serviceCollection.AddScoped<IUserRepositoryEF, UserRepositoryEF>();

            serviceCollection.AddScoped<IUserRepository, UserRepository>();

            serviceCollection.AddDbContext<MyContext>(
                options => options.UseMySql("Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=MyNewPass")
                );
        }
    }
}
