using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WisdomPetMedicine.Pet.Api.Infrastructure;

namespace WisdomPetMedicine.Pet.Api.Extensions
{
    public static class PetDbContextExtensions
    {
        public static void AddPetDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PetDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Pet"));
            });
        }
        public static void EnsurePetDbIsCreated(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<PetDbContext>();
            context.Database.EnsureCreated();
            context.Database.CloseConnection();
        }
    }
}