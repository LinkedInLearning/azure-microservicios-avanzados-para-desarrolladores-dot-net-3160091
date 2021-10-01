using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WisdomPetMedicine.Rescue.Api.Infrastructure;

namespace WisdomPetMedicine.Rescue.Api.Extensions
{
    public static class RescueDbContextExtensions
    {
        public static void AddRescueDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RescueDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Rescue"));
            });
        }
        public static void EnsureRescueDbIsCreated(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<RescueDbContext>();
            context.Database.EnsureCreated();
            context.Database.CloseConnection();
        }
    }
}