using Domain.Adapters;
using Infra.Database.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Database
{
    public static class DatabaseModuleDependency
    {
        public static void AddDatabaseModule(this IServiceCollection services)
        {
            services.AddScoped<IClubRepository, ClubRepository>();
        }
    }
}
