using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PostLand.Application.Contracts;
using Postland.Persistencee.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Postland.Persistencee
{
    public static class PersistenceContainer
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PostDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("PostConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IPostRepository), typeof(PostRepository));

            return services;
        }
    }
}
